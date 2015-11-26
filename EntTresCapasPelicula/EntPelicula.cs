using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Peliculas.Bussines.Entity
{
    public class EntPelicula
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime AnioLanzamiento { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Sinopsis { get; set; }
        public bool Estatus { get; set; }
        public string Trailer { get; set; }
        public string FotoPortada { get; set; }
        public string FotoMini { get; set; }
        private EntGenero genero;

        public EntGenero Genero
        {
            get
            {
                if (genero == null)
                    genero = new EntGenero();
                return genero;
            }
            set {
                if (genero == null)
                    genero = new EntGenero();
                genero = value; }
        }
        private EntClasi clasificacion;

        public EntClasi Clasificacion
        {
            get {
                if (clasificacion == null)
                    clasificacion = new EntClasi();
                return clasificacion; }

            set {
                if (clasificacion == null)
                    clasificacion = new EntClasi();                  
                clasificacion = value; }
        }



    }

}


