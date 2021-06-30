using Countries.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Countries
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void lstCountries_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var obj = (Country)e.SelectedItem;

            double[] lalo = obj.latlng;

            var country = new Country
            {
                name = obj.name,
                capital = obj.capital,
                region = obj.region,
                population = obj.population,
                flag = obj.flag
            };

            var detalles = new Details(lalo[0],lalo[1]);
            detalles.BindingContext = country;
            await Navigation.PushAsync(detalles);

        }

        private async void regionPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (regionPicker.SelectedIndex)
            {
                case 0:
                    const String URL = "https://restcountries.eu/rest/v2/region/africa";
                    try
                    {
                        countriesManager manager = new countriesManager();
                        var res = await manager.getCoutries(URL);

                        if (res!=null)
                        {
                            lstCountries.ItemsSource = res;
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;

                case 1:
                    const String URL1 = "https://restcountries.eu/rest/v2/region/americas";
                    try
                    {
                        countriesManager manager = new countriesManager();
                        var res = await manager.getCoutries(URL1);

                        if (res != null)
                        {
                            lstCountries.ItemsSource = res;
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;

                case 2:
                    const String URL2 = "https://restcountries.eu/rest/v2/region/asia";
                    try
                    {
                        countriesManager manager = new countriesManager();
                        var res = await manager.getCoutries(URL2);

                        if (res != null)
                        {
                            lstCountries.ItemsSource = res;
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;

                case 3:
                    const String URL3 = "https://restcountries.eu/rest/v2/region/europe";
                    try
                    {
                        countriesManager manager = new countriesManager();
                        var res = await manager.getCoutries(URL3);

                        if (res != null)
                        {
                            lstCountries.ItemsSource = res;
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;

                case 4:
                    const String URL4 = "https://restcountries.eu/rest/v2/region/oceania";
                    try
                    {
                        countriesManager manager = new countriesManager();
                        var res = await manager.getCoutries(URL4);

                        if (res != null)
                        {
                            lstCountries.ItemsSource = res;
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
