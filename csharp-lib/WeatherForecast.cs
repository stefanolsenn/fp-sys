using System;

namespace csharp_lib
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int) (TemperatureC / 0.5556);

        public string Summary { get; set; }

        public static WeatherForecast Create(DateTime date, int temp, string sum)
        {
            return new WeatherForecast()
            {
                Date = date,
                TemperatureC = temp,
                Summary = sum
            };
        }
    }
    
    public class CustomerId
    {
        public string Value { get; }
    
        public CustomerId(string customerId)
        {
            if (customerId == null)
                throw new ArgumentNullException(nameof(customerId));
    
            if (customerId == "")
                throw new ArgumentException(
                    "Customer ID cannot be empty.",
                    nameof(customerId));
    
            var value = customerId.ToLower();
    
            if (value.Length != 10 || value.StartsWith("c"))
                throw new ArgumentException(
                    "Invalid customer ID",
                    nameof(customerId));
    
            Value = value;
        }
    }
    
    
}