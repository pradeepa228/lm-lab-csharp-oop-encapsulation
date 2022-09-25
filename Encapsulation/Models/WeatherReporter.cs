using System;
namespace Encapsulation.Models
{

        public class WeatherReporter
        {
            private string _location;
            private double _temperature;

            public WeatherReporter(string location, double temperature)
            {
                _location = location;
                _temperature = temperature;
            }

            public string PrintInfo()
            {
                double newTemp = (9.0f / 5.0f) * _temperature + 32;
                return $"I am in {_location} and it is {CheckCity()}. {GetTemperatureDesciption()}. The temperature in Fahrenheit is {newTemp}. ";
        }

        private string CheckCity()
            {
                if (_location == "London")
                {

                    return "🌦";

                }
                else if (_location == "California")
                {

                    return "🌅";

                }
                else if (_location == "Cape Town")
                {

                    return "🌤";

                }
                return "🔆";
            }

            private string GetTemperatureDesciption()
            {
                int UPPER_TEMPERATURE = 30;
                int LOWER_TEMPERATURE = 10;

                if (_temperature > UPPER_TEMPERATURE)
                {

                    return "It's too hot 🥵!";

                }
                else if (_temperature < LOWER_TEMPERATURE)
                {

                    return "It's too cold 🥶!";

                }
                return "Ahhh...it's just right 😊!";
            }

        }
    }



