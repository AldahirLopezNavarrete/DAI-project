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
    public partial class Form3 : Form
    {
        OdbcConnection conecta = new OdbcConnection("Driver={Sql Server};Server=AldahirsMacbook;Database=proyecto1;");
        OdbcDataAdapter adaptadat;

        DataSet datxset;
        OdbcCommand comando;
        int idRenglon = 0;

        public Form3()
        {
            InitializeComponent();
            try
            {
                conecta.Open(); // abre la base de datos con el objeto conecta
                datxset = new DataSet();
                adaptadat = new OdbcDataAdapter("select * from Propuestas where num_Clien="+LoginInfo.num_Clien, conecta);
                adaptadat.Fill(datxset);
                dataGridView1.DataSource = datxset.Tables[0];
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Propuestas' Puede moverla o quitarla según sea necesario.
            this.propuestasTableAdapter.Fill(this.dataSet1.Propuestas);
        }

        private void capturarBT_Click(object sender, EventArgs e)
        {
            string prop = propuestaTXT.Text;

            string agregasql = "insert into Propuestas values('"+prop+"',"+LoginInfo.num_Clien+")";
            try
            {
                aux_function(agregasql);
                propuestaTXT.Text = "Propuesta agregada con éxito ";
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void actualizarBT_Click(object sender, EventArgs e)
        {
            string prop = propuestaTXT.Text;

            string actualizasql = "update propuestas set Propuesta='"+prop+"' where num_Clien="+LoginInfo.num_Clien;
            try
            {
                aux_function(actualizasql);
                propuestaTXT.Text = "Propuesta actualizada con éxito ";
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void eliminarBT_Click(object sender, EventArgs e)
        {
            int numProp = int.Parse(numeroPropTXT.Text);

            string eliminasql = "delete from Propuestas where num_Propuesta=" + numProp;
            try
            {
                aux_function(eliminasql);
                propuestaTXT.Text = "Propuesta eliminada con éxito ";
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void aux_function(String s)
        {
            comando = new OdbcCommand(s, conecta);
            comando.ExecuteNonQuery();
            datxset = new DataSet();
            adaptadat = new OdbcDataAdapter("select * from Propuestas where num_Clien="+LoginInfo.num_Clien, conecta);
            adaptadat.Fill(datxset);
            dataGridView1.DataSource = datxset.Tables[0];

            Form3_Load(null, null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                int i = e.RowIndex;
                if (i < 0) return;
                idRenglon = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                propuestaTXT.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
