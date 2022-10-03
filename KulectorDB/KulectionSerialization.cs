// Handles serialization/deserialization to/from a file

using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;

namespace KulectorDB
{
    public static class KulectionSerialization
    {
        // saves a kulection to a file
        public static void WriteKulectionFile(string FilePath, Kulection _Kulection)
        {
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
