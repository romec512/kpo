using System;
namespace Kpo4310_asadovrs.Lib
{
    public class SubstanceTestFactory : ISubFactory
    {
        public SubstanceTestFactory()
        {
        }

        public ISubstanceListLoader CreateLoader()
        {
            return new MockSubstanceListLoader();
        }

        public SubListSaverInterface CreateSaver()
        {
            return new SubListTestSaver();
        }
    }
}
