using Modelo;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;


namespace proyecto
{
    public partial class Altafamilia : Form
    {
        Familia flia=new Familia();
        string nombre = "";
        public Altafamilia(string pOrigen, string pIdFamilia)
        {
            if (pOrigen == "m")
            {

                flia.obtenerFamilia(pIdFamilia);
            }
            InitializeComponent();
        }

        private void Altafamilia_Load(object sender, EventArgs e)
        {
            txtNombre.Text = flia.nombre;
            txtApellido.Text = flia.apellido;
            txtOcupacion.Text = flia.ocupacion;
            txtParentesco.Text = flia.parentesco;
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flia.nombre = txtNombre.Text;
            flia.apellido = txtApellido.Text;
            flia.parentesco = txtParentesco.Text;
            flia.ocupacion = txtOcupacion.Text;
            flia.agregarfamilia(flia);
            this.Close();

        }

        private void textOcupacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
