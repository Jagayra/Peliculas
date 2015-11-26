using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                CargarCartelera("SELECT TOP 1000 [PELI_ID],[PELI_NOMB],[PELI_ANIO_LANZ],[PELI_CLAS_ID],[PELI_GENE_ID],[PELI_FECH_ALTA],[PELI_ESTA],[PELI_SINO],[PELI_TRAI],[PELI_FOTO_PORT],[PELI_FOTO_MINI],GENE_ID, GENE_NOMB, GENE_DESC,CLAS_ID, CLAS_NOMB, CLAS_DESC FROM [Pelicula] INNER JOIN Genero on GENE_ID=Pelicula.PELI_GENE_ID INNER JOIN Clasificacion on Clasificacion.CLAS_ID=Pelicula.PELI_CLAS_ID ");
                cargarCarrusel();

            }
        }
        catch (Exception ex)
        {
            string alerta = "alert('" + ex.Message + "')";
            ScriptManager.RegisterStartupScript(this, GetType(), "", alerta, true);
        }
    }

    private void CargarCartelera(string query)
    {
        SqlConnection con = new SqlConnection("Data Source=YAJA-PC\\JAGAYRA; Initial Catalog=Cinepolis;Trusted_Connection=True;");
        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataTable dt = new DataTable();
        da.Fill(dt);

        LiteralControl literal = new LiteralControl();
        literal.Text = "";
        foreach (DataRow dr in dt.Rows)
        {
            int id = Convert.ToInt32(dr["PELI_ID"]);
            string nombrePeli = dr["PELI_NOMB"].ToString();
            string fecha = Convert.ToDateTime(dr["PELI_ANIO_LANZ"]).ToString("yyyy");
            bool estatus = Convert.ToBoolean(dr["PELI_ESTA"]);
            string sinopsis = dr["PELI_SINO"].ToString();
            string trailer = dr["PELI_TRAI"].ToString();
            string fotoPortada = dr["PELI_FOTO_PORT"].ToString();
            string fotoMini = dr["PELI_FOTO_MINI"].ToString();
            string genero = dr["GENE_NOMB"].ToString();
            string clasificacion = dr["CLAS_NOMB"].ToString();


            literal.Text += "<div class=\"col-sm-4\">";
            literal.Text += "                <div class=\"panel panel-default\">";
            literal.Text += "                    <div class=\"panel-heading\" style=\"height: 150px; overflow: hidden; text-algin: center;\">";
            literal.Text += " <div style=\"height: 100px; overflow: hidden; text-algin: center;\">";
            literal.Text += "                        <img src=\"" + fotoPortada + "\"class=\"img-responsive\"alt=\"\" style=\"margin: auto;\"";
            literal.Text += "                           class=\"img-responsive img-rounded\" alt=\"Reto de Valientes\" />";
            literal.Text += " </div>";
            literal.Text += " <div>";
            literal.Text += nombrePeli;
            literal.Text += " </div>";
            literal.Text += "                    </div>";
            literal.Text += "                    <div class=\"panel-body\">";
            literal.Text += "                        <div class=\"row\">";
            literal.Text += "                            <div class=\"col-xs-4\">";
            literal.Text += "                                <img src=\"" + fotoMini + "\" alt=\"Reto de Valientes\"";
            literal.Text += "                                    class=\"img-responsive\" />";
            literal.Text += "                            </div>";
            literal.Text += "                            <div class=\"col-xs-8\">";
            literal.Text += "                                <span>Año:&nbsp;&nbsp;</span><label>" + fecha + "</label><br />";
            literal.Text += "                                <span>clasificacion:&nbsp;&nbsp;</span><label>" + clasificacion + "</label><br />";
            literal.Text += "                                <span>genero:&nbsp;&nbsp;</span><label>" + genero + "</label><br />";
            literal.Text += "                                <span>";
            literal.Text += "                                    <input type=\"checkbox\" value=\"estatus\" checked />";
            literal.Text += "                                </span>";
            literal.Text += "<a href=\"AltaEdicion.aspx?ID=" + id.ToString() + "\"><img src=\"img\\edit.png\" width=\"40\" /></a>";
            literal.Text += "                            </div>";
            literal.Text += "                        </div>";
            literal.Text += "                    </div>";
            literal.Text += "                    <div id=\"sinopcis\" style=\"text-align: justify;\">";
            literal.Text += "                        <textarea style=\"width:98%; text-align: justify; margin-left:4px; background-color:white;\" disabled=\"disabled\"  rows=\"5\";>";
            literal.Text += sinopsis;
            literal.Text += "                        </textarea>";
            literal.Text += "                    </div>";
            literal.Text += "                    <div id=\"Div1\" style=\"text-align: center; margin:auto\">";
            literal.Text += "                        <iframe src=\"" + trailer + "\" frameborder=\"0\" allowfullscreen style=\"border-width; margin-top:5px; width:261px;  \"></iframe>";
            literal.Text += "                    </div>";
            literal.Text += "                </div>";
            literal.Text += "            </div>";


        }

        phPeliculas.Controls.Add(literal);

    }
    public void cargarCarrusel()
    {
        SqlConnection con = new SqlConnection("Data Source=YAJA-PC\\JAGAYRA; Initial Catalog=Cinepolis;Trusted_Connection=True;");
        SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1000 [PELI_ID],[PELI_NOMB],[PELI_ANIO_LANZ],[PELI_CLAS_ID],[PELI_GENE_ID],[PELI_FECH_ALTA],[PELI_ESTA],[PELI_SINO],[PELI_TRAI],[PELI_FOTO_PORT],[PELI_FOTO_MINI],GENE_ID, GENE_NOMB, GENE_DESC,CLAS_ID, CLAS_NOMB, CLAS_DESC FROM [Pelicula] INNER JOIN Genero on GENE_ID=Pelicula.PELI_GENE_ID INNER JOIN Clasificacion on Clasificacion.CLAS_ID=Pelicula.PELI_CLAS_ID WHERE PELI_ANIO_LANZ > '01/01/2015' ", con);
        DataTable dt = new DataTable();
        da.Fill(dt);

        LiteralControl literal = new LiteralControl();
        LiteralControl literal2 = new LiteralControl();
        literal2.Text = "";
        literal.Text = "";
        int contador = 0;
        foreach (DataRow dr in dt.Rows)
        {

            string nombrePeli = dr["PELI_NOMB"].ToString();

            string fotoPortada = dr["PELI_FOTO_PORT"].ToString();



            if (contador == 0)
                literal.Text += " <li data-target=\"#carousel1\" data-slide-to=\"" + contador + "\" class=\"active\"></li>";
            else
                literal.Text += " <li data-target=\"#carousel1\" data-slide-to=\"" + contador + "\"></li>";
            if (contador == 0)
                literal2.Text += "  <div class=\"item active\">";
            else
                literal2.Text += "  <div class=\"item\">";

            literal2.Text += "    <img src=\"" + fotoPortada + "\" style=\"height: 200px\" width=\"400px\" />";
            literal2.Text += "    <span class=\"style1\"><strong>" + nombrePeli + "</strong></span>";
            literal2.Text += "    <div class=\"carousel-caption\">";
            literal2.Text += "    </div>";
            literal2.Text += "    </div>";

            contador++;


        }
        phCarrusel.Controls.Add(literal);
        phCarrusel1.Controls.Add(literal2);
    }

  
}
