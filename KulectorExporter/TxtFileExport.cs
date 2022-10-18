// Copyright AyeTSG 2022.

// Handles exporting a Kulection
// to a text file.

using KulectorDB;

namespace KulectorExporter
{
    public class TxtFileExport
    {
        public void Export(Kulection InKul, string OutFile)
        {
            // create a stream writer
            using StreamWriter outFile = new(OutFile);

            // write the data
            outFile.WriteLine("=== " + InKul.KulectionName + " ===");
            outFile.WriteLine("");

            foreach (KulectionItem Item in InKul.KulectionItems)
            {
                outFile.WriteLine("- " + Item.ItemName + " [" + Item.ItemQuantity + "x]");
            }
        }
    }
}
