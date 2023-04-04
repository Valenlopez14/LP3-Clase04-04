
namespace LP3._04._04
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
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.btnGrabar2 = new System.Windows.Forms.Button();
            this.btnGrabar3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(209, 188);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "GRABAR";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(88, 64);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(564, 20);
            this.txtFrase.TabIndex = 1;
            // 
            // btnGrabar2
            // 
            this.btnGrabar2.Location = new System.Drawing.Point(327, 187);
            this.btnGrabar2.Name = "btnGrabar2";
            this.btnGrabar2.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar2.TabIndex = 2;
            this.btnGrabar2.Text = "Grabar2";
            this.btnGrabar2.UseVisualStyleBackColor = true;
            this.btnGrabar2.Click += new System.EventHandler(this.btnGrabar2_Click);
            // 
            // btnGrabar3
            // 
            this.btnGrabar3.Location = new System.Drawing.Point(438, 188);
            this.btnGrabar3.Name = "btnGrabar3";
            this.btnGrabar3.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar3.TabIndex = 3;
            this.btnGrabar3.Text = "Grabar3";
            this.btnGrabar3.UseVisualStyleBackColor = true;
            this.btnGrabar3.Click += new System.EventHandler(this.btnGrabar3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGrabar3);
            this.Controls.Add(this.btnGrabar2);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.btnGrabar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Button btnGrabar2;
        private System.Windows.Forms.Button btnGrabar3;
    }
}

