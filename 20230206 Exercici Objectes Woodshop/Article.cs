using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230206_Exercici_Objectes_Woodshop
{
    enum Articles
    {
    taula,
    cadira,
    armari,
    estanteria,
    llit,
    capçal,
    mobleInfantil,
    mobleMenjador

    }
    internal class Article : Producte
    {
        Articles tipus_Article;
        public Articles Tipus_Article { get  => tipus_Article; set => tipus_Article = value; }
    }
}
