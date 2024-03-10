namespace VentanaDialog
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
            this.BOTABRIR = new System.Windows.Forms.Button();
            this.BOTGUARDAR = new System.Windows.Forms.Button();
            this.BOTESCRIBIR = new System.Windows.Forms.Button();
            this.BOTLEER = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EDDireccion = new System.Windows.Forms.TextBox();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // BOTABRIR
            // 
            this.BOTABRIR.Location = new System.Drawing.Point(402, 104);
            this.BOTABRIR.Name = "BOTABRIR";
            this.BOTABRIR.Size = new System.Drawing.Size(221, 84);
            this.BOTABRIR.TabIndex = 0;
            this.BOTABRIR.Text = "ABRIR";
            this.BOTABRIR.UseVisualStyleBackColor = true;
            this.BOTABRIR.Click += new System.EventHandler(this.BOTABRIR_Click);
            // 
            // BOTGUARDAR
            // 
            this.BOTGUARDAR.Location = new System.Drawing.Point(402, 212);
            this.BOTGUARDAR.Name = "BOTGUARDAR";
            this.BOTGUARDAR.Size = new System.Drawing.Size(218, 82);
            this.BOTGUARDAR.TabIndex = 1;
            this.BOTGUARDAR.Text = "GUARDAR";
            this.BOTGUARDAR.UseVisualStyleBackColor = true;
            this.BOTGUARDAR.Click += new System.EventHandler(this.BOTGUARDAR_Click);
            // 
            // BOTESCRIBIR
            // 
            this.BOTESCRIBIR.Location = new System.Drawing.Point(402, 391);
            this.BOTESCRIBIR.Name = "BOTESCRIBIR";
            this.BOTESCRIBIR.Size = new System.Drawing.Size(218, 84);
            this.BOTESCRIBIR.TabIndex = 2;
            this.BOTESCRIBIR.Text = "ESCRIBIR";
            this.BOTESCRIBIR.UseVisualStyleBackColor = true;
            // 
            // BOTLEER
            // 
            this.BOTLEER.Location = new System.Drawing.Point(402, 490);
            this.BOTLEER.Name = "BOTLEER";
            this.BOTLEER.Size = new System.Drawing.Size(218, 84);
            this.BOTLEER.TabIndex = 3;
            this.BOTLEER.Text = "LEER";
            this.BOTLEER.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "DIRECCION:";
            // 
            // EDDireccion
            // 
            this.EDDireccion.Location = new System.Drawing.Point(108, 29);
            this.EDDireccion.Name = "EDDireccion";
            this.EDDireccion.Size = new System.Drawing.Size(276, 22);
            this.EDDireccion.TabIndex = 5;
            // 
            // RichTextBox
            // 
            this.RichTextBox.Location = new System.Drawing.Point(24, 104);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(360, 470);
            this.RichTextBox.TabIndex = 6;
            this.RichTextBox.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 694);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.EDDireccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BOTLEER);
            this.Controls.Add(this.BOTESCRIBIR);
            this.Controls.Add(this.BOTGUARDAR);
            this.Controls.Add(this.BOTABRIR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BOTABRIR;
        private System.Windows.Forms.Button BOTGUARDAR;
        private System.Windows.Forms.Button BOTESCRIBIR;
        private System.Windows.Forms.Button BOTLEER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EDDireccion;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

