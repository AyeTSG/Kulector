// Copyright AyeTSG 2022.


// Handles a single kulection
// Such as holding its items, and general
// versioning info for future use.

using System.Drawing;

namespace KulectorDB
{
    [Serializable]
    public class Kulection
    {
        // the name of the kulection
        public string KulectionName;

        // the version of KulectionDB
        // that this kulection was
        // last saved / edited with
        public string KulectionVersion;

        // the items this kulection holds
        public List<KulectionItem> KulectionItems;

        // default constructor for a kulection
        public Kulection(string Name)
        {
            // set default properties
            KulectionName = Name;
            KulectionVersion = KulectorDB.VersionInfo.VERSION;
            KulectionItems = new List<KulectionItem>();
        }

        // adds an item to the kulection
        public void AddItem(KulectionItem Item)
        {
            KulectionItems.Add(Item);
        }

        // adds an item with
        // pre-configured values
        public void AddItem(string ItemName, string ItemDescription, int ItemQuantity)
        {
            KulectionItem tmpitem = new KulectionItem(ItemName, ItemDescription, ItemQuantity);
            KulectionItems.Add(tmpitem);
        }

        // adds an item with
        // pre-configured values
        public void AddItem(string ItemName, string ItemDescription, int ItemQuantity, Bitmap ItemImage)
        {
            KulectionItem tmpitem = new KulectionItem(ItemName, ItemDescription, ItemQuantity, ItemImage);
            KulectionItems.Add(tmpitem);
        }

        // removes an item from the kulection
        public void RemoveItem(KulectionItem Item)
        {
            KulectionItems.Remove(Item);
        }
    }
}
