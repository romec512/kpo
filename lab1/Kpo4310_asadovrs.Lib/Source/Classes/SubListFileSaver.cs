using System;
using System.Collections.Generic;
using System.IO;

namespace Kpo4310_asadovrs.Lib
{
    public class SubListFileSaver : SubListSaverInterface
    {
        private SaveStatus _status;
        public SaveStatus SaveStatus { get { return _status; } }
        private Substance _substance;
        public Substance Substance { get  { return _substance; } set { _substance = value; } }
        private string _filename;
        public SubListFileSaver()
        {
            _filename = Kpo4310_asadovrs.AppGlobalSettings.DataFileName;
        }

        public void Execute(){
            if (_filename == null)
            {
                _status = SaveStatus.EmptyFileName;
                throw new Exception("Имя файла не задано");
            }

            if (!File.Exists(Path.GetFullPath(_filename)))
            {
                _status = SaveStatus.FileNotExists;
                throw new Exception("Файл не существует ");
            }
            using (StreamWriter sw = new StreamWriter(_filename, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(_substance.name + '|' + _substance.type + '|' + _substance.lowTemperature + '|' + _substance.highTemperature);
                sw.Close();
                _status = SaveStatus.Success;
            }
        }
    }
}
