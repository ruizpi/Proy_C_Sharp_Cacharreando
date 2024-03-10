namespace ConectarSqlServer
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
            this.BOTCONECTARSE = new System.Windows.Forms.Button();
            this.BOTDESCONECTAR = new System.Windows.Forms.Button();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BOTCONECTARSE
            // 
            this.BOTCONECTARSE.Location = new System.Drawing.Point(23, 23);
            this.BOTCONECTARSE.Name = "BOTCONECTARSE";
            this.BOTCONECTARSE.Size = new System.Drawing.Size(284, 66);
            this.BOTCONECTARSE.TabIndex = 0;
            this.BOTCONECTARSE.Text = "CONECTARSE";
            this.BOTCONECTARSE.UseVisualStyleBackColor = true;
            this.BOTCONECTARSE.Click += new System.EventHandler(this.BOTCONECTARSE_Click);
            // 
            // BOTDESCONECTAR
            // 
            this.BOTDESCONECTAR.Location = new System.Drawing.Point(23, 110);
            this.BOTDESCONECTAR.Name = "BOTDESCONECTAR";
            this.BOTDESCONECTAR.Size = new System.Drawing.Size(284, 64);
            this.BOTDESCONECTAR.TabIndex = 1;
            this.BOTDESCONECTAR.Text = "DESCONECTAR";
            this.BOTDESCONECTAR.UseVisualStyleBackColor = true;
            this.BOTDESCONECTAR.Click += new System.EventHandler(this.BOTDESCONECTAR_Click);
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.Location = new System.Drawing.Point(21, 232);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(285, 83);
            this.BtnConsulta.TabIndex = 2;
            this.BtnConsulta.Text = "CONSULTA";
            this.BtnConsulta.UseVisualStyleBackColor = true;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(338, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(665, 345);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pais";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(22, 385);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(284, 22);
            this.txtConsulta.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 449);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnConsulta);
            this.Controls.Add(this.BOTDESCONECTAR);
            this.Controls.Add(this.BOTCONECTARSE);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BOTCONECTARSE;
        private System.Windows.Forms.Button BOTDESCONECTAR;
        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsulta;
    }
}

