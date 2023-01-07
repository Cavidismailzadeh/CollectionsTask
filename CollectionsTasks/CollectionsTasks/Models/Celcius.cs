using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsTasks.Models
{
    public class Celcius
    {
        public double Degree { get; set; }
        public Celcius(double degree)
        {
            Degree = degree;
        }
     
        public static implicit operator Kelvin(Celcius celcius)
        {
            return new Kelvin (celcius.Degree + 273);
        }


    }
}
