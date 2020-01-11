namespace Mine.Models
{
    /// <summary>
    /// Menu Item Lists
    /// </summary>
    public enum MenuItemTypeEnum
    {
        Browse,
        About,
    }

    /// <summary>
    /// Home Menu Item Model
    /// </summary>
    public class HomeMenuItemModel
    {
        public MenuItemTypeEnum Id { get; set; }

        public string Title { get; set; }
    }
}