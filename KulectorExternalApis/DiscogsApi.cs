// Copyright AyeTSG 2022.

// Handles the usage of the
// Discogs API for Kulector

using System.Drawing;
using System.Net;
using KulectorDB;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;

namespace KulectorExternalApis
{
    public class DiscogsApi
    {
        // API Keys (Don't abuse these D:)
        public string ConsumerKey = "knPSwgpLveqTOPVEslxs";
        public string ConsumerSecret = "SWniTMjmWpcCDbeBWAHZWrbMoLOhieMm";

        // Returns an image URL for a release ID
        public Bitmap GetPrimaryImage(string ReleaseID)
        {
            // Create a new web client
            using (var wb = new WebClient())
            {
                // Set the User Agent
                wb.Headers.Add("User-Agent", "KulectorDiscogsApi v1.0");

                // Grab the response data
                dynamic data = JsonConvert.DeserializeObject(wb.DownloadString("https://api.discogs.com/releases/" + ReleaseID + "?key=" + ConsumerKey + "&secret=" + ConsumerSecret));

                // Grab the image
                try
                {
                    Stream imgStream = wb.OpenRead((string)data["images"][0]["uri"]);
                    Bitmap imgBit = new Bitmap(imgStream);
                    return imgBit;
                } catch (Exception)
                {
                    Bitmap imgBit = new Bitmap(256, 256);
                    return imgBit;
                }
            }
        }

        // Creates a Kulection, from a Discogs CSV Export
        public Kulection FromCollectionCsv(string FileName)
        {
            // Create a new Kulection
            Kulection outKul = new Kulection("Discogs Import");

            // Parse the CSV file
            using (TextFieldParser CsvParse = new TextFieldParser(FileName))
            {
                // Set the parsing properties
                CsvParse.TextFieldType = FieldType.Delimited;
                CsvParse.SetDelimiters(",");

                // Parse the actual CSV data
                while (!CsvParse.EndOfData)
                {
                    // Skip the CSV Header
                    //CsvParse.ReadLine();

                    string[] CsvFields = CsvParse.ReadFields();

                    string CatalogNumber = CsvFields[0];
                    string Artist = CsvFields[1];
                    string Title = CsvFields[2];
                    string Label = CsvFields[3];
                    string Format = CsvFields[4];
                    string Rating = CsvFields[5];
                    string ReleaseDate = CsvFields[6];
                    string ReleaseID = CsvFields[7];
                    string CollectionFolder = CsvFields[8];
                    string DateAdded = CsvFields[9];
                    string MediaCondition = CsvFields[10];
                    string SleeveCondition = CsvFields[11];
                    string Notes = CsvFields[12];

                    // Format the description
                    string FinalDesc = "Catalog Number: " + CatalogNumber + "\n";
                    FinalDesc += "Label: " + Label + "\n";
                    FinalDesc += "Rating: " + Rating + "\n";
                    FinalDesc += "Release Date: " + ReleaseDate + "\n";
                    FinalDesc += "Release ID: " + ReleaseID + "\n";
                    FinalDesc += "Collection Folder: " + CollectionFolder + "\n";
                    FinalDesc += "Date Added: " + DateAdded + "\n";
                    FinalDesc += "Media Condition: " + MediaCondition + "\n";
                    FinalDesc += "Sleeve Condition: " + SleeveCondition + "\n";
                    FinalDesc += "Notes: " + Notes + "\n";

                    // Create the Kulection item
                    KulectionItem DiscogsItem = new KulectionItem(Artist + " - " + Title + " (" + Format + ")", FinalDesc, 1);

                    // Grab the image
                    if (int.TryParse(ReleaseID, out _))
                    {
                        DiscogsItem.ItemImage = GetPrimaryImage(ReleaseID);
                    }

                    outKul.AddItem(DiscogsItem);
                }
            }

            // Remove the CSV header
            outKul.RemoveItem(outKul.KulectionItems[0]);

            // Return the final Kulection
            return outKul;
        }
    }
}
