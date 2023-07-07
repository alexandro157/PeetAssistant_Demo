using PettAssitantApp.Models;
using PettAssitantApp.ViewModels;
using Xamarin.Forms;

namespace PettAssitantApp.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}