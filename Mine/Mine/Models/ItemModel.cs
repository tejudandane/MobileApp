using System;

namespace Mine.Models
{
    public class ItemModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Text { get; set; }
        public string Description { get; set; }
    }
}