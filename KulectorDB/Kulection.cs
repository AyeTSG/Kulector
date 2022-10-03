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
        private List<KulectionItem> KulectionItems;

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

        // removes an item from the kulection
        public void RemoveItem(KulectionItem Item)
        {
            KulectionItems.Remove(Item);
        }
    }
}
