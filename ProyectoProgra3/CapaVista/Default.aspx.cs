using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoProgra3.CapaVista
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load (object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cboCarreras.DataSource = new Controladora.clsEstudiante().verCarrerasControladora();
                cboCarreras.DataBind();
            }
        }
    }
}