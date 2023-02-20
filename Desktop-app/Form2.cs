using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc; //librería ODBC

namespace Proyecto1
{
    public partial class Form2 : Form
    {
        OdbcConnection conecta = new OdbcConnection("Driver={Sql Server};Server=AldahirsMacbook;Database=proyecto1;");
        OdbcCommand comando;

        public Form2()
        {
            InitializeComponent();
        }

        private void propuestaBT_Click(object sender, EventArgs e)
        {
            if (LoginInfo.usuario != null) //verifica que ya se haya registrado
            {
                Form formulario = new Form3();
                formulario.Show();
            }
            else
            {
                display.Text = "Error, primero debe registrarse";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void registroBT_Click(object sender, EventArgs e)
        {
            string nombre = nombreTXT.Text;
            string rfc = rfcTXT.Text;
            string mail = emailTXT.Text;
            string tel = telTXT.Text;

            string registrosql = "insert into clientes values('"+nombre+"','"+rfc+"','"+mail+"','"+tel+"')";
            string query = "select * from clientes where Correo_Clien='" + mail + "' and RFC_clien='" + rfc + "'";

            try
            {
                aux_function(registrosql);
                asignaNum_Client(query);
                display.Text = "Registro exitoso!, ahora puede capturar propuestas";
                LoginInfo.usuario = mail;
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void aux_function(String s)
        {
            conecta.Open();
            comando = new OdbcCommand(s, conecta);
            comando.ExecuteNonQuery();
        }

        private void asignaNum_Client(string s)
        {
            comando = new OdbcCommand(s, conecta);
            object o = comando.ExecuteScalar();

            if (o != null)
            {
                LoginInfo.num_Clien = int.Parse(o.ToString());
            }

        }
    }
}
