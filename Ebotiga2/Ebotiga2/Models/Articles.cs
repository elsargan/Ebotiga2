using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ebotiga2.Model
{

    public class Articles
    {

        private const string Url = "https://mobxamarinandroid.azurewebsites.net/";

        public Articles()
        {
            id = "0000";
            image_url = "images/default.jpg";
            thumbnail_url = "images/default.jpg";
        }

        public Articles(string source_id, string source_type, string source_name, float source_price, string source_image, int source_image_width,
            int source_image_height, string source_thumbnail, int source_thumbnail_width, int source_thumbnail_height)
        {
            id = source_id;
            type = source_type;
            name = source_type;
            price = source_price;
            image_url = source_image;
            image_width = source_image_width;
            image_height = source_image_height;
            thumbnail_url = source_thumbnail;
            thumbnail_width = source_thumbnail_width;
            thumbnail_height = source_thumbnail_height;
        }



            public string id { get; set; }
            public string type { get; set; }
            public string name { get; set; }
            public float price { get; set; }
            public string image_url { get; set; }
            public string uri_image => $"{Url}{image_url}";
            public int image_width { get; set; }
            public int image_height { get; set; }
            public string thumbnail_url { get; set; }
            public int thumbnail_width { get; set; }
            public int thumbnail_height { get; set; }
     


    }
}
