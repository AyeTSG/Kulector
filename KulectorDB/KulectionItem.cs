// Copyright AyeTSG 2022.


// Handles a single item
// held within a Kulection

using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using Newtonsoft.Json;

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
        [JsonIgnore]
        public Bitmap ItemImage;

        // the xml-serializeable image
        // https://stackoverflow.com/a/1907165
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [JsonProperty("ItemImage")]
        public byte[] ItemImageXmlSerialize
        {
            get
            {
                if (ItemImage == null) return null;

                using (MemoryStream ms = new MemoryStream())
                {
                    ItemImage.Save(ms, ImageFormat.Png);
                    return ms.ToArray();
                }
            }

            set
            {
                if (value == null)
                {
                    ItemImage = null;
                } else
                {
                    using (MemoryStream ms = new MemoryStream(value))
                    {
                        ItemImage = new Bitmap(ms);
                    }
                }
            }
        }

        // need this for serialization >:L
        private KulectionItem()
        {

        }

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
