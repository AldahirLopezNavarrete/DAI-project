
namespace Proyecto1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numPropuestaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propuestaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numClienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propuestasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Proyecto1.DataSet1();
            this.propuestasTableAdapter = new Proyecto1.DataSet1TableAdapters.PropuestasTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.propuestaTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.capturarBT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eliminarBT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numeroPropTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.actualizarBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propuestasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numPropuestaDataGridViewTextBoxColumn,
            this.propuestaDataGridViewTextBoxColumn,
            this.numClienDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.propuestasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 598);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1276, 407);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numPropuestaDataGridViewTextBoxColumn
            // 
            this.numPropuestaDataGridViewTextBoxColumn.DataPropertyName = "num_Propuesta";
            this.numPropuestaDataGridViewTextBoxColumn.HeaderText = "num_Propuesta";
            this.numPropuestaDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.numPropuestaDataGridViewTextBoxColumn.Name = "numPropuestaDataGridViewTextBoxColumn";
            this.numPropuestaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numPropuestaDataGridViewTextBoxColumn.Width = 200;
            // 
            // propuestaDataGridViewTextBoxColumn
            // 
            this.propuestaDataGridViewTextBoxColumn.DataPropertyName = "Propuesta";
            this.propuestaDataGridViewTextBoxColumn.HeaderText = "Propuesta";
            this.propuestaDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.propuestaDataGridViewTextBoxColumn.Name = "propuestaDataGridViewTextBoxColumn";
            this.propuestaDataGridViewTextBoxColumn.Width = 200;
            // 
            // numClienDataGridViewTextBoxColumn
            // 
            this.numClienDataGridViewTextBoxColumn.DataPropertyName = "num_Clien";
            this.numClienDataGridViewTextBoxColumn.HeaderText = "num_Clien";
            this.numClienDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.numClienDataGridViewTextBoxColumn.Name = "numClienDataGridViewTextBoxColumn";
            this.numClienDataGridViewTextBoxColumn.Width = 200;
            // 
            // propuestasBindingSource
            // 
            this.propuestasBindingSource.DataMember = "Propuestas";
            this.propuestasBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propuestasTableAdapter
            // 
            this.propuestasTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Capturar nueva propuesta:";
            // 
            // propuestaTXT
            // 
            this.propuestaTXT.Location = new System.Drawing.Point(43, 86);
            this.propuestaTXT.Multiline = true;
            this.propuestaTXT.Name = "propuestaTXT";
            this.propuestaTXT.Size = new System.Drawing.Size(806, 329);
            this.propuestaTXT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(585, 539);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sus propuestas:";
            // 
            // capturarBT
            // 
            this.capturarBT.Location = new System.Drawing.Point(274, 446);
            this.capturarBT.Name = "capturarBT";
            this.capturarBT.Size = new System.Drawing.Size(153, 61);
            this.capturarBT.TabIndex = 4;
            this.capturarBT.Text = "Capturar";
            this.capturarBT.UseVisualStyleBackColor = true;
            this.capturarBT.Click += new System.EventHandler(this.capturarBT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.eliminarBT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numeroPropTXT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(919, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 463);
            this.panel1.TabIndex = 9;
            // 
            // eliminarBT
            // 
            this.eliminarBT.Location = new System.Drawing.Point(120, 320);
            this.eliminarBT.Name = "eliminarBT";
            this.eliminarBT.Size = new System.Drawing.Size(155, 65);
            this.eliminarBT.TabIndex = 12;
            this.eliminarBT.Text = "Eliminar";
            this.eliminarBT.UseVisualStyleBackColor = true;
            this.eliminarBT.Click += new System.EventHandler(this.eliminarBT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 100);
            this.label4.TabIndex = 11;
            this.label4.Text = "Porfavor, digite el \r\nnúmero de propuesta \r\nque desea eliminar\r\n\r\n";
            // 
            // numeroPropTXT
            // 
            this.numeroPropTXT.Location = new System.Drawing.Point(148, 245);
            this.numeroPropTXT.Name = "numeroPropTXT";
            this.numeroPropTXT.Size = new System.Drawing.Size(100, 31);
            this.numeroPropTXT.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Eliminar propuesta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 1026);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 10;
            // 
            // actualizarBT
            // 
            this.actualizarBT.Location = new System.Drawing.Point(472, 446);
            this.actualizarBT.Name = "actualizarBT";
            this.actualizarBT.Size = new System.Drawing.Size(155, 61);
            this.actualizarBT.TabIndex = 11;
            this.actualizarBT.Text = "Actualizar";
            this.actualizarBT.UseVisualStyleBackColor = true;
            this.actualizarBT.Click += new System.EventHandler(this.actualizarBT_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1365, 1051);
            this.Controls.Add(this.actualizarBT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.capturarBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.propuestaTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propuestasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource propuestasBindingSource;
        private DataSet1TableAdapters.PropuestasTableAdapter propuestasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPropuestaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propuestaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numClienDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox propuestaTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button capturarBT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button eliminarBT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numeroPropTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button actualizarBT;
    }
}