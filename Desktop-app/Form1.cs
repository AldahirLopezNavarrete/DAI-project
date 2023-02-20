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
    public partial class Form1 : Form
    {
        OdbcConnection conecta = new OdbcConnection("Driver={Sql Server};Server=AldahirsMacbook;Database=proyecto1;");
        OdbcCommand comando;


        public Form1()
        {
            InitializeComponent();  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iniciarBT_Click(object sender, EventArgs e)
        {
            if (usuarioTXT.Text == "" || passwordTXT.Text == "")
            {
                display.Text = "Error, ingrese su usuario y contraseña";
            }
            else
            {
                string usuario = usuarioTXT.Text.TrimEnd();
                string psw = passwordTXT.Text.TrimEnd();
                string query = "select * from clientes where Correo_Clien='" + usuario + "' and RFC_clien='" + psw + "'";

                conecta.Open();
                comando = new OdbcCommand(query,conecta);
                object o = comando.ExecuteScalar();

                if (o != null)
                {
                    LoginInfo.usuario = usuario;
                    LoginInfo.num_Clien = int.Parse(o.ToString());
                    Form formulario = new Form3();
                    formulario.Show();  
                }
                else
                {
                    display.Text = "Usuario o contraseña incorrectos";
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
        }
    }

    //clase estática para guardar objetos de sesión
    public static class LoginInfo
    {
        public static string usuario;
        public static int num_Clien;
    }
}
