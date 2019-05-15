using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验12_观察者模式_气象站 {
    class Phone : Device {
        public string PhoneNumber { get; set; }

        public override void Update(Subject data) {
            if (data.GetType().ToString().ToUpper().Contains("WEATHER")) {
                var weatherData = data as WeatherData;

                if (weatherData != null) {
                    Console.WriteLine(
                        $"号码为 {PhoneNumber} 的手机收到最新气象数据，[温度：{weatherData.Temperature}；湿度：{weatherData.Humidity}；气压：{weatherData.Pressure}]");
                }
            }
            else if (data.GetType().ToString().ToUpper().Contains("TRAFFIC")) {
                var trafficData = data as TrafficData;

                if (trafficData != null) {
                    Console.WriteLine(
                        $"号码为 {PhoneNumber} 的手机收到最新交通数据，[街道：{trafficData.Street}；状态：{trafficData.Status}]");
                }
            }
        }
    }
}