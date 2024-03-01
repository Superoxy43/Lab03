using Lab03.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab03.Pages
{
    public partial class ListaProvincia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                using (P5_Lab03Entities db = new P5_Lab03Entities())
                {

                    var Lista = db.spConsultarProvincias().ToList();

                    GvListaProvincias.DataSource = Lista;
                    GvListaProvincias.DataBind(); 



                }

            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/Error.aspx");
            }

        }
    }
}