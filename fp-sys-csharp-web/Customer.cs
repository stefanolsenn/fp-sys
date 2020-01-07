using Microsoft.Extensions.Logging;

namespace fp_sys_csharp_web
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Customer(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}