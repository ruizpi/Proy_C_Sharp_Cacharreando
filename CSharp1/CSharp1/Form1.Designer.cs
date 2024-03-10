namespace CSharp1
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
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LabSaludo = new System.Windows.Forms.Label();
            this.EdComida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(245, 202);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(193, 90);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(475, 202);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(193, 90);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "CERRAR";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LabSaludo
            // 
            this.LabSaludo.AutoSize = true;
            this.LabSaludo.Location = new System.Drawing.Point(61, 37);
            this.LabSaludo.Name = "LabSaludo";
            this.LabSaludo.Size = new System.Drawing.Size(62, 16);
            this.LabSaludo.TabIndex = 2;
            this.LabSaludo.Text = "COMIDA:";
            this.LabSaludo.Click += new System.EventHandler(this.LabSaludo_Click);
            // 
            // EdComida
            // 
            this.EdComida.Location = new System.Drawing.Point(176, 31);
            this.EdComida.Name = "EdComida";
            this.EdComida.Size = new System.Drawing.Size(213, 22);
            this.EdComida.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 499);
            this.Controls.Add(this.EdComida);
            this.Controls.Add(this.LabSaludo);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnOK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LabSaludo;
        private System.Windows.Forms.TextBox EdComida;
    }
}

