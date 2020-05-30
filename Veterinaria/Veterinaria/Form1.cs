using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class frmVeterinaria : Form
    {
        public frmVeterinaria()
        {
            InitializeComponent();
            personalizarDisenio();
        }
        #region menuCodigos
        private void personalizarDisenio()
        {
            panelProductosSubMenu.Visible = false;         
            panelSubMenuImportes.Visible = false;
            panelSubMenuVentas.Visible = false;
        }
        private void ocultarSubMenu()
        {
            if (panelProductosSubMenu.Visible == true)
                panelProductosSubMenu.Visible = false;
            if (panelSubMenuImportes.Visible == true)
                panelSubMenuImportes.Visible = false;

            if (panelSubMenuVentas.Visible == true)
                panelSubMenuVentas.Visible = false;
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #endregion
        #region Botones
        private void button3_Click(object sender, EventArgs e)
        {
            ///CODIGO
            abrirFormHijo(new frmCargarProducto(), panelFormularioHijo);
            ocultarSubMenu();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmProducto(), panelFormularioHijo);
            ocultarSubMenu();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelProductosSubMenu);
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            ///CODIGO
            ocultarSubMenu();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new FrmClientes(), panelFormularioHijo);
         
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ///CODIGO
            ocultarSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ///CODIGO
            ocultarSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ///CODIGO
            ocultarSubMenu();
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmMascotas(), panelFormularioHijo);
            //mostrarSubMenu(panelSubMenuMascotas);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ///CODIGO
            ocultarSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ///CODIGO
            ocultarSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ///CODIGO
            ocultarSubMenu();
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmConsultas(), panelFormularioHijo);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ///CODIGO
            ocultarSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ///CODIGO
            ocultarSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ///CODIGO
            ocultarSubMenu();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuVentas);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ///CODIGO
            ocultarSubMenu();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ///CODIGO
            ocultarSubMenu();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ///CODIGO
            ocultarSubMenu();
        }

        private void btnImportes_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmAdministracion(), panelFormularioHijo);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ///CODIGO
            ocultarSubMenu();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ///CODIGO
            ocultarSubMenu();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ///CODIGO
            ocultarSubMenu();
        }


        #endregion

        private Form activeForm = null;
        public void abrirFormHijo(Form formHijo, Panel panel)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panel.Controls.Add(formHijo);
            panel.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
        public void panelFormularioHijo_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
