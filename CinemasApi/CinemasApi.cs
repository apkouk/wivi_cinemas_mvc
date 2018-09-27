using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using cinevo_mvc.Models;
using Newtonsoft.Json;

namespace cinevo_mvc.CinemasApi
{
    public static class CinemasApi
    {
        private static HttpClient client;
        private static void LoadClient()
        {
            if (client == null)
            {
                client = new HttpClient { BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseUrl"]) };
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }
        }

        public static List<Cinema> GetAllCinemas()
        {
            LoadClient();
            HttpResponseMessage response = client.GetAsync("api/cinemas").Result;
            if (response.IsSuccessStatusCode)
            {
                var cinemas = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<Cinema>>(cinemas);
            }
            return null;
        }

        public static Cinema GetCinemaById(string id)
        {
            LoadClient();
            HttpResponseMessage response = client.GetAsync("api/cinemas/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var cinemas = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Cinema>(cinemas);
            }
            return null;
        }

        public static Cinema Edit(string id)
        {
            LoadClient();
            HttpResponseMessage response = client.GetAsync("api/cinemas/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var cinemas = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Cinema>(cinemas);
            }
            return null;
        }

        public static void DeleteCinema(string id)
        {
            LoadClient();
            client.DeleteAsync("api/cinemas/" + id);
        }

        public static void AddNewCinema(Cinema cinema)
        {
            LoadClient();
            var content = new StringContent( JsonConvert.SerializeObject(cinema), Encoding.UTF8, "application/json");
            client.PostAsync("api/cinemas/", content);
        }
        
        public static void UpdateCinema(Cinema cinema)
        {
            LoadClient();
            var content = new StringContent(JsonConvert.SerializeObject(cinema), Encoding.UTF8, "application/json");
            client.PutAsync("api/cinemas/", content);
        }
    }
}