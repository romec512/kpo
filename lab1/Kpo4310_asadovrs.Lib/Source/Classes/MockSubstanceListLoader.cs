using System;
using System.Collections.Generic;

namespace Kpo4310_asadovrs.Lib
{
    public class MockSubstanceListLoader : ISubstanceListLoader
    {
        public MockSubstanceListLoader()
        {
            _substanceList = new List<Substance>();
        }

        private readonly string _dataFileName = "";
        private List<Substance> _substanceList = null;
        public List<Substance> substanceList
        {
            get { return _substanceList; }
        }
        public void Execute()
        {
            //Фигурная скобка для ограничения области видимости переменной substance
            {
                Substance substance = new Substance()
                //данная констуркция позволяет инициализировать объект при его создании
                {
                    name = "Zn",
                    type = 'M',
                    lowTemperature = (float)0.8,
                    highTemperature = (float)0.8

                };
                substanceList.Add(substance);
            }
            {
                Substance substance = new Substance()
                {
                    name = "Pb-Au",
                    type = 'П',
                    lowTemperature = (float)2.0,
                    highTemperature = (float)7.3

                };
                substanceList.Add(substance);
            }
            {
                Substance substance = new Substance()
                {
                    name = "NbC",
                    type = 'C',
                    lowTemperature = (float)10.1,
                    highTemperature = (float)10.5

                };
                substanceList.Add(substance);
            }
            //throw new Exception("Опять какая то ошибка");
        }

        public Substance SearchSubstance(string searchName){
            foreach(Substance sub in substanceList){
                if(sub.name == searchName){
                    return sub;
                }
            }
            return null;
        }

        public List<Substance> GetSubstances(){
            return _substanceList;
        }
    }
}

