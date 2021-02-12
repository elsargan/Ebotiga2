using Ebotiga2.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace Ebotiga2.ViewModels
{
    public class ArticlePageView : INotifyPropertyChanged
    {


        private const string url = "https://mobxamarinandroid.azurewebsites.net/article_repository.json";
        public List<Articles> data;


        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
        #endregion

        public ArticlePageView()
        {
            SearchCommand = new Command(async (searchTerm) =>
            {

                await GetData();
            });
        }

        public ICommand SearchCommand { get; set; }


        // This handles the Web data request


        public  List<Articles> Data
        {
            get=> data;
            
            set
            {
                data = value;
                OnPropertyChanged();
            }
        }



        public async Task GetData()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(url); //sends a get request to the specified uri and returns the response body as a string in an asynchronous operation
            response.EnsureSuccessStatusCode();
            var json_Result = await client.GetStringAsync(url);
            var result = JsonConvert.DeserializeObject<List<Articles>>(json_Result); //Deserializes or converts JSON String into a collection of Post
            Data = result;


            //var client = new HttpClient();
            //var response = await client.GetAsync(url); //Sends a GET request to the specified Uri and returns the response body as a string in an asynchronous operation
            //response.EnsureSuccessStatusCode();
            //var json_Result = await response.Content.ReadAsStringAsync();
            //var result = JsonConvert.DeserializeObject<ObservableCollection<Articles>>(json_Result); //Deserializes or converts JSON String into a collection of Post
            //Data = result;

        }

    }

}
