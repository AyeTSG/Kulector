// Copyright AyeTSG 2022.

// Creates and saves a Kulection file
// with random entries, primarily to test
// the viability of serializing the Kulection
// class to a file.

using System.Drawing;
using KulectorDB;
using KulectorExternalApis;
using KulectorExporter;

namespace KulectorDevTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("testing creation...");

            // create a new random seed
            Random rnd = new Random();

            // create a new kulection
            Kulection testCol = new Kulection(rnd.Next(0, 512).ToString());

            // set colors var
            Array colors = Enum.GetValues(typeof(System.Drawing.KnownColor));

            // bulk add test items
            for (int i = 0; i < 16; i++)
            {
                // make an item with a random name, description, and quantity
                KulectionItem testItem = new KulectionItem(rnd.Next(0, 512).ToString(), rnd.Next(0, 512).ToString(), rnd.Next(1, 64));

                // randomize image data
                for (int x = 0; x < 255; x++)
                {
                    for (int y = 0; y < 255; y++)
                    {
                        // set the pixel
                        testItem.ItemImage.SetPixel(x, y, System.Drawing.Color.FromKnownColor((System.Drawing.KnownColor)colors.GetValue(rnd.Next(colors.Length))));
                    }
                }

                // add the item to the kulection
                testCol.AddItem(testItem);
            }

            // save it.
            Console.WriteLine("testing saving...");
            KulectionSerialization.WriteKulectionFile("./TEST.kul", testCol);

            // load the kulection
            Console.WriteLine("testing loading...");
            Kulection testLoadCol = KulectionSerialization.LoadKulectionFile("./TEST.kul");

            // testing discogs api
            Console.WriteLine("testing discogs api...");
            DiscogsApi DiscogsApi = new DiscogsApi();
            Bitmap test = DiscogsApi.GetPrimaryImage("24252608");
            Console.WriteLine("image got! ");

            // test text file export
            Console.WriteLine("testing .txt export...");
            TxtFileExport txtExport = new TxtFileExport();
            txtExport.Export(testLoadCol, "./TEST_EXPORT.txt");
        }
    }
}