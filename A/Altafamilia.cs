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
        public Altafamilia()
        {
            InitializeComponent();
        }

        private void Altafamilia_Load(object sender, EventArgs e)
        {
            
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flia.nombre = txtNombre.ToString();
            flia.apellido = txtApellido.ToString();
            flia.parentesco = txtParentesco.ToString();
            flia.ocupacion = txtOcupacion.ToString();
            flia.agregarfamilia(flia);

        }

        private void textOcupacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
