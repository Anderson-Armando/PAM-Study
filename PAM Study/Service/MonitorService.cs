using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PAM_Study.Models;

namespace PAM_Study.Service
{
    public class MonitorService
    {

        private HttpClient client;
        private Models.Monitor monitor;
        private ObservableCollection<Models.Monitor> monitors;
        private JsonSerializerOptions serializerOptions;

        public MonitorService(){

            client = new HttpClient();
            serializerOptions = new JsonSerializerOptions {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase, 
                WriteIndented = true
            };
        }

        public async Task<ObservableCollection<Models.Monitor>> getAllMonitorsAsync()
        {
            Uri uri = new Uri("http://localhost:8080/");
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    monitors = JsonSerializer.Deserialize<ObservableCollection<Models.Monitor>>(content, serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return monitors;
        } 
    } 
}
