using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerBearStudios.Mirror.GUI.Weather
{
    class 
        WeatherModel : BaseModel
    {
        Weather currentWeather;
        public Weather CurrentWeather
        {
            get
            {
                return currentWeather;
            }
            set
            {
                if (currentWeather != value)
                {
                    currentWeather = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public override TimeSpan Interval => throw new NotImplementedException();

        public override void Update()
        {
            CurrentWeather = Weather.Now;
        }
    }
}
