using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SmartPot_BD
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnReciver_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            DB newData = new DB()
            {
                Brightness = random.Next(100),
                WaterLevel = random.Next(100),
                Humidity = random.Next(100),
            };
            if (!String.IsNullOrEmpty(newData.Id.ToString()))
            {
                App.Database.SaveItem(newData);
            }
            List<DB> data = App.Database.GetItems().ToList();
            LabelHumidity.Text = $"Влажность почвы:{data[data.Count - 1].Humidity.ToString()}";
            LabelLight.Text = $"Освещенность: {data[data.Count - 1].Brightness.ToString()}";
            LabelWater.Text = $"Уровень воды: {data[data.Count - 1].WaterLevel.ToString()}";
        }

        private async void btnBd_Clicked(object sender, EventArgs e)
        {
            DBPage dBPage = new DBPage();
            await Navigation.PushAsync(dBPage); 
        }
    }
}
