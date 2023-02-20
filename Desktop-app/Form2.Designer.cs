
namespace Proyecto1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.display = new System.Windows.Forms.Label();
            this.registroBT = new System.Windows.Forms.Button();
            this.telTXT = new System.Windows.Forms.TextBox();
            this.emailTXT = new System.Windows.Forms.TextBox();
            this.rfcTXT = new System.Windows.Forms.TextBox();
            this.nombreTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.propuestaBT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.display);
            this.panel1.Controls.Add(this.registroBT);
            this.panel1.Controls.Add(this.telTXT);
            this.panel1.Controls.Add(this.emailTXT);
            this.panel1.Controls.Add(this.rfcTXT);
            this.panel1.Controls.Add(this.nombreTXT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(202, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 470);
            this.panel1.TabIndex = 0;
            // 
            // display
            // 
            this.display.AutoSize = true;
            this.display.Location = new System.Drawing.Point(212, 321);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(0, 25);
            this.display.TabIndex = 9;
            // 
            // registroBT
            // 
            this.registroBT.BackColor = System.Drawing.Color.Gray;
            this.registroBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroBT.Location = new System.Drawing.Point(342, 362);
            this.registroBT.Name = "registroBT";
            this.registroBT.Size = new System.Drawing.Size(248, 77);
            this.registroBT.TabIndex = 8;
            this.registroBT.Text = "Registrarme";
            this.registroBT.UseVisualStyleBackColor = false;
            this.registroBT.Click += new System.EventHandler(this.registroBT_Click);
            // 
            // telTXT
            // 
            this.telTXT.Location = new System.Drawing.Point(296, 247);
            this.telTXT.Name = "telTXT";
            this.telTXT.Size = new System.Drawing.Size(492, 31);
            this.telTXT.TabIndex = 7;
            // 
            // emailTXT
            // 
            this.emailTXT.Location = new System.Drawing.Point(296, 181);
            this.emailTXT.Multiline = true;
            this.emailTXT.Name = "emailTXT";
            this.emailTXT.Size = new System.Drawing.Size(492, 31);
            this.emailTXT.TabIndex = 6;
            // 
            // rfcTXT
            // 
            this.rfcTXT.Location = new System.Drawing.Point(296, 114);
            this.rfcTXT.Name = "rfcTXT";
            this.rfcTXT.Size = new System.Drawing.Size(492, 31);
            this.rfcTXT.TabIndex = 5;
            // 
            // nombreTXT
            // 
            this.nombreTXT.Location = new System.Drawing.Point(296, 52);
            this.nombreTXT.Name = "nombreTXT";
            this.nombreTXT.Size = new System.Drawing.Size(492, 31);
            this.nombreTXT.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "RFC: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(675, 55);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ingrese los siguientes datos: ";
            // 
            // propuestaBT
            // 
            this.propuestaBT.BackColor = System.Drawing.Color.Gray;
            this.propuestaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propuestaBT.Location = new System.Drawing.Point(895, 25);
            this.propuestaBT.Name = "propuestaBT";
            this.propuestaBT.Size = new System.Drawing.Size(251, 74);
            this.propuestaBT.TabIndex = 10;
            this.propuestaBT.Text = "Capturar propuestas";
            this.propuestaBT.UseVisualStyleBackColor = false;
            this.propuestaBT.Click += new System.EventHandler(this.propuestaBT_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.propuestaBT);
            this.panel2.Location = new System.Drawing.Point(47, 641);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1194, 126);
            this.panel2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(695, 62);
            this.label6.TabIndex = 0;
            this.label6.Text = "Su usuario para iniciar sesión será su correo electrónico,\r\n y su contraseña su R" +
    "FC\r\n";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(324, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(692, 100);
            this.panel3.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1289, 803);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button registroBT;
        private System.Windows.Forms.TextBox telTXT;
        private System.Windows.Forms.TextBox emailTXT;
        private System.Windows.Forms.TextBox rfcTXT;
        private System.Windows.Forms.TextBox nombreTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button propuestaBT;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
    }
}