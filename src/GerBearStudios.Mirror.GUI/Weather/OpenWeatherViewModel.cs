using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerBearStudios.Mirror.GUI.Weather
{
    public class OpenWeatherViewModel : PropertyChangedBase
    {
        private OpenWeatherViewModel model;
        private string currentLocation;
        public string CurrentLocation;


        internal void Initialize(OpenWeatherViewModel model)
        {
            this.model = model;
            
        }
    }
}
