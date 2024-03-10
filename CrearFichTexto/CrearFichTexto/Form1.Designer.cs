namespace CrearFichTexto
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
            this.BOTESCRIBIR = new System.Windows.Forms.Button();
            this.BOTLEER = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BOTESCRIBIR
            // 
            this.BOTESCRIBIR.Location = new System.Drawing.Point(32, 17);
            this.BOTESCRIBIR.Name = "BOTESCRIBIR";
            this.BOTESCRIBIR.Size = new System.Drawing.Size(216, 84);
            this.BOTESCRIBIR.TabIndex = 0;
            this.BOTESCRIBIR.Text = "ESCRIBIR";
            this.BOTESCRIBIR.UseVisualStyleBackColor = true;
            this.BOTESCRIBIR.Click += new System.EventHandler(this.BOTESCRIBIR_Click);
            // 
            // BOTLEER
            // 
            this.BOTLEER.Location = new System.Drawing.Point(32, 121);
            this.BOTLEER.Name = "BOTLEER";
            this.BOTLEER.Size = new System.Drawing.Size(216, 84);
            this.BOTLEER.TabIndex = 1;
            this.BOTLEER.Text = "LEER";
            this.BOTLEER.UseVisualStyleBackColor = true;
            this.BOTLEER.Click += new System.EventHandler(this.BOTLEER_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 265);
            this.Controls.Add(this.BOTLEER);
            this.Controls.Add(this.BOTESCRIBIR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BOTESCRIBIR;
        private System.Windows.Forms.Button BOTLEER;
    }
}

