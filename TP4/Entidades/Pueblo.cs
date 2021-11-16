using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Pueblo<T>
    {
        private static int idEstatico;
        private int id;
        private T nacion;

        /// <summary>
        /// Constructor vacío para generar archivos xml
        /// </summary>
        public Pueblo()
        {

        }

        /// <summary>
        /// Inicializa los datos de un ejército
        /// </summary>
        /// <param name="idEstatico">ID de Pueblo</param>
        /// <param name="nacion">Nación de Pueblo</param>
        public Pueblo(int idEstatico, T nacion)
        {
            this.id = idEstatico;
            this.Nacion = nacion;
        }

        /// <summary>
        /// Obtiene o establece el ID estático de Pueblo
        /// </summary>
        public static int IdEstatico
        {
            get
            {
                return idEstatico;
            }
            set
            {
                idEstatico = value;
            }
        }

        /// <summary>
        /// Obtiene o establece el ID de Pueblo
        /// </summary>
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        /// <summary>
        /// Obtiene o establece la nación de Pueblo
        /// </summary>
        public T Nacion
        {
            get
            {
                return this.nacion;
            }
            set
            {
                if (Validar.Nombre(value.ToString()))
                {
                    this.nacion = value;
                }
            }
        }
    }
}
