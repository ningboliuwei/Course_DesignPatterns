using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验12_观察者模式_气象站
{
    class Lcd : WeatherDataDevice
    {
        public string Location { get; set; }

        public override void Update(Subject data)
        {
            if (data.GetType().ToString().ToUpper().Contains("WEATHER"))
            {
                var weatherData = data as WeatherData;

                if (weatherData != null)
                {
                    Console.WriteLine(
                        $"地点为 {Location} 的 LCD 收到最新气象数据，[温度：{weatherData.Temperature}；湿度：{weatherData.Humidity}；气压：{weatherData.Pressure}]");
                }
            }
        }
    }
}
