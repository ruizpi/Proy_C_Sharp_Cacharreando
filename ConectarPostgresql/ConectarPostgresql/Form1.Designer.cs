namespace ConectarPostgresql
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
            this.BOTCONECTAR = new System.Windows.Forms.Button();
            this.BOTDESCONECTA = new System.Windows.Forms.Button();
            this.BOTCONSULTA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EdNombre = new System.Windows.Forms.TextBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EdIdPersonaIns = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EdNombreIns = new System.Windows.Forms.TextBox();
            this.EdCedulaIns = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.EdIdBorrar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // BOTCONECTAR
            // 
            this.BOTCONECTAR.Location = new System.Drawing.Point(31, 23);
            this.BOTCONECTAR.Name = "BOTCONECTAR";
            this.BOTCONECTAR.Size = new System.Drawing.Size(223, 87);
            this.BOTCONECTAR.TabIndex = 0;
            this.BOTCONECTAR.Text = "CONECTAR POSTGRESQL";
            this.BOTCONECTAR.UseVisualStyleBackColor = true;
            this.BOTCONECTAR.Click += new System.EventHandler(this.BOTCONECTAR_Click);
            // 
            // BOTDESCONECTA
            // 
            this.BOTDESCONECTA.Location = new System.Drawing.Point(29, 126);
            this.BOTDESCONECTA.Name = "BOTDESCONECTA";
            this.BOTDESCONECTA.Size = new System.Drawing.Size(224, 78);
            this.BOTDESCONECTA.TabIndex = 1;
            this.BOTDESCONECTA.Text = "DESCONECTAR";
            this.BOTDESCONECTA.UseVisualStyleBackColor = true;
            this.BOTDESCONECTA.Click += new System.EventHandler(this.BOTDESCONECTA_Click);
            // 
            // BOTCONSULTA
            // 
            this.BOTCONSULTA.Location = new System.Drawing.Point(30, 219);
            this.BOTCONSULTA.Name = "BOTCONSULTA";
            this.BOTCONSULTA.Size = new System.Drawing.Size(222, 80);
            this.BOTCONSULTA.TabIndex = 2;
            this.BOTCONSULTA.Text = "CONSULTA";
            this.BOTCONSULTA.UseVisualStyleBackColor = true;
            this.BOTCONSULTA.Click += new System.EventHandler(this.BOTCONSULTA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOMBRE:";
            // 
            // EdNombre
            // 
            this.EdNombre.Location = new System.Drawing.Point(28, 352);
            this.EdNombre.Name = "EdNombre";
            this.EdNombre.Size = new System.Drawing.Size(223, 22);
            this.EdNombre.TabIndex = 4;
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(262, 26);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidth = 51;
            this.Grid.RowTemplate.Height = 24;
            this.Grid.Size = new System.Drawing.Size(781, 362);
            this.Grid.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "INSERTA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // EdIdPersonaIns
            // 
            this.EdIdPersonaIns.Location = new System.Drawing.Point(268, 422);
            this.EdIdPersonaIns.Name = "EdIdPersonaIns";
            this.EdIdPersonaIns.Size = new System.Drawing.Size(91, 22);
            this.EdIdPersonaIns.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "CEDULA";
            // 
            // EdNombreIns
            // 
            this.EdNombreIns.Location = new System.Drawing.Point(394, 423);
            this.EdNombreIns.Name = "EdNombreIns";
            this.EdNombreIns.Size = new System.Drawing.Size(155, 22);
            this.EdNombreIns.TabIndex = 11;
            // 
            // EdCedulaIns
            // 
            this.EdCedulaIns.Location = new System.Drawing.Point(557, 423);
            this.EdCedulaIns.Name = "EdCedulaIns";
            this.EdCedulaIns.Size = new System.Drawing.Size(148, 22);
            this.EdCedulaIns.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 57);
            this.button2.TabIndex = 13;
            this.button2.Text = "BORRAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EdIdBorrar
            // 
            this.EdIdBorrar.Location = new System.Drawing.Point(268, 526);
            this.EdIdBorrar.Name = "EdIdBorrar";
            this.EdIdBorrar.Size = new System.Drawing.Size(91, 22);
            this.EdIdBorrar.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID BORRAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 597);
            this.Controls.Add(this.EdIdBorrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EdCedulaIns);
            this.Controls.Add(this.EdNombreIns);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EdIdPersonaIns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.EdNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BOTCONSULTA);
            this.Controls.Add(this.BOTDESCONECTA);
            this.Controls.Add(this.BOTCONECTAR);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BOTCONECTAR;
        private System.Windows.Forms.Button BOTDESCONECTA;
        private System.Windows.Forms.Button BOTCONSULTA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EdNombre;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EdIdPersonaIns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EdNombreIns;
        private System.Windows.Forms.TextBox EdCedulaIns;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox EdIdBorrar;
        private System.Windows.Forms.Label label5;
    }
}

