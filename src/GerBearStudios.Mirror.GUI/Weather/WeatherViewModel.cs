using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerBearStudios.Mirror.GUI.Weather
{
    public class WeatherViewModel : PropertyChangedBase
    {
        private WeatherModel model;
        private string currentWeather;
        public string CurrentWeather
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

        internal void Initialize (WeatherModel model)
        {
            this.model = model;
            UpdateWeather();
            model.PropertyChanged += ModelPropertyChanged;
        }

        private void ModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.propertyName == nameof(model.CurrentWeather))
            {
                UpdateWeather();
            }
        }
        private void UpdateWeather()
        {
            CurrentWeather = model.CurrentWeather.ToString("");
        }
    }
}
