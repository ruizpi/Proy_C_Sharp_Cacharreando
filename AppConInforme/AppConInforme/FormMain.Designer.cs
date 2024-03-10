namespace AppConInforme
{
    partial class FormMain
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
            this.BtnInformes = new System.Windows.Forms.Button();
            this.BtnPruebas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnInformes
            // 
            this.BtnInformes.Location = new System.Drawing.Point(45, 36);
            this.BtnInformes.Name = "BtnInformes";
            this.BtnInformes.Size = new System.Drawing.Size(166, 115);
            this.BtnInformes.TabIndex = 0;
            this.BtnInformes.Text = "ACCEDE A INFORMES";
            this.BtnInformes.UseVisualStyleBackColor = true;
            this.BtnInformes.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnPruebas
            // 
            this.BtnPruebas.Location = new System.Drawing.Point(50, 172);
            this.BtnPruebas.Name = "BtnPruebas";
            this.BtnPruebas.Size = new System.Drawing.Size(160, 103);
            this.BtnPruebas.TabIndex = 1;
            this.BtnPruebas.Text = "Pruebas";
            this.BtnPruebas.UseVisualStyleBackColor = true;
            this.BtnPruebas.Click += new System.EventHandler(this.BtnPruebas_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 415);
            this.Controls.Add(this.BtnPruebas);
            this.Controls.Add(this.BtnInformes);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnInformes;
        private System.Windows.Forms.Button BtnPruebas;
    }
}

