// Copyright AyeTSG 2022.
// Handles items within a kulection

using System.Drawing;

namespace KulectorDB
{
    [Serializable]
    public class KulectionItem
    {
        public string ItemName;
        public string ItemDescription;
        public int ItemQuantity;
        public Bitmap ItemImage;

        // Default constructor for a kulection item
        public KulectionItem(string Name, string Description, int Quantity)
        {
            ItemName = Name;
            ItemDescription = Description;
            ItemQuantity = Quantity;
            ItemImage = new Bitmap(256, 256);
        }

        // Default constructor for a kulection item
        public KulectionItem(string Name, string Description, int Quantity, Bitmap Image)
        {
            ItemName = Name;
            ItemDescription = Description;
            ItemQuantity = Quantity;
            ItemImage = Image;
        }
    }
}
