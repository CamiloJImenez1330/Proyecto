using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Veterinaria.DAL;


#region Events
namespace Veterinaria.UI
{

  
    public partial class wfMascota : System.Web.UI.Page
    {

        #region Variables
        Mascota mascota = new Mascota();
        Dictionary<int, string> listaduenos;
        Dictionary<int, string> listaraza;
        #endregion

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
                BindData();
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
                // mascota.idDueno = ddlDueno.SelectedIndex;         
            
                mascota.idDueno = listaduenos.FirstOrDefault(x => x.Value == ddlDueno.SelectedValue.ToString()).Key;
                mascota.idRaza = listaraza.FirstOrDefault(x => x.Value == ddlRaza.SelectedValue.ToString()).Key;
               // mascota.idRaza = ddlRaza.SelectedIndex;
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
                // mascota.idDueno = ddlDueno.SelectedIndex;
                mascota.idDueno = listaduenos.FirstOrDefault(x => x.Value == ddlDueno.Text).Key;
                mascota.idRaza = listaraza.FirstOrDefault(x => x.Value == ddlRaza.SelectedValue.ToString()).Key;
                //  mascota.idRaza = ddlRaza.SelectedIndex;
                //ddlDueno.DataSource = listDueno;
                //ddlRaza.DataSource = listRaza;
            }
        }
        
        public void BindData()
        {
            Session["gridview"] = BL.manteMascota._Instancia.GetAll();
            gridview.DataSource = Session["gridview"];
            gridview.DataBind();
            
            if (BL.manteDueno._Instancia.GetAll().Count() == 0 || BL.manteRaza._Instancia.GetAll().Count() == 0)
            {
                string script = @"alert('Debe de existir por lo menos un dueño y una raza');
                        window.location.href='wfVisita.aspx';";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }



            //var listNombre = (from Dueno in BL.manteDueno._Instancia.GetAll() select Dueno.nombre, apellido);
            //var listApellido = (from Dueno in BL.manteDueno._Instancia.GetAll() select Dueno.apellido);
         //   var query1 = (from a in BL.manteDueno._Instancia.GetAll().AsEnumerable() select new {a.nombre, a.apellido, a.idDueno}).ToList();
            var query1 = (from a in BL.manteDueno._Instancia.GetAll().AsEnumerable() select new {a.idDueno,a.nombre }).ToList();
            //ListItem nombre = null;
            listaduenos = new Dictionary<int, string>();

            foreach (var b in query1 )
            {
                //  List<String> lista;
                //lista= new List<String>(b.nombre+" "+b.apellido);
                // listaduenos = new Dictionary<int, string>(b.idDueno, b.nombre.ToString() + " " + b.apellido.ToString());
               //  listaduenos = new Dictionary<int, string>(b.idDueno, b.nombre.ToString());
                listaduenos.Add(b.idDueno, b.nombre.ToString());
                //ddlDueno.Items.Add(listaduenos);
            }

            ddlDueno.DataSource = listaduenos.Values.ToList();
            ddlDueno.DataBind();
            //var listRaza = (from Raza in BL.manteRaza._Instancia.GetAll() select Raza.nombre);
            var query2 = (from a in BL.manteRaza._Instancia.GetAll().AsEnumerable() select new { a.nombre, a.idRaza }).ToList();
            listaraza = new Dictionary<int, string>();
            foreach (var b in query2)
            {
                //  List<String> lista;
                //lista= new List<String>(b.nombre+" "+b.apellido);
                // raza = new ListItem(b.nombre.ToString(), b.idRaza.ToString());
                //ddlRaza.Items.Add(raza);
                listaraza.Add(b.idRaza, b.nombre.ToString());
            }
            ddlRaza.DataSource = listaraza.Values.ToList();
            ddlRaza.DataBind();
        }

        #endregion
    }
}