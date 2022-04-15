namespace Pathoschild.Stardew.LookupAnything.Framework.Data
{
    /// <summary>A loot entry parsed from the game data.</summary>
    internal class ItemDropData
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The item's unqualified item ID.</summary>
        public string ItemID { get; }

        /// <summary>The minimum number to drop.</summary>
        public int MinDrop { get; }

        /// <summary>The maximum number to drop.</summary>
        public int MaxDrop { get; }

        /// <summary>The probability that the item will be dropped.</summary>
        public float Probability { get; }


        /*********
        ** Public methods
        *********/
        /// <summary>Construct an instance.</summary>
        /// <param name="itemID">The unqualified item ID.</param>
        /// <param name="minDrop">The minimum number to drop.</param>
        /// <param name="maxDrop">The maximum number to drop.</param>
        /// <param name="probability">The probability that the item will be dropped.</param>
        public ItemDropData(string itemID, int minDrop, int maxDrop, float probability)
        {
            this.ItemID = itemID;
            this.MinDrop = minDrop;
            this.MaxDrop = maxDrop;
            this.Probability = probability;
        }
    }
}
