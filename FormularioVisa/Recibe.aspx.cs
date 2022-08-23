using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace FormularioVisa
{
    public partial class Recibe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Nombre: "+ Request["first-name"] + "<br>" + "Apellido: " + Request["last-name"] + "<br>" + "Sexo: " + Request["sex"] + "<br>" + "Fecha de Nacimiento: " + Request["birth-date"] + "<br>" + "Dirección: " + Request["user-address"] + "<br>" + "Sueldo: " + Request["user-salary"] + "<br>" + "Empleador: " + Request["user-employer"] + "<br>" + "Fecha de Ingreso: " + Request["admission-date"] + "<br>" + "Cantidad de Hijos: " + Request["number-children"] + "<br>" + "Cantidad de Padres: " + Request["number-parents"]);
        }
    }
}