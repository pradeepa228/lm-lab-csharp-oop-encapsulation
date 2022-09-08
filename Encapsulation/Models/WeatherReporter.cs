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
                const int TEMP_CONVERSION = 32;
                const float UPPER_READING = 9.0f;
                const float LOWER_READING = 5.0f;

                double newTemp = (UPPER_READING / LOWER_READING) * _temperature + TEMP_CONVERSION;
                return $"I am in {_location} and it is {CheckCity()}. {CheckTemperature()}. The temperature in Fahrenheit is {newTemp}. ";
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

            private string CheckTemperature()
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



