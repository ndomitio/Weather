using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace Weather.Models
{
    public class WeatherClass
    {
        public Object getWeatherForecast()
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Cleveland&APPID=01173c00c49e46d41a2f0e4454a42705&units=imperial";
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }

        public Object getThreeDay()
        {
            string url = "http://api.openweathermap.org/data/2.5/forecast?zip=44143,us&APPID=01173c00c49e46d41a2f0e4454a42705&units=imperial";
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
}