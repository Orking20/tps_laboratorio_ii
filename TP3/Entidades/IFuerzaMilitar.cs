using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Contiene métodos para atacar y defender usados por Ejercito y Milicia
    /// </summary>
    interface IFuerzaMilitar
    {
        string Atacar();
        string Defender();
    }
}
