namespace Mine.Models
{
    /// <summary>
    /// Menu Item Lists
    /// </summary>
    public enum MenuItemType
    {
        Browse,
        About
    }

    /// <summary>
    /// Home Menu Item Model
    /// </summary>
    public class HomeMenuItemModel
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}