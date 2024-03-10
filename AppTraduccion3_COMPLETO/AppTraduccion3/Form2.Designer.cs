namespace AppTraduccion3
{
    partial class FormAltas
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
            this.LabNombre = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabNombre
            // 
            this.LabNombre.AutoSize = true;
            this.LabNombre.Location = new System.Drawing.Point(91, 64);
            this.LabNombre.Name = "LabNombre";
            this.LabNombre.Size = new System.Drawing.Size(44, 16);
            this.LabNombre.TabIndex = 0;
            this.LabNombre.Text = "label1";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(94, 143);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(142, 66);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "button1";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // FormAltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.LabNombre);
            this.Name = "FormAltas";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormAltas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabNombre;
        private System.Windows.Forms.Button btnOk;
    }
}