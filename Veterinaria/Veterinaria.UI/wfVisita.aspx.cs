using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Veterinaria.DAL;

namespace Veterinaria.UI
{
    public partial class wfVisita : System.Web.UI.Page
    {
        #region Variables
        Visita visita = new Visita();
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
                BL.manteVisita._Instancia.Insert(visita);
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            GetValues(2);
            BL.manteVisita._Instancia.Update(visita);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            GetValues(0);
            BL.manteVisita._Instancia.Delete(visita);
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
                visita.idVisita = Convert.ToInt32(txtId.Text);
            }
            else if (flag == 1)
            {
                visita.idVisita = Convert.ToInt32(txtId.Text);
                visita.fechaVisita = ddlFecha.SelectedDate;
            }
            else if (flag == 2)
            {
                visita.idVisita = Convert.ToInt32(txtId.Text);
                visita.fechaVisita = ddlFecha.SelectedDate;
            }


        }

        public void BindData()
        {
            Session["gridview"] = BL.manteVisita._Instancia.GetAll();
            gridview.DataSource = Session["gridview"];
            gridview.DataBind();
        }

        #endregion


    }
}