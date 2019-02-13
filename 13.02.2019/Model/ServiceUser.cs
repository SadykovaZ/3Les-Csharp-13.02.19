using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2019.Model
{
    public class ServiceUser
    {
        public ServiceUser(string URL)
        {
            this.URL = URL;
        }

        public string URL { get; set; }

        /// <summary>
        /// Метод возвращает список пользователей
        /// </summary>
        /// <returns></returns>
        public Users GetUsers()
        {
            string json = GetJsonUser();
            return JsonConvert.DeserializeObject<Users>(json);
        }
        private string GetJsonUser()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;


            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                return reader.ReadToEnd();

                //Console.WriteLine(json);

              
            }

           
        }

    }
}
