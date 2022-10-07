namespace Proyecto_pilas
{
    partial class Directoio
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
            this.lbDir = new System.Windows.Forms.ListBox();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDir
            // 
            this.lbDir.FormattingEnabled = true;
            this.lbDir.Location = new System.Drawing.Point(12, 43);
            this.lbDir.Name = "lbDir";
            this.lbDir.Size = new System.Drawing.Size(110, 225);
            this.lbDir.TabIndex = 0;
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(151, 43);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(100, 20);
            this.txtFolder.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(258, 39);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Directoio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 296);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.lbDir);
            this.Name = "Directoio";
            this.Text = "Directorio";
            this.Load += new System.EventHandler(this.Directoio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDir;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnAgregar;
    }
}

