using Encapsulation.Models;
using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using System;

namespace Encapsulation.Tests;

public class Tests
{
    private WeatherReporter WeatherReporter;
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void check_Weather_Details_for_London()
    {
        WeatherReporter myWeatherReporter = new("London", 30);
        myWeatherReporter.PrintInfo().Should().Be("I am in London and it is 🌦. Ahhh...it's just right 😊!. The temperature in Fahrenheit is 85.99999856948853. ");
    }

    [Test]
    public void check_Weather_Details_for_California()
    {
        WeatherReporter myWeatherReporter = new("California", 5);
        myWeatherReporter.PrintInfo().Should().Be("I am in California and it is 🌅. It's too cold 🥶!. The temperature in Fahrenheit is 40.99999976158142. ");
    }

    [Test]
    public void check_Weather_Details_for_Cape_Town()
    {
        WeatherReporter myWeatherReporter = new("Cape Town", 40);
        myWeatherReporter.PrintInfo().Should().Be("I am in Cape Town and it is 🌤. It's too hot \U0001f975!. The temperature in Fahrenheit is 103.99999809265137. ");
    }

}
