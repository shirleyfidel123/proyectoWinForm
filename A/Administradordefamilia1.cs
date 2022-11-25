using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Modelo;
using proyecto;

namespace A
{
    public partial class Form1 : Form
    {

        Familia familia1 = new Familia();

        public Form1()
        {
            InitializeComponent();
        }

        private void btCompletar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvFamilia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvFamilia.DataSource = familia1.llenarFamilia();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Altafamilia altafamilia = new Altafamilia("a", "");
            altafamilia.Text = "alta de familia ";
            altafamilia.ShowDialog();
            dgvFamilia.DataSource = familia1.llenarFamilia();
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idFamilia = dgvFamilia.SelectedCells[0].Value.ToString();
            familia1.eliminarFamilia(idFamilia);

            dgvFamilia.DataSource = familia1.llenarFamilia();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string idfamilia = dgvFamilia[0, dgvFamilia.CurrentRow.Index].Value.ToString();

            Altafamilia modificarFamilia = new Altafamilia("m", idfamilia);
            modificarFamilia.Text = "modificar familia";
            modificarFamilia.ShowDialog();


            dgvFamilia.DataSource = familia1.llenarFamilia();
        }




}  
} 
        






            

