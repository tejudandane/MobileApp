﻿namespace Mine.Models
{
    /// <summary>
    /// Item for the Game
    /// </summary>
    public class ItemModel : BaseModel
    {
        // Add Unique attributes for Item

        // The Value of the Item

        public int Value { get; set; } = 0;

        public ItemModel() { }
        public ItemModel(ItemModel data)
        {
            Id = data.Id;
            Name = data.Name;
            Description = data.Description;
            Value = data.Value;
        }
        public bool Update(ItemModel data)
        {
            // Do not update the Id , if you do, the record will be orphaned
            //Id = data.Id;

            //Update the Base
            Name = data.Name;
            Description = data.Description;

            //Update the extended
            Value = data.Value;

            return true;
        }
    }
}