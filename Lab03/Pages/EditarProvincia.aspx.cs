using Lab03.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab03.Pages
{
    public partial class EditarProvincia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int idProvincia = Convert.ToInt32(Request.QueryString["id"]);
                TxtidProvincia.Text = idProvincia.ToString();

                try
                {
                    using (P5_Lab03Entities db = new P5_Lab03Entities())
                    {
                        var datosProvincia = db.spConsultarProvinciaPorId(idProvincia).FirstOrDefault();

                        if (datosProvincia != null)
                        {
                            TxtNombre.Text = datosProvincia.nombre;
                            TxtEstado.Text = datosProvincia.estado;

                        }
                    }
                }
                catch (Exception)
                {
                    Response.Redirect("~/Pages/Error.aspx");
                }

            }
        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProvincia = Convert.ToInt32(TxtidProvincia.Text.Trim());
                string nombre = TxtNombre.Text.Trim();
                string estado = TxtEstado.Text.Trim();

                //llamamos al sp de mofiicaciopn de usuario
                using (P5_Lab03Entities db = new P5_Lab03Entities())
                {
                    db.spEditarProvincia(idProvincia, nombre, estado);
                }
            }
            catch (Exception)
            {

                Response.Redirect("~/Pages/Error.aspx");
            }
            Response.Redirect("ResultadoDeEditarProvincia.aspx");
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProvincia = Convert.ToInt32(TxtidProvincia.Text.Trim());
                using (P5_Lab03Entities db = new P5_Lab03Entities())
                {
                    db.spEliminarProvincia(idProvincia);
                }
            }
            catch (Exception)
            {

                Response.Redirect("Error.aspx");
            }
            Response.Redirect("ResultadoDeEliminarProvincia.aspx");
        }
    }
}