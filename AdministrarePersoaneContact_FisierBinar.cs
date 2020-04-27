using LibrarieModele;
using System;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public class AdministrarePersoaneContact_FisierBinar : IStocareData
    {
        string NumeFisier { get; set; }
        public AdministrarePersoaneContact_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddPersoana(PersoaneContact s)
        {
            throw new Exception("Optiunea AddStudent nu este implementata");
        }

        public PersoaneContact[] GetPersoane(out int nrPersoane)
        {
            throw new Exception("Optiunea GetStudenti nu este implementata");
        }
    }
}
