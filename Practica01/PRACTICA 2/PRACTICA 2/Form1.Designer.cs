namespace PRACTICA_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblsigno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.LABEL = new System.Windows.Forms.Label();
            this.lblresultado2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(35, 81);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(153, 26);
            this.Txt1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGRESA CELSIUS";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(194, 49);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(126, 71);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "CONVERTIR";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "RESULTADO";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Black;
            this.lblResultado.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Lime;
            this.lblResultado.Location = new System.Drawing.Point(345, 62);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 58);
            this.lblResultado.TabIndex = 4;
            // 
            // lblsigno
            // 
            this.lblsigno.AutoSize = true;
            this.lblsigno.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsigno.Location = new System.Drawing.Point(459, 62);
            this.lblsigno.Name = "lblsigno";
            this.lblsigno.Size = new System.Drawing.Size(0, 58);
            this.lblsigno.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "INGRESA FARENHEIT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 72);
            this.button1.TabIndex = 7;
            this.button1.Text = "CONVERTIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(35, 178);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(153, 26);
            this.txt2.TabIndex = 8;
            // 
            // LABEL
            // 
            this.LABEL.AutoSize = true;
            this.LABEL.Location = new System.Drawing.Point(355, 143);
            this.LABEL.Name = "LABEL";
            this.LABEL.Size = new System.Drawing.Size(108, 20);
            this.LABEL.TabIndex = 9;
            this.LABEL.Text = "RESULTADO";
            // 
            // lblresultado2
            // 
            this.lblresultado2.AutoSize = true;
            this.lblresultado2.BackColor = System.Drawing.Color.Black;
            this.lblresultado2.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado2.ForeColor = System.Drawing.Color.Lime;
            this.lblresultado2.Location = new System.Drawing.Point(362, 178);
            this.lblresultado2.Name = "lblresultado2";
            this.lblresultado2.Size = new System.Drawing.Size(0, 58);
            this.lblresultado2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(580, 298);
            this.Controls.Add(this.lblresultado2);
            this.Controls.Add(this.LABEL);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblsigno);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt1);
            this.Name = "Form1";
            this.Text = "Practica2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblsigno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label LABEL;
        private System.Windows.Forms.Label lblresultado2;
    }
}

