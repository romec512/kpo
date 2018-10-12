using System;
using System.Collections.Generic;
using System.IO;
using AppKit;

namespace Kpo4310_asadovrs.Lib
{
    public class LoadSubstancesListSplitFileLoader : ISubstanceListLoader
    {
        public LoadSubstancesListSplitFileLoader(string FileName)
        {
            _dataFileName = FileName;
        }

        private List<Substance> _substances;
        private LoadStatus _status = LoadStatus.None;
        private readonly string _dataFileName = "";
        public List<Substance> Substances
        {
            get
            {
                return _substances;
            }
        }
        public LoadStatus Status
        {
            get
            {
                return _status;
            }
        }

        public void Execute()
        {
            _status = LoadStatus.None;
            if (_dataFileName == null)
            {
                _status = LoadStatus.FileNameIsEmpty;
                throw new Exception("Имя файла не задано");
            }

            if (!File.Exists(Path.GetFullPath(_dataFileName)))
            {
                _status = LoadStatus.FileNotExists;
                throw new Exception("Файл не существует ");
            }

            StreamReader reader = null;
            _substances = new List<Substance>();
            using (reader = new StreamReader(_dataFileName))
            {
                while (!reader.EndOfStream)
                {
                    try
                    {
                        string str = reader.ReadLine();
                        string[] array = str.Split('|');
                        Console.WriteLine(array[2]);
                        _substances.Add(new Substance()
                        {
                            name = array[0],
                            type = Convert.ToChar(array[1]),
                            lowTemperature = (float)Convert.ToDouble(array[2]),
                            highTemperature = (float)Convert.ToDouble(array[3])
                        });
                    }
                    catch (Exception ex)
                    {
                        LogUtility.ErrorLog(ex.Message);
                        _status = LoadStatus.GeneralError;
                        var alert = new NSAlert();
                        alert.InformativeText = ex.Message;
                        alert.MessageText = "Произошла ошибка";
                        alert.RunModal();
                    }
                }
                _status = LoadStatus.Success;
            }
        }

        public List<Substance> GetSubstances()
        {
            return _substances;
        }
    }
}
