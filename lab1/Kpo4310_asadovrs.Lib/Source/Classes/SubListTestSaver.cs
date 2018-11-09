using System;
namespace Kpo4310_asadovrs.Lib
{
    public class SubListTestSaver : SubListSaverInterface
    {
        private SaveStatus _status;

        public SubListTestSaver()
        {
            _status = SaveStatus.None;
        }

        public void Execute(){
            _status = SaveStatus.Success;
        }

        public SaveStatus SaveStatus
        {
            get
            {
                return _status;
            }
        }

        public Substance Substance { get; set; }
    }
}
