using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Security.Cryptography;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Crypto.Tls;

namespace Modelo
{
    class Familia
    {
        public int idFamilia { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string parentesco { get; set; }
        public string ocupacion { get; set; }

        public DataTable llenarFamilia()
        {
            MySqlConnection conexion = new MySqlConnection("server=10.120.2.123;userid=alumn517;password=Alumno2022;database=repo_517");
            MySqlCommand instruccion = new MySqlCommand();
            instruccion.Connection = conexion;

            conexion.Open();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            instruccion.CommandText = "select * from familia";
            Adapter.SelectCommand = instruccion;
            DataSet SetDatos = new DataSet();
            Adapter.Fill(SetDatos);
            DataTable Tabla = new DataTable();
            Tabla = SetDatos.Tables[0];
            conexion.Close();

            return Tabla;
        }


        public void eliminarFamilia(string pId)
        {
            MySqlConnection cnx = new MySqlConnection("server=10.120.2.123;userid=alumn517;password=Alumno2022;database=repo_517");
            MySqlCommand instruccion = new MySqlCommand();
            instruccion.Connection = cnx;
            cnx.Open();
            instruccion.CommandText = "delete from familia where idfamilia = '" + pId + "'";
            instruccion.ExecuteNonQuery();
            cnx.Close();
            //MessageBox.Show();
            
        }
        public void agregarfamilia(Familia pFlia)

        {
            string textoRecibido= pFlia.nombre + " " + pFlia.apellido + " " + pFlia.ocupacion + " " + pFlia.parentesco;
            //MessageBox.Show(textoRecibido);

            MySqlConnection cnx = new MySqlConnection("server=10.120.2.123;userid=alumn517;password=Alumno2022;database=repo_517");
            MySqlCommand instruccion = new MySqlCommand();
            instruccion.Connection = cnx;
            cnx.Open();
            instruccion.CommandText ="insert into familia(nombre, apellido, parentesco, ocupacion) values('" + pFlia.nombre + "', '" + pFlia.apellido + "', '"+pFlia.parentesco + "','" + pFlia.ocupacion + "')";

                //"delete from familia where idfamilia = '" + pId + "'";
            instruccion.ExecuteNonQuery();
            cnx.Close();
            
        }


      
        public Familia obtenerFamilia(string pIdFamilia)
        {
            MySqlConnection cnx = new MySqlConnection("server=10.120.2.123;userid=alumn517;password=Alumno2022;database=repo_517");
            //ServerName: win2016-01
            MySqlCommand instuccion = new MySqlCommand();
            instuccion.Connection = cnx;

            //tabla
            cnx.Open();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            instuccion.CommandText = "select * from familia where idfamilia = '" + pIdFamilia + "'";
            Adapter.SelectCommand = instuccion;
            DataSet setDatos = new DataSet();
            Adapter.Fill(setDatos);
            DataTable tabla = new DataTable();
            tabla = setDatos.Tables[0];
            cnx.Close();

            this.nombre = tabla.Rows[0][1].ToString();
            this.apellido = tabla.Rows[0][2].ToString();

            this.ocupacion = tabla.Rows[0][4].ToString();
            this.parentesco = tabla.Rows[0][3].ToString();

                
            return this;
        }
       public void actualizarFamilia(Familia pFlia, string idFamilia)
        {
            MySqlConnection cnx = new MySqlConnection("server=10.120.2.123; userid=alumn517;password=Alumno2022;database=repo_517");
            MySqlCommand instruccion = new MySqlCommand();
            instruccion.Connection = cnx;
            cnx.Open();
            instruccion.CommandText = "update familia set nombre ='" + pFlia.nombre + "' , apellido = '" + pFlia.apellido + "', parentesco = '" + pFlia.parentesco + "', ocupacion = '" + pFlia.ocupacion + "' where idfamilia = '" + idFamilia + "'";

            instruccion.ExecuteNonQuery();
            cnx.Close();

        }
    }
    

}
