using KulectorDB;

namespace KulectorDevTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("testing creation...");

            // create a new kulection
            Kulection testCol = new Kulection("Test Kulection");

            // bulk add test items

            for (int i = 0; i < 4096; i++)
            {
                KulectionItem testItem = new KulectionItem("Bulk Item", "Bulk Item Description");
                testCol.AddItem(testItem);
            }

            Console.WriteLine("testing saving...");

            // save it.
            KulectionSerialization.WriteKulectionFile("./TEST.kul", testCol);

            Console.WriteLine("testing loading...");

            // load a kulection
            Kulection testLoadCol = KulectionSerialization.LoadKulectionFile("./TEST.kul");
        }
    }
}