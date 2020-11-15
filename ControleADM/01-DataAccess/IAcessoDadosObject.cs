using System;
using System.Collections.Generic;

namespace ControleADM.DataAccess
{
    public interface IAcessoDadosObject<T> where T : new()
    {
        long consulte(T obj);
        bool insira(T obj);
        bool altere(T obj);
        bool exclua(T obj);
    }
}