using Microsoft.AspNetCore.Mvc;
using ConvertTemperature;
using ConvertCooking;
using System.Text;
using System;

namespace Remeasure.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RemeasureRecipe(string recipe)
        {
            recipe = ConvertAllCookingMeasurements(recipe);
            recipe = ConvertTemperatures(recipe);

            return Json(recipe);
        }

        private string ConvertTemperatures(string recipe)
        {
            double temperature = findTemperature(recipe);
            double convertedTemperature = convertTemperature(temperature);

            StringBuilder recipeBuilder = new StringBuilder(recipe);

            recipeBuilder.Replace(temperature.ToString(), convertedTemperature.ToString());

            return recipeBuilder.ToString();
        }

        private static string ConvertAllCookingMeasurements(string recipe)
        {
            double[] measurements = findMeasurements(recipe);
            double[] convertedMeasurements = convertCookingMeasurements(measurements);

            StringBuilder recipeBuilder = new StringBuilder(recipe);

            for (int i = 0; i < measurements.Length; i++)
            {
                recipeBuilder.Replace(measurements[i].ToString(), convertedMeasurements[i].ToString());
            }

            return recipeBuilder.ToString();
        }

        private static double[] findMeasurements(string recipe)
        {
            //regex for filtering out all the supported measurement types
            throw new NotImplementedException();
        }

        private double findTemperature(string recipe)
        {
            //regex for filtering fahrenheit
            throw new NotImplementedException();
        }

        private static double[] convertCookingMeasurements(double[] measurements)
        {
            CookingUnitSoapClient.EndpointConfiguration endpoint = new CookingUnitSoapClient.EndpointConfiguration();  //does not work
            CookingUnitSoapClient client = new CookingUnitSoapClient(endpoint);

            dynamic result = null;

            foreach (var measurement in measurements)
            {
                result = client.ChangeCookingUnitAsync(measurement, Cookings.cupUS, Cookings.deciliter).Result;
            }

            return result;
        }

        private static double convertTemperature(int temperature)
        {
            ConvertTemperatureSoapClient.EndpointConfiguration endpoint = new ConvertTemperatureSoapClient.EndpointConfiguration();  //does not work
            ConvertTemperatureSoapClient client = new ConvertTemperatureSoapClient(endpoint);

            dynamic result = client.ConvertTempAsync(temperature, TemperatureUnit.degreeFahrenheit, TemperatureUnit.degreeCelsius).Result;

            return result;
        }
    }
}
