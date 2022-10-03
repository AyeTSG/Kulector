// Handles items within a kulection

namespace KulectorDB
{
    [Serializable]
    public class KulectionItem
    {
        public string ItemName;
        public string ItemDescription;
        public Guid ItemId;

        // Default constructor for a kulection item
        public KulectionItem(string Name, string Description)
        {
            ItemName = Name;
            ItemDescription = Description;
            ItemId = Guid.NewGuid();
        }
    }
}
