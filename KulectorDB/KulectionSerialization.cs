﻿// Copyright AyeTSG 2022.

// Handles serialization/deserialization
// of a Kulection to/from a file.

using System.Drawing;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using KulectorDB.Utils;

namespace KulectorDB
{
    public static class KulectionSerialization
    {
        // handles pre-save tasks
        public static Kulection PreSave(Kulection _Kulection)
        {
            // for each item...
            foreach (KulectionItem Item in _Kulection.KulectionItems)
            {
                // get its image
                Image tmpImage = Item.ItemImage;

                // check if its over 256x256
                if (tmpImage.Width >= 256 || tmpImage.Height >= 256)
                {
                    // resize it down to 256x256
                    tmpImage = ImageUtil.ResizeImage(tmpImage, 256, 256);

                    // set the original image back
                    Item.ItemImage = (Bitmap)tmpImage;
                }

            }

            return _Kulection;
        }

        // saves a kulection to a v2 file
        public static void WriteKulectionFileV2(string FilePath, Kulection _Kulection)
        {
            // do presave stuff
            _Kulection = PreSave(_Kulection);

            // create a fs stream
            using (Stream stream = File.Open(FilePath, FileMode.Create))
            {
                // gzip later, need to see plaintext for testing

                using (StreamWriter writer = new StreamWriter(stream))
                {
                    new JsonSerializer().Serialize(new JsonTextWriter(writer), _Kulection);
                }
            }
        }

        // saves a kulection to a file
        public static void WriteKulectionFile(string FilePath, Kulection _Kulection)
        {
            // do presave stuff
            _Kulection = PreSave(_Kulection);

            // create a fs stream
            using (Stream stream = File.Open(FilePath, FileMode.Create))
            {
                using (GZipStream GZStream = new GZipStream(stream, CompressionMode.Compress))
                {
                    // create and serialize the file
                    var BinFormat = new BinaryFormatter();
                    BinFormat.Serialize(GZStream, _Kulection);
                }

            }
        }

        // loads a kulection from a v2 file
        public static Kulection LoadKulectionFileV2(string FilePath)
        {
            // create a fs stream
            using (Stream stream = File.Open(FilePath, FileMode.Open))
            {
                // gzip later

                using (var reader = new StreamReader(stream))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    Kulection retKul = (Kulection)serializer.Deserialize(reader, typeof(Kulection));

                    return retKul;
                }
            }
        }

        // loads a kulection from a file
        public static Kulection LoadKulectionFile(string FilePath)
        {
            // create a fs stream
            using (Stream stream = File.Open(FilePath, FileMode.Open))
            {
                using (GZipStream GZStream = new GZipStream(stream, CompressionMode.Decompress))
                {
                    // open and deserialize the file
                    var BinFormat = new BinaryFormatter();
                    return (Kulection)BinFormat.Deserialize(GZStream);
                }
            }
        }
    }
}
