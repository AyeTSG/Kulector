// Copyright AyeTSG 2022.
using KulectorDB;

namespace KulectorDevTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("testing creation...");

            Random rnd = new Random();

            // create a new kulection
            Kulection testCol = new Kulection(rnd.Next(0, 512).ToString());

            // set colors var
            Array colors = Enum.GetValues(typeof(System.Drawing.KnownColor));

            // bulk add test items
            for (int i = 0; i < 16; i++)
            {
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