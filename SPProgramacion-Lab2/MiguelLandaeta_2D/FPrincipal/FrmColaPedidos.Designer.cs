namespace FPrincipal
{
    partial class FrmColaPedidos
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
            this.DgColaPedidos = new System.Windows.Forms.DataGridView();
            this.DgPListo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgColaPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgPListo)).BeginInit();
            this.SuspendLayout();
            // 
            // DgColaPedidos
            // 
            this.DgColaPedidos.AllowUserToAddRows = false;
            this.DgColaPedidos.AllowUserToDeleteRows = false;
            this.DgColaPedidos.AllowUserToResizeColumns = false;
            this.DgColaPedidos.AllowUserToResizeRows = false;
            this.DgColaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgColaPedidos.Enabled = false;
            this.DgColaPedidos.Location = new System.Drawing.Point(12, 53);
            this.DgColaPedidos.Name = "DgColaPedidos";
            this.DgColaPedidos.ReadOnly = true;
            this.DgColaPedidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgColaPedidos.Size = new System.Drawing.Size(301, 307);
            this.DgColaPedidos.TabIndex = 0;
            // 
            // DgPListo
            // 
            this.DgPListo.AllowUserToAddRows = false;
            this.DgPListo.AllowUserToDeleteRows = false;
            this.DgPListo.AllowUserToResizeColumns = false;
            this.DgPListo.AllowUserToResizeRows = false;
            this.DgPListo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPListo.Enabled = false;
            this.DgPListo.Location = new System.Drawing.Point(449, 53);
            this.DgPListo.Name = "DgPListo";
            this.DgPListo.ReadOnly = true;
            this.DgPListo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgPListo.Size = new System.Drawing.Size(301, 307);
            this.DgPListo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "En preparacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(527, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pedidos Listos";
            // 
            // FrmColaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgPListo);
            this.Controls.Add(this.DgColaPedidos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmColaPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmColaPedidos";
            this.Load += new System.EventHandler(this.FrmColaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgColaPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgPListo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgColaPedidos;
        private System.Windows.Forms.DataGridView DgPListo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}