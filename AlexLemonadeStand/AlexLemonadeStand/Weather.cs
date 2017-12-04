using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexLemonadeStand
{
    class Weather
    {
        private List<string> weatherConditions;
        private int amountOfWeatherConditions;
        private int possiblyAdjustRainChance;
        private int adjustRainChance;
        private int guaranteedRain;
        private int maxTemperature;
        private int minTemperature;
        private string cloudiness;
        private bool isRaining;
        private double temperature;
        private Random randomNumber;
        private Conditions todaysWeather;
        private List<Conditions> forecast;
        private int lengthOfForecast;
        public Weather()
        {

        }
        public string DetermineCloudCover()
        {

        }
        public int ReduceChanceOfRain(int)
        {

        }
        public bool IsRaining(string)
        {

        }
        public double DetermineTemperature(bool)
        {

        }
        public List<Conditions> CreateForecast()
        {

        }
        public List<Conditions> GetNextDaysForecast(List<Conditions>)
        {

        }
    }
}
