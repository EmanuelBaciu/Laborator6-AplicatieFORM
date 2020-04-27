using LibrarieModele;
using System.Collections.Generic;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddPersoana(PersoaneContact s);
        PersoaneContact[] GetPersoane(out int nrPersoane);
    }
}
