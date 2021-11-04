using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Milicia : Campesino, IFuerzaMilitar
    {
        public Milicia(int id, ENacion nacion, string profesion) : base(id, nacion, profesion)
        {

        }

        public string Atacar()
        {
            return "Algunos campesinos van a las armas para atacar a algún enemigo o para empezar una guerra civíl";
        }

        public string Defender()
        {
            return "Algunos campesinos van a las armas para defenderse de algún enemigo";
        }
    }
}
