using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using Mine.Services;
using Mine.Models;
using Mine.Views;

namespace Mine.ViewModels
{
    public class ItemIndexViewModel : BaseViewModel
    {
        public ObservableCollection<ItemModel> Dataset { get; set; }

        /// <summary>
        /// Connection to the Data store
        /// </summary>
        public IDataStore<ItemModel> DataStore => DependencyService.Get<IDataStore<ItemModel>>();

        public Command LoadDatasetCommand { get; set; }

        public ItemIndexViewModel()
        {
            Title = "Browse";

            Dataset = new ObservableCollection<ItemModel>();
            LoadDatasetCommand = new Command(async () => await ExecuteLoadDatasetCommand());

            MessagingCenter.Subscribe<ItemCreatePage, ItemModel>(this, "Create", async (obj, data) =>
            {
                var newData = data as ItemModel;
                Dataset.Add(newData);
                await DataStore.CreateAsync(newData);
            });
        }

        async Task ExecuteLoadDatasetCommand()
        {
            if (IsBusy)
            {
                return;
            }

            IsBusy = true;

            try
            {
                Dataset.Clear();
                var dataset = await DataStore.IndexAsync(true);
                foreach (var data in dataset)
                {
                    Dataset.Add(data);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}