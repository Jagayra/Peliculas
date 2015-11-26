using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Peliculas.Bussines.Entity;
using Peliculas.Data;

namespace Peliculas.Bussines
{
    public class BusPelicula
    {
        public List<EntPelicula> obtener()
        {
            DataTable dt = new DatPelicula().obtener();
            List<EntPelicula> lst = new List<EntPelicula>();
            lst = obj(dt);
            return lst;
        }
        public List<EntPelicula> obtener(int id)
        {
            DataTable dt = new DatPelicula().obtener(id);
            List<EntPelicula> lst = new List<EntPelicula>();
            lst = obj(dt);
            return lst;
        }
        public List<EntPelicula> ObtenerGenero(int idGen)
        {
            DataTable dt = new DatPelicula().obtenerGenero(idGen);
            List<EntPelicula> lst = new List<EntPelicula>();
            lst = obj(dt);
            return lst;
        }
        public List<EntPelicula> ObtenerEstrenos()
        {
            DataTable dt = new DatPelicula().obtenerEstrenos();
            List<EntPelicula> lst = new List<EntPelicula>();
            lst = obj(dt);
            return lst;
        }
        private List<EntPelicula> obj(DataTable dt)
        {
            List<EntPelicula> lst = new List<EntPelicula>();
            foreach (DataRow dr in dt.Rows)
            {
                EntPelicula ent = new EntPelicula();
                ent.Id = Convert.ToInt32(dr["PELI_ID"]);
                ent.Nombre = dr["PELI_NOMB"].ToString();
                ent.AnioLanzamiento = Convert.ToDateTime(dr["PELI_ANIO_LANZ"]);
                ent.Estatus = Convert.ToBoolean(dr["PELI_ESTA"]);
                ent.Sinopsis = dr["PELI_SINO"].ToString();
                ent.Trailer = dr["PELI_TRAI"].ToString();
                ent.FotoPortada = dr["PELI_FOTO_PORT"].ToString();
                ent.FotoMini = dr["PELI_FOTO_MINI"].ToString();
                ent.Genero.Nombre = dr["GENE_NOMB"].ToString();
                ent.Clasificacion.Nombre = dr["CLAS_NOMB"].ToString();
                lst.Add(ent);
            }
            return lst;

        }
        public EntUsuario obtenerUsuario(string Correo, string Password)
        {
            DataTable dt = new DatCatalogos().obtenerUsuario(Correo, Password);
            EntUsuario ent = new EntUsuario();
            ent.Id = Convert.ToInt32(dt.Rows[0]["USUA_ID"]);
            ent.Nombre = dt.Rows[0]["USUA_NOMB"].ToString();
            ent.Correo = dt.Rows[0]["USUA_CORR"].ToString();
            ent.Password = dt.Rows[0]["USUA_PASS"].ToString();
            return ent;
        }
        public List<EntPelicula> ObtenerUltimas()
        {
            DataTable dt = new DatPelicula().ObtenerUltimas();
            List<EntPelicula> lst = new List<EntPelicula>();
            lst = obj(dt);
            return lst;
        }
        public void Actualizar(EntPelicula ent)
        {
            int filas = new DatPelicula().Actualizar(ent.Nombre, ent.AnioLanzamiento, ent.Clasificacion.Id, ent.Genero.Id, ent.Estatus, ent.Sinopsis, ent.Trailer, ent.FotoPortada, ent.FotoPortada, ent.Id);
            if (filas != 1)
            {
                throw new ApplicationException("Error al Actualizar Pelicula");
            }
        }
        public void Guardar(EntPelicula ent)
        {
            int filas = new DatPelicula().Guardar(ent.Nombre, ent.AnioLanzamiento, ent.Clasificacion.Id, ent.Genero.Id, ent.FechaAlta, ent.Estatus, ent.Sinopsis, ent.Trailer, ent.FotoPortada, ent.FotoMini);
            if (filas != 1)
            {
                throw new ApplicationException("Error al Insertar Pelicula ");
            }
        }
        public void Eliminar(int id)
        {
            int filas = new DatPelicula().Eliminar(id);

            if (filas != 1)

                throw new ApplicationException("Error al Eliminar Pelicula ");
        }
    }

}
