using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Veterinaria.DAL;

namespace Veterinaria.UI
{
    public partial class wfExpediente : System.Web.UI.Page
    {
        #region Variables
        Expediente expediente = new Expediente();
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

        public void BindData()
        {
            Session["gridview"] = BL.manteExpendiente._Instancia.GetAll();
            gridview.DataSource = Session["gridview"];
            gridview.DataBind();
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues(1);
                BL.manteExpendiente._Instancia.Insert(expediente);
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            GetValues(2);
            BL.manteExpendiente._Instancia.Update(expediente);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            GetValues(0);
            BL.manteExpendiente._Instancia.Delete(expediente);
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
                expediente.idExpendiente = Convert.ToInt32(txtIdEx.Text);
            }
            else if (flag == 1)
            {
                expediente.idExpendiente = Convert.ToInt32(txtIdEx.Text);
                expediente.idMascota = Convert.ToInt32(txtIdEx.Text);
                expediente.idVisita = Convert.ToInt32(txtIdEx.Text);
                expediente.fechaIngreso = ddlFecha.SelectedDate;
            }
            else if (flag == 2)
            {
                expediente.idExpendiente = Convert.ToInt32(txtIdEx.Text);
                expediente.idMascota = Convert.ToInt32(txtIdEx.Text);
                expediente.idVisita = Convert.ToInt32(txtIdEx.Text);
                expediente.fechaIngreso = ddlFecha.SelectedDate;


            }


            #endregion
        }
    }
}