namespace Practica4
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
            this.txtU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnIngresa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtU
            // 
            this.txtU.Location = new System.Drawing.Point(116, 191);
            this.txtU.Name = "txtU";
            this.txtU.Size = new System.Drawing.Size(233, 26);
            this.txtU.TabIndex = 0;
            this.txtU.Text = "*********";
            this.txtU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "USUARIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practica4.Properties.Resources.Mundo;
            this.pictureBox1.Location = new System.Drawing.Point(138, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONTRASEÑA";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(116, 288);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(233, 26);
            this.txtC.TabIndex = 4;
            this.txtC.Text = "*********";
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIngresa
            // 
            this.btnIngresa.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresa.Location = new System.Drawing.Point(160, 334);
            this.btnIngresa.Name = "btnIngresa";
            this.btnIngresa.Size = new System.Drawing.Size(150, 34);
            this.btnIngresa.TabIndex = 5;
            this.btnIngresa.Text = "INGRESAR";
            this.btnIngresa.UseVisualStyleBackColor = false;
            this.btnIngresa.Click += new System.EventHandler(this.btnIngresa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 380);
            this.Controls.Add(this.btnIngresa);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtU);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnIngresa;
    }
}

