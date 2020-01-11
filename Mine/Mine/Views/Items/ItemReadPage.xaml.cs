using System.ComponentModel;
using Xamarin.Forms;

using Mine.Models;
using Mine.ViewModels;

namespace Mine.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer

    /// <summary>
    /// The Read Page
    /// </summary>

    [DesignTimeVisible(false)]
    public partial class ItemReadPage : ContentPage
    {
        ItemReadViewModel viewModel;

        public ItemReadPage(ItemReadViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemReadPage()
        {
            InitializeComponent();

            var data = new ItemModel
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new ItemReadViewModel(data);
            BindingContext = viewModel;
        }
    }
}