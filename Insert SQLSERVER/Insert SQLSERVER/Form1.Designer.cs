namespace Insert_SQLSERVER
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
            this.BOTCONECTA = new System.Windows.Forms.Button();
            this.BOTDESCONECTA = new System.Windows.Forms.Button();
            this.BOTCONSULTA = new System.Windows.Forms.Button();
            this.LAB = new System.Windows.Forms.Label();
            this.EdPaisFiltro = new System.Windows.Forms.TextBox();
            this.BOTAGREGAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EdNombre = new System.Windows.Forms.TextBox();
            this.EdApellidos = new System.Windows.Forms.TextBox();
            this.EdDNI = new System.Windows.Forms.TextBox();
            this.EdPais = new System.Windows.Forms.TextBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.BOTACTUALIZAR = new System.Windows.Forms.Button();
            this.BOTELIMINAR = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.EdID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BOTCONECTA
            // 
            this.BOTCONECTA.Location = new System.Drawing.Point(28, 19);
            this.BOTCONECTA.Name = "BOTCONECTA";
            this.BOTCONECTA.Size = new System.Drawing.Size(226, 45);
            this.BOTCONECTA.TabIndex = 0;
            this.BOTCONECTA.Text = "CONECTA";
            this.BOTCONECTA.UseVisualStyleBackColor = true;
            this.BOTCONECTA.Click += new System.EventHandler(this.BOTCONECTA_Click);
            // 
            // BOTDESCONECTA
            // 
            this.BOTDESCONECTA.Location = new System.Drawing.Point(27, 79);
            this.BOTDESCONECTA.Name = "BOTDESCONECTA";
            this.BOTDESCONECTA.Size = new System.Drawing.Size(227, 40);
            this.BOTDESCONECTA.TabIndex = 1;
            this.BOTDESCONECTA.Text = "DESCONECTA";
            this.BOTDESCONECTA.UseVisualStyleBackColor = true;
            this.BOTDESCONECTA.Click += new System.EventHandler(this.BOTDESCONECTA_Click);
            // 
            // BOTCONSULTA
            // 
            this.BOTCONSULTA.Location = new System.Drawing.Point(32, 158);
            this.BOTCONSULTA.Name = "BOTCONSULTA";
            this.BOTCONSULTA.Size = new System.Drawing.Size(222, 44);
            this.BOTCONSULTA.TabIndex = 2;
            this.BOTCONSULTA.Text = "CONSULTA";
            this.BOTCONSULTA.UseVisualStyleBackColor = true;
            this.BOTCONSULTA.Click += new System.EventHandler(this.BOTCONSULTA_Click);
            // 
            // LAB
            // 
            this.LAB.AutoSize = true;
            this.LAB.Location = new System.Drawing.Point(30, 241);
            this.LAB.Name = "LAB";
            this.LAB.Size = new System.Drawing.Size(37, 16);
            this.LAB.TabIndex = 3;
            this.LAB.Text = "Pais:";
            // 
            // EdPaisFiltro
            // 
            this.EdPaisFiltro.Location = new System.Drawing.Point(28, 273);
            this.EdPaisFiltro.Name = "EdPaisFiltro";
            this.EdPaisFiltro.Size = new System.Drawing.Size(225, 22);
            this.EdPaisFiltro.TabIndex = 4;
            // 
            // BOTAGREGAR
            // 
            this.BOTAGREGAR.Location = new System.Drawing.Point(26, 355);
            this.BOTAGREGAR.Name = "BOTAGREGAR";
            this.BOTAGREGAR.Size = new System.Drawing.Size(227, 30);
            this.BOTAGREGAR.TabIndex = 5;
            this.BOTAGREGAR.Text = "AGREGAR";
            this.BOTAGREGAR.UseVisualStyleBackColor = true;
            this.BOTAGREGAR.Click += new System.EventHandler(this.BOTAGREGAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "APELLIDOS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(744, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(906, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "PAIS";
            // 
            // EdNombre
            // 
            this.EdNombre.Location = new System.Drawing.Point(288, 363);
            this.EdNombre.Name = "EdNombre";
            this.EdNombre.Size = new System.Drawing.Size(177, 22);
            this.EdNombre.TabIndex = 10;
            // 
            // EdApellidos
            // 
            this.EdApellidos.Location = new System.Drawing.Point(484, 363);
            this.EdApellidos.Name = "EdApellidos";
            this.EdApellidos.Size = new System.Drawing.Size(249, 22);
            this.EdApellidos.TabIndex = 11;
            // 
            // EdDNI
            // 
            this.EdDNI.Location = new System.Drawing.Point(747, 363);
            this.EdDNI.Name = "EdDNI";
            this.EdDNI.Size = new System.Drawing.Size(151, 22);
            this.EdDNI.TabIndex = 12;
            // 
            // EdPais
            // 
            this.EdPais.Location = new System.Drawing.Point(909, 363);
            this.EdPais.Name = "EdPais";
            this.EdPais.Size = new System.Drawing.Size(130, 22);
            this.EdPais.TabIndex = 13;
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(271, 19);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(756, 295);
            this.DataGrid.TabIndex = 14;
            // 
            // BOTACTUALIZAR
            // 
            this.BOTACTUALIZAR.Location = new System.Drawing.Point(26, 405);
            this.BOTACTUALIZAR.Name = "BOTACTUALIZAR";
            this.BOTACTUALIZAR.Size = new System.Drawing.Size(227, 30);
            this.BOTACTUALIZAR.TabIndex = 15;
            this.BOTACTUALIZAR.Text = "ACTUALIZAR";
            this.BOTACTUALIZAR.UseVisualStyleBackColor = true;
            this.BOTACTUALIZAR.Click += new System.EventHandler(this.BOTACTUALIZAR_Click);
            // 
            // BOTELIMINAR
            // 
            this.BOTELIMINAR.Location = new System.Drawing.Point(26, 456);
            this.BOTELIMINAR.Name = "BOTELIMINAR";
            this.BOTELIMINAR.Size = new System.Drawing.Size(227, 30);
            this.BOTELIMINAR.TabIndex = 16;
            this.BOTELIMINAR.Text = "ELIMINAR";
            this.BOTELIMINAR.UseVisualStyleBackColor = true;
            this.BOTELIMINAR.Click += new System.EventHandler(this.BOTELIMINAR_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "ID:";
            // 
            // EdID
            // 
            this.EdID.Location = new System.Drawing.Point(322, 411);
            this.EdID.Name = "EdID";
            this.EdID.Size = new System.Drawing.Size(108, 22);
            this.EdID.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 520);
            this.Controls.Add(this.EdID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BOTELIMINAR);
            this.Controls.Add(this.BOTACTUALIZAR);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.EdPais);
            this.Controls.Add(this.EdDNI);
            this.Controls.Add(this.EdApellidos);
            this.Controls.Add(this.EdNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BOTAGREGAR);
            this.Controls.Add(this.EdPaisFiltro);
            this.Controls.Add(this.LAB);
            this.Controls.Add(this.BOTCONSULTA);
            this.Controls.Add(this.BOTDESCONECTA);
            this.Controls.Add(this.BOTCONECTA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BOTCONECTA;
        private System.Windows.Forms.Button BOTDESCONECTA;
        private System.Windows.Forms.Button BOTCONSULTA;
        private System.Windows.Forms.Label LAB;
        private System.Windows.Forms.TextBox EdPaisFiltro;
        private System.Windows.Forms.Button BOTAGREGAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EdNombre;
        private System.Windows.Forms.TextBox EdApellidos;
        private System.Windows.Forms.TextBox EdDNI;
        private System.Windows.Forms.TextBox EdPais;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button BOTACTUALIZAR;
        private System.Windows.Forms.Button BOTELIMINAR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EdID;
    }
}

