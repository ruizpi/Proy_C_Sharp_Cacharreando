namespace AppConInforme
{
    partial class FormPruebas
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
            this.GridPruebas = new System.Windows.Forms.DataGridView();
            this.BtnFiltraDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EdNombre = new System.Windows.Forms.TextBox();
            this.EdCodProducto = new System.Windows.Forms.TextBox();
            this.CmbClientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EdApellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridPruebas)).BeginInit();
            this.SuspendLayout();
            // 
            // GridPruebas
            // 
            this.GridPruebas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPruebas.Location = new System.Drawing.Point(165, 199);
            this.GridPruebas.Name = "GridPruebas";
            this.GridPruebas.RowHeadersWidth = 51;
            this.GridPruebas.Size = new System.Drawing.Size(311, 223);
            this.GridPruebas.TabIndex = 0;
            // 
            // BtnFiltraDatos
            // 
            this.BtnFiltraDatos.Location = new System.Drawing.Point(578, 82);
            this.BtnFiltraDatos.Name = "BtnFiltraDatos";
            this.BtnFiltraDatos.Size = new System.Drawing.Size(150, 71);
            this.BtnFiltraDatos.TabIndex = 1;
            this.BtnFiltraDatos.Text = "Filtrar Datos";
            this.BtnFiltraDatos.UseVisualStyleBackColor = true;
            this.BtnFiltraDatos.Click += new System.EventHandler(this.BtnFiltraDatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "APELLIDOS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "COD. PRODUCTO:";
            // 
            // EdNombre
            // 
            this.EdNombre.Location = new System.Drawing.Point(131, 102);
            this.EdNombre.Name = "EdNombre";
            this.EdNombre.Size = new System.Drawing.Size(353, 22);
            this.EdNombre.TabIndex = 6;
            // 
            // EdCodProducto
            // 
            this.EdCodProducto.Location = new System.Drawing.Point(184, 148);
            this.EdCodProducto.Name = "EdCodProducto";
            this.EdCodProducto.Size = new System.Drawing.Size(353, 22);
            this.EdCodProducto.TabIndex = 7;
            // 
            // CmbClientes
            // 
            this.CmbClientes.FormattingEnabled = true;
            this.CmbClientes.Location = new System.Drawing.Point(128, 12);
            this.CmbClientes.Name = "CmbClientes";
            this.CmbClientes.Size = new System.Drawing.Size(289, 24);
            this.CmbClientes.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE:";
            // 
            // EdApellidos
            // 
            this.EdApellidos.Location = new System.Drawing.Point(145, 63);
            this.EdApellidos.Name = "EdApellidos";
            this.EdApellidos.Size = new System.Drawing.Size(353, 22);
            this.EdApellidos.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "CLIENTE:";
            // 
            // FormPruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbClientes);
            this.Controls.Add(this.EdCodProducto);
            this.Controls.Add(this.EdNombre);
            this.Controls.Add(this.EdApellidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFiltraDatos);
            this.Controls.Add(this.GridPruebas);
            this.Name = "FormPruebas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormPruebas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPruebas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridPruebas;
        private System.Windows.Forms.Button BtnFiltraDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EdNombre;
        private System.Windows.Forms.TextBox EdCodProducto;
        private System.Windows.Forms.ComboBox CmbClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EdApellidos;
        private System.Windows.Forms.Label label4;
    }
}