using System;
using System.Collections.Generic;

namespace Kpo4310_asadovrs.Lib
{
    public interface ISubstanceListLoader
    {
         void Execute();
         List<Substance> GetSubstances();
    }
}
