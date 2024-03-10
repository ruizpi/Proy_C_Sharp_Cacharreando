namespace ConFormulario1
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
            this.label1 = new System.Windows.Forms.Label();
            this.EdNombres = new System.Windows.Forms.TextBox();
            this.LstNombres = new System.Windows.Forms.ListBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRES:";
            // 
            // EdNombres
            // 
            this.EdNombres.Location = new System.Drawing.Point(119, 22);
            this.EdNombres.Name = "EdNombres";
            this.EdNombres.Size = new System.Drawing.Size(188, 22);
            this.EdNombres.TabIndex = 1;
            // 
            // LstNombres
            // 
            this.LstNombres.FormattingEnabled = true;
            this.LstNombres.ItemHeight = 16;
            this.LstNombres.Location = new System.Drawing.Point(38, 84);
            this.LstNombres.Name = "LstNombres";
            this.LstNombres.Size = new System.Drawing.Size(269, 132);
            this.LstNombres.TabIndex = 2;
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(38, 364);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(113, 54);
            this.BtnOk.TabIndex = 3;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(194, 364);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(113, 53);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "CERRAR";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 450);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.LstNombres);
            this.Controls.Add(this.EdNombres);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "EJERCICIO FORM 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EdNombres;
        private System.Windows.Forms.ListBox LstNombres;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnClose;
    }
}

