namespace AppConInforme
{
    partial class FormInforme
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.puntodeVentaDataSet = new AppConInforme.PuntodeVentaDataSet();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directoryEntry2 = new System.DirectoryServices.DirectoryEntry();
            this.puntodeVentaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new AppConInforme.PuntodeVentaDataSetTableAdapters.ClientesTableAdapter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.EdNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EdApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EdTelefono = new System.Windows.Forms.TextBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntodeVentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntodeVentaDataSetBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.puntodeVentaDataSet;
            // 
            // puntodeVentaDataSet
            // 
            this.puntodeVentaDataSet.DataSetName = "PuntodeVentaDataSet";
            this.puntodeVentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // puntodeVentaDataSetBindingSource
            // 
            this.puntodeVentaDataSetBindingSource.DataSource = this.puntodeVentaDataSet;
            this.puntodeVentaDataSetBindingSource.Position = 0;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.RptViewer);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(810, 386);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // RptViewer
            // 
            reportDataSource2.Name = "DsClientes";
            reportDataSource2.Value = this.clientesBindingSource;
            this.RptViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.RptViewer.LocalReport.ReportEmbeddedResource = "AppConInforme.Informes.InformeClientes.rdlc";
            this.RptViewer.Location = new System.Drawing.Point(15, 15);
            this.RptViewer.Margin = new System.Windows.Forms.Padding(15);
            this.RptViewer.Name = "RptViewer";
            this.RptViewer.ServerReport.BearerToken = null;
            this.RptViewer.Size = new System.Drawing.Size(783, 361);
            this.RptViewer.TabIndex = 1;
            this.RptViewer.Load += new System.EventHandler(this.RptViewer_Load);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.EdNombre);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.EdApellidos);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.EdTelefono);
            this.flowLayoutPanel2.Controls.Add(this.BtnFiltrar);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(844, 60);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 15, 1, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE:";
            // 
            // EdNombre
            // 
            this.EdNombre.Location = new System.Drawing.Point(87, 15);
            this.EdNombre.Margin = new System.Windows.Forms.Padding(2, 15, 15, 15);
            this.EdNombre.Name = "EdNombre";
            this.EdNombre.Size = new System.Drawing.Size(100, 22);
            this.EdNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 15, 1, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "APELLIDOS:";
            // 
            // EdApellidos
            // 
            this.EdApellidos.Location = new System.Drawing.Point(303, 15);
            this.EdApellidos.Margin = new System.Windows.Forms.Padding(2, 15, 15, 15);
            this.EdApellidos.Name = "EdApellidos";
            this.EdApellidos.Size = new System.Drawing.Size(100, 22);
            this.EdApellidos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 15, 1, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "TELEFONO:";
            // 
            // EdTelefono
            // 
            this.EdTelefono.Location = new System.Drawing.Point(517, 15);
            this.EdTelefono.Margin = new System.Windows.Forms.Padding(1, 15, 15, 15);
            this.EdTelefono.Name = "EdTelefono";
            this.EdTelefono.Size = new System.Drawing.Size(100, 22);
            this.EdTelefono.TabIndex = 5;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(657, 10);
            this.BtnFiltrar.Margin = new System.Windows.Forms.Padding(25, 10, 10, 10);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(136, 43);
            this.BtnFiltrar.TabIndex = 7;
            this.BtnFiltrar.Text = "FILTRAR";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // FormInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 516);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormInforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInforme";
            this.Load += new System.EventHandler(this.FormInforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntodeVentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntodeVentaDataSetBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectoryEntry directoryEntry2;
        private System.Windows.Forms.BindingSource puntodeVentaDataSetBindingSource;
        private PuntodeVentaDataSet puntodeVentaDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private PuntodeVentaDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Microsoft.Reporting.WinForms.ReportViewer RptViewer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EdNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EdApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EdTelefono;
        private System.Windows.Forms.Button BtnFiltrar;
    }
}