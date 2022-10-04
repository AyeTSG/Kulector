// Copyright AyeTSG 2022.
// Handles a single kulection

namespace KulectorDB
{
    public class KulectionConstants
    {
        public static string VERSION = "v0.1";
    }

    [Serializable]
    public class Kulection
    {
        public string KulectionName;
        public static string KulectionVersion;
        public List<KulectionItem> KulectionItems;

        // default constructor for a kulection
        public Kulection(string Name)
        {
            KulectionName = Name;
            KulectionVersion = KulectionConstants.VERSION;
            KulectionItems = new List<KulectionItem>();
        }

        // adds an item to the kulection
        public void AddItem(KulectionItem Item)
        {
            KulectionItems.Add(Item);
        }

        // adds an item advancely
        public void AddItem(string ItemName, string ItemDescription, int ItemQuantity)
        {
            KulectionItem tmpitem = new KulectionItem(ItemName, ItemDescription, ItemQuantity);

            KulectionItems.Add(tmpitem);
        }

        // removes an item from the kulection
        public void RemoveItem(KulectionItem Item)
        {
            KulectionItems.Remove(Item);
        }
    }
}
