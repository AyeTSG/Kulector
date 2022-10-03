// Handles serialization/deserialization to/from a file

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
                // create and serialize the file
                var BinFormat = new BinaryFormatter();
                BinFormat.Serialize(stream, _Kulection);
            }
        }

        // loads a kulection from a file
        public static Kulection LoadKulectionFile(string FilePath)
        {
            // create a fs stream
            using (Stream stream = File.Open(FilePath, FileMode.Open))
            {
                // create and deserialize the file
                var BinFormat = new BinaryFormatter();
                return (Kulection)BinFormat.Deserialize(stream);
            }
        }
    }
}
