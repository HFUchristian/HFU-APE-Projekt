using MyFirstApp.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyFirstApp.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        public ItemDetailViewModel()
        {
            Title = "Item";
        }
        private string itemId;
        private string text;
        private string description;
        private string description2;
        private int age;
        public string Id { get; set; }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public int Age
        {
            get => age;
            set => SetProperty(ref age, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public string Description2
        {
            get => description2;
            set => SetProperty(ref description2, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
                Description2 = item.Description2;
                Age = item.Age;
                Title = Text;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
