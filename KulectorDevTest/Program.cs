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

            // add test items
            KulectionItem testItem1 = new KulectionItem("Test 1", "Test Item 1");
            KulectionItem testItem2 = new KulectionItem("Test 2", "Test Item 2");

            testCol.AddItem(testItem1);
            testCol.AddItem(testItem2);

            Console.WriteLine("testing saving...");

            // save it.
            KulectionSerialization.WriteKulectionFile("./TEST.kul", testCol);

            Console.WriteLine("testing loading...");

            // load a kulection
            Kulection testLoadCol = KulectionSerialization.LoadKulectionFile("./TEST.kul");
        }
    }
}