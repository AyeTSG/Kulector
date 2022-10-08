// Copyright AyeTSG 2022.


// Handles a single item
// held within a Kulection

using System.Drawing;

namespace KulectorDB
{
    [Serializable]
    public class KulectionItem
    {
        // the name of the item
        public string ItemName;

        // the description data
        // of the item
        public string ItemDescription;

        // the quantity of the item
        public int ItemQuantity;

        // the image associated
        // with the item
        public Bitmap ItemImage;

        // Default constructor for a kulection item
        public KulectionItem(string Name, string Description, int Quantity)
        {
            // set default values
            ItemName = Name;
            ItemDescription = Description;
            ItemQuantity = Quantity;
            ItemImage = new Bitmap(256, 256);
        }

        // Default constructor for a kulection item
        public KulectionItem(string Name, string Description, int Quantity, Bitmap Image)
        {
            // set default values
            ItemName = Name;
            ItemDescription = Description;
            ItemQuantity = Quantity;
            ItemImage = Image;
        }
    }
}
