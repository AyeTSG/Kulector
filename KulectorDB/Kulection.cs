// Handles a single kulection

namespace KulectorDB
{
    [Serializable]
    public class Kulection
    {
        public string KulectionName;
        private List<KulectionItem> KulectionItems;

        // default constructor for a kulection
        public Kulection(string Name)
        {
            KulectionName = Name;
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
