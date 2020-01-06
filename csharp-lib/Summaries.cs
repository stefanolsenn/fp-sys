using System.Collections.Generic;

namespace csharp_lib
{
    public class Summaries
    {
        public static List<string> Get()
        {
            return new List<string>()
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };
        }

        public static string GetAt(int idx)
        {
            return Get()[idx];
        }

        public static int Count()
        {
            return Get().Count;
        }
    }
}