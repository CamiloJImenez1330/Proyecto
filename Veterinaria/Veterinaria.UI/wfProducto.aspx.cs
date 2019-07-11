using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Veterinaria.DAL;

namespace Veterinaria.UI
{
    public partial class wfProducto : System.Web.UI.Page
    {
        #region Variables
        Producto producto = new Producto();
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
                BL.manteProducto._Instancia.Insert(producto);
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            GetValues(2);
            BL.manteProducto._Instancia.Update(producto);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            GetValues(0);
            BL.manteProducto._Instancia.Delete(producto);
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
                producto.idProducto = Convert.ToInt32(txtId.Text);
            }
            else if (flag == 1)
            {
                producto.idProducto = Convert.ToInt32(txtId.Text);
                producto.nombre = txtNombre.Text;
                producto.detalle = txtDetalle.Text;
                producto.cantidad = Convert.ToInt32(txtCantidad.Text);
            }
            else if (flag == 2)
            {
                producto.idProducto = Convert.ToInt32(txtId.Text);
                producto.nombre = txtNombre.Text;
                producto.detalle = txtDetalle.Text;
                producto.cantidad = Convert.ToInt32(txtCantidad.Text);
            }


        }

        public void BindData()
        {
            Session["gridview"] = BL.manteProducto._Instancia.GetAll();
            gridview.DataSource = Session["gridview"];
            gridview.DataBind();
        }

        #endregion
    }

}