using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Peliculas.Bussines.Entity;
using System.Data;
using Peliculas.Data;

namespace Peliculas.Bussines
{
   public class BusCatalogo
    {
        public List<EntGenero> obtenerGenero()
        {
            DataTable dt = new DatCatalogos().obtenerGeneroCompleto();
            List<EntGenero> lst = new List<EntGenero>();
            foreach (DataRow dr in dt.Rows)
            {
                EntGenero ent = new EntGenero();
                ent.Id = Convert.ToInt32(dr["GENE_ID"]);
                ent.Nombre = dr["GENE_NOMB"].ToString();
                ent.Descripcion = dr["GENE_DESC"].ToString();
                lst.Add(ent);
            }
            return lst;
        }
        public List<EntClasi> obtenerClasificacion()
        {
            DataTable dt = new DatCatalogos().obtenerClasificacion();
            List<EntClasi> lst = new List<EntClasi>();
            foreach (DataRow dr in dt.Rows)
            {
                EntClasi ent = new EntClasi();
                ent.Id = Convert.ToInt32(dr["CLAS_ID"]);
                ent.Nombre = dr["CLAS_NOMB"].ToString();
                ent.Descripcion = dr["CLAS_DESC"].ToString();
                lst.Add(ent);
            }
            return lst;
        }
    }
}
