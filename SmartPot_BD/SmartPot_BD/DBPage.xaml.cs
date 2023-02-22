using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartPot_BD
    //vvvv
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DBPage : ContentPage
    {
        public DBPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            dbList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }

        private async void dbList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            BDData bDData = new BDData();
            DB data = (DB)e.SelectedItem;
            bDData.BindingContext = data;
            await Navigation.PushAsync(bDData);
        }
    }
}