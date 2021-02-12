using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Ebotiga2.DataModel;
using Ebotiga2.Model;
using Xamarin.Forms.Xaml;
using System.Reflection;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Diagnostics;

using System.Net.Http;
using Ebotiga2.ViewModels;

namespace Ebotiga2
{

    public partial class MainPage : ContentPage
    {
        public int Count = 0;
        public short Counter = 0;
        public int SlidePosition = 0;
        string heightList;
        int heightRowsList = 90;
        private const string Url = "https://mobxamarinandroid.azurewebsites.net/article_repository.json";
        // This handles the Web data request
        private HttpClient _client = new HttpClient();

        public MainPage()
        {

            InitializeComponent();
            // We call the OnGetList from Here 

            //OnGetList();
            var ar= new ArticlePageView();
            ar.GetData();
            BindingContext = ar;
        }

        protected async void OnGetList()
        {

            //Getting JSON data from the Web
            var content = await _client.GetStringAsync(Url);
            //We deserialize the JSON data from this line
            var tr = JsonConvert.DeserializeObject<List<Articles>>(content);
            //After deserializing , we store our data in the List called ObservableCollection
            ObservableCollection<Articles> trends = new ObservableCollection<Articles>(tr);
            BindingContext = trends;
        }
    }
}




