using Veterinaria.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Veterinaria.UI
{
    public partial class Raza : System.Web.UI.Page
    {
        #region Variables
        Raza raza = new Raza();
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
                BL.manteRaza._Instancia.Insert(raza);
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            GetValues(2);
            BL.manteRaza._Instancia.Update(raza);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            GetValues(0);
            BL.manteRaza._Instancia.Delete(raza);
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
                control.Id = Convert.ToInt32(txtId.Text);
            }
            else if (flag == 1)
            {
                control.Id = Convert.ToInt32(txtId.Text);
                control.Nombre = txtNombre.Text;
                control.Tipo = ddlTipo.SelectedIndex;
                control.CreatedBy = ddlCreatedBy.SelectedIndex;
                control.Description = txtDescripcion.Text;
                control.Fecha_Creacion = FechaCreacion.SelectedDate;
                control.Fecha_Actualizacion = UltimaActualizacion.SelectedDate;
                control.Valoracion = Convert.ToDecimal(txtValoracion.Text);
            }
            else if (flag == 2)
            {
                control.Id = Convert.ToInt32(txtId.Text);
                control.Nombre = txtNombre.Text;
                control.Tipo = ddlTipo.SelectedIndex;
                control.CreatedBy = ddlCreatedBy.SelectedIndex;
                control.Description = txtDescripcion.Text;
                control.Fecha_Creacion = FechaCreacion.SelectedDate;
                control.Fecha_Actualizacion = UltimaActualizacion.SelectedDate;
                control.Valoracion = Convert.ToDecimal(txtValoracion.Text);
            }


        }

        public void BindData()
        {
            Session["gridview"] = BL.Mantenimiento._Instancia.GetAll();
            gridview.DataSource = Session["gridview"];
            gridview.DataBind();
        }

        #endregion
    }
}