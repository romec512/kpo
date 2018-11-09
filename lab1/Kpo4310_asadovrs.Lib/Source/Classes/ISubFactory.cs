using System;
namespace Kpo4310_asadovrs.Lib
{
    public interface ISubFactory
    {
        SubListSaverInterface CreateSaver();
        ISubstanceListLoader CreateLoader();
    }
}
