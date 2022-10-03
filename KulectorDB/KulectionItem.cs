// Handles items within a kulection

namespace KulectorDB
{
    [Serializable]
    public class KulectionItem
    {
        public string ItemName;
        public string ItemDescription;
        public int ItemQuantity;
        public Guid ItemId;

        // Default constructor for a kulection item
        public KulectionItem(string Name, string Description, int Quantity)
        {
            ItemName = Name;
            ItemDescription = Description;
            ItemQuantity = Quantity;
            ItemId = Guid.NewGuid();
        }
    }
}
