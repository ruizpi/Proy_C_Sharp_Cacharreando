namespace ConFormulario2
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
            this.EdNombre = new System.Windows.Forms.TextBox();
            this.LstBox = new System.Windows.Forms.ListBox();
            this.BotOk = new System.Windows.Forms.Button();
            this.BotCerrar = new System.Windows.Forms.Button();
            this.BOTMODIFICAR = new System.Windows.Forms.Button();
            this.BOTELIMINAR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EdNuevoNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE:";
            // 
            // EdNombre
            // 
            this.EdNombre.Location = new System.Drawing.Point(144, 37);
            this.EdNombre.Name = "EdNombre";
            this.EdNombre.Size = new System.Drawing.Size(188, 22);
            this.EdNombre.TabIndex = 1;
            // 
            // LstBox
            // 
            this.LstBox.FormattingEnabled = true;
            this.LstBox.ItemHeight = 16;
            this.LstBox.Location = new System.Drawing.Point(64, 96);
            this.LstBox.Name = "LstBox";
            this.LstBox.Size = new System.Drawing.Size(156, 100);
            this.LstBox.TabIndex = 2;
            // 
            // BotOk
            // 
            this.BotOk.Location = new System.Drawing.Point(64, 324);
            this.BotOk.Name = "BotOk";
            this.BotOk.Size = new System.Drawing.Size(119, 60);
            this.BotOk.TabIndex = 3;
            this.BotOk.Text = "OK";
            this.BotOk.UseVisualStyleBackColor = true;
            this.BotOk.Click += new System.EventHandler(this.BotOk_Click);
            // 
            // BotCerrar
            // 
            this.BotCerrar.Location = new System.Drawing.Point(213, 324);
            this.BotCerrar.Name = "BotCerrar";
            this.BotCerrar.Size = new System.Drawing.Size(119, 60);
            this.BotCerrar.TabIndex = 4;
            this.BotCerrar.Text = "CERRAR";
            this.BotCerrar.UseVisualStyleBackColor = true;
            // 
            // BOTMODIFICAR
            // 
            this.BOTMODIFICAR.Location = new System.Drawing.Point(62, 214);
            this.BOTMODIFICAR.Name = "BOTMODIFICAR";
            this.BOTMODIFICAR.Size = new System.Drawing.Size(120, 61);
            this.BOTMODIFICAR.TabIndex = 5;
            this.BOTMODIFICAR.Text = "MODIFICAR";
            this.BOTMODIFICAR.UseVisualStyleBackColor = true;
            this.BOTMODIFICAR.Click += new System.EventHandler(this.BOTMODIFICAR_Click);
            // 
            // BOTELIMINAR
            // 
            this.BOTELIMINAR.Location = new System.Drawing.Point(213, 214);
            this.BOTELIMINAR.Name = "BOTELIMINAR";
            this.BOTELIMINAR.Size = new System.Drawing.Size(119, 61);
            this.BOTELIMINAR.TabIndex = 6;
            this.BOTELIMINAR.Text = "ELIMINAR";
            this.BOTELIMINAR.UseVisualStyleBackColor = true;
            this.BOTELIMINAR.Click += new System.EventHandler(this.BOTELIMINAR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "NUEVO NOMBRE:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EdNuevoNombre
            // 
            this.EdNuevoNombre.Location = new System.Drawing.Point(518, 34);
            this.EdNuevoNombre.Name = "EdNuevoNombre";
            this.EdNuevoNombre.Size = new System.Drawing.Size(142, 22);
            this.EdNuevoNombre.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EdNuevoNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BOTELIMINAR);
            this.Controls.Add(this.BOTMODIFICAR);
            this.Controls.Add(this.BotCerrar);
            this.Controls.Add(this.BotOk);
            this.Controls.Add(this.LstBox);
            this.Controls.Add(this.EdNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EdNombre;
        private System.Windows.Forms.ListBox LstBox;
        private System.Windows.Forms.Button BotOk;
        private System.Windows.Forms.Button BotCerrar;
        private System.Windows.Forms.Button BOTMODIFICAR;
        private System.Windows.Forms.Button BOTELIMINAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EdNuevoNombre;
    }
}

