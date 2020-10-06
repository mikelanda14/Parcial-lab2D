namespace FrmLogin
{
    partial class FrnComprasEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrnComprasEmpleados));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCerrarReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(452, 217);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnCerrarReporte
            // 
            this.btnCerrarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarReporte.ForeColor = System.Drawing.Color.Red;
            this.btnCerrarReporte.Location = new System.Drawing.Point(166, 238);
            this.btnCerrarReporte.Name = "btnCerrarReporte";
            this.btnCerrarReporte.Size = new System.Drawing.Size(75, 39);
            this.btnCerrarReporte.TabIndex = 1;
            this.btnCerrarReporte.Text = "Cerrar";
            this.btnCerrarReporte.UseVisualStyleBackColor = true;
            this.btnCerrarReporte.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrnComprasEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(476, 289);
            this.Controls.Add(this.btnCerrarReporte);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrnComprasEmpleados";
            this.Text = "FrnComprasEmpleados";
            this.Load += new System.EventHandler(this.FrnComprasEmpleados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnCerrarReporte;
    }
}