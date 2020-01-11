using Mine.Models;

namespace Mine.ViewModels
{
    public class ItemReadViewModel : BaseViewModel
    {
        /// <summary>
        /// The Item Model
        /// </summary>
        public ItemModel Data { get; set; }

        /// <summary>
        /// Constructor takes an existing item and sets
        /// The Title for the page to match the text of data
        /// The Data to be the passed in data
        /// </summary>
        /// <param name="data"></param>
        public ItemReadViewModel(ItemModel data = null)
        {
            Title = data?.Text;
            Data = data;
        }
    }
}
