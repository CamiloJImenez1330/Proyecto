using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Veterinaria.DAL;

namespace Veterinaria.UI
{
    public partial class wfDueno : System.Web.UI.Page
    {
        #region Variables
        Dueno dueno = new Dueno();
        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
            else
            {

            }
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues(1);
                BL.manteDueno._Instancia.Insert(dueno);
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            GetValues(2);
            BL.manteDueno._Instancia.Update(dueno);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            GetValues(0);
            BL.manteDueno._Instancia.Delete(dueno);
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            BindData();
        }

        #endregion

        #region Methods

        public void GetValues(int flag)
        {
            // Delete 
            if (flag == 0)
            {
                dueno.idDueno = Convert.ToInt32(txtId.Text);
            }
            else if (flag == 1)
            {
                dueno.idDueno = Convert.ToInt32(txtId.Text);
                dueno.nombre = txtNombre.Text;
                dueno.apellido = txtApellido.Text;
                dueno.telefono = txtTelefono.Text;
                dueno.correo = txtCorreo.Text;
            }
            else if (flag == 2)
            {
                dueno.idDueno = Convert.ToInt32(txtId.Text);
                dueno.nombre = txtNombre.Text;
                dueno.apellido = txtApellido.Text;
                dueno.telefono = txtTelefono.Text;
                dueno.correo = txtCorreo.Text;
            }


        }

        public void BindData()
        {
            Session["gridview"] = BL.manteDueno._Instancia.GetAll();
            gridview.DataSource = Session["gridview"];
            gridview.DataBind();
        }

        #endregion
    }
}