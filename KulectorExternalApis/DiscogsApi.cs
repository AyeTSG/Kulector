// Copyright AyeTSG 2022.

// Handles the usage of the
// Discogs API for Kulector

using System.Net;
using Newtonsoft.Json;

namespace KulectorExternalApis
{
    public class DiscogsApi
    {
        // API Keys (Don't abuse these D:)
        public string ConsumerKey = "knPSwgpLveqTOPVEslxs";
        public string ConsumerSecret = "SWniTMjmWpcCDbeBWAHZWrbMoLOhieMm";

        // Returns an image URL for a release ID
        public string GetPrimaryImage(string ReleaseID)
        {
            string ImageUrl;

            // Create a new web client
            using (var wb = new WebClient())
            {
                // Set the User Agent
                wb.Headers.Add("User-Agent", "KulectorDiscogsApi v1.0");

                // Grab the response data
                dynamic data = JsonConvert.DeserializeObject(wb.DownloadString("https://api.discogs.com/releases/" + ReleaseID + "?key=" + ConsumerKey + "&secret=" + ConsumerSecret));

                // Grab the image URL
                ImageUrl = data["images"][0]["uri"];
            }

            // Return the URL
            return ImageUrl;
        }
    }
}
