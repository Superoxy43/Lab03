using Lab03.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab03.Pages
{
    public partial class CrearProvincia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {

            //primero vamos a capturar en variables locales los valores
            //digitados en la página. 

            string provincia = TxtProvincia.Text.Trim();
            DateTime fechaCreacion = DateTime.Now;

            //en este ejemplo el rol será opcional
            //TODO: dar funcionalidad al combo para seleccionar el rol 

            try
            {
                using (P5_Lab03Entities db = new P5_Lab03Entities())
                {
                    db.spCrearProvincia(provincia, fechaCreacion);
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/Error.aspx");
            }

            Response.Redirect("~/Pages/ExitoCrearProvincia.aspx");
        }
    }
}