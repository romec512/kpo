using System;
namespace Kpo4310_asadovrs.Lib
{
    public class SubstanceFileFactory : ISubFactory
    {
        public SubstanceFileFactory()
        {
        }

        public ISubstanceListLoader CreateLoader()
        {
            return new LoadSubstancesListSplitFileLoader(Kpo4310_asadovrs.AppGlobalSettings.DataFileName);
        }

        public SubListSaverInterface CreateSaver()
        {
            return new SubListFileSaver();
        }
    }
}
