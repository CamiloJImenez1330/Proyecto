using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Veterinaria.DAL;

namespace Veterinaria.UI
{
    

    public partial class wfMascota : System.Web.UI.Page
    {
        #region Variables
        Mascota mascota = new Mascota();
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
                BL.manteMascota._Instancia.Insert(mascota);
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            GetValues(2);
            BL.manteMascota._Instancia.Update(mascota);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            GetValues(0);
            BL.manteMascota._Instancia.Delete(mascota);
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
                mascota.idMascota = Convert.ToInt32(txtId.Text);
            }
            else if (flag == 1)
            {
                mascota.idMascota = Convert.ToInt32(txtId.Text);
                mascota.nombre = txtNombre.Text;
                mascota.edad = Convert.ToDouble(txtEdad.Text);
                mascota.peso = Convert.ToDouble(txtPeso.Text);
                mascota.color = txtColor.Text;
                //ddlDueno.DataSource = listDueno;
                //ddlRaza.DataSource = listRaza;
                
            }
            else if (flag == 2)
            {
                mascota.idMascota = Convert.ToInt32(txtId.Text);
                mascota.nombre = txtNombre.Text;
                mascota.edad = Convert.ToDouble(txtEdad.Text);
                mascota.peso = Convert.ToDouble(txtPeso.Text);
                mascota.color = txtColor.Text;
                //ddlDueno.DataSource = listDueno;
                //ddlRaza.DataSource = listRaza;
            }
        }
        
        public void BindData()
        {
            Session["gridview"] = BL.manteMascota._Instancia.GetAll();
            gridview.DataSource = Session["gridview"];
            gridview.DataBind();

            var listDueno = (from Dueno in BL.manteDueno._Instancia.GetAll() select Dueno.nombre);
            var listRaza = (from Raza in BL.manteRaza._Instancia.GetAll() select Raza.nombre);

            foreach (string str in listDueno)
            {
                Console.WriteLine(str);
            }

            if (BL.manteDueno._Instancia.GetAll().Count() == 0 || BL.manteRaza._Instancia.GetAll().Count() == 0)
            {
                string script = @"alert('Debe de existir por lo menos un dueño y una raza');
                        window.location.href='wfVisita.aspx';";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
        }

        #endregion
    }
}