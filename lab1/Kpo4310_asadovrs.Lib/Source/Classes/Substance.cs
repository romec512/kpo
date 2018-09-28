using System;
namespace Kpo4310_asadovrs.Lib
{
    public class Substance
    {
        public string name {get; set;}
        public char type {get; set; }
        public float lowTemperature {get; set;}
        public float highTemperature {get; set;}

        public Substance()
        {
            name = "";
            type = 'A';
            lowTemperature = 0;
            highTemperature = 0;
        }
    }
}
