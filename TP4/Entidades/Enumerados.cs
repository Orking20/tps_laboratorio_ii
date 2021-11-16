using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Todas las naciones existentes en el mundo de Esapada Negra
    /// </summary>
    public enum ENacion
    {
        Dormenia,
        Eride,
        Harrassia,
        Tirtie,
        Gunear,
        Najshet,
        Tribus
    }

    /// <summary>
    /// Todos los tipos de ejércitos existentes en el mundo de Esapada Negra
    /// </summary>
    public enum ETipo
    {
        Infanteria_ligera,
        Infanteria_media,
        Infanteria_media_de_asalto,
        Infanteria_pesada,
        Infanteria_mixta,
        Infanteria_de_soporte,
        Caballeria_ligera,
        Caballeria_media,
        Caballeria_pesada_de_asalto,
        Arqueria_ligera,
        Mulenevor
    }

    /// <summary>
    /// Los posibles niveles de autonomía
    /// </summary>
    public enum EAutonomia
    {
        Desconocida,
        Poca,
        Baja,
        Aceptable,
        Moderada,
        Alta,
        Casi_completa,
        Completa
    }
}