using System;
namespace Kpo4310_asadovrs.Lib
{
    public interface SubListSaverInterface
    {
        void Execute();
        SaveStatus SaveStatus { get; }
        Substance Substance { get; set; }
    }
}
