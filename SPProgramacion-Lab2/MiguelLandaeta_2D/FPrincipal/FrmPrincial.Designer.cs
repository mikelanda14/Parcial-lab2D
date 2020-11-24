namespace FPrincipal
{
    partial class FrmPrincial
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
            this.DgProductos = new System.Windows.Forms.DataGridView();
            this.DgVenta = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // DgProductos
            // 
            this.DgProductos.AllowUserToAddRows = false;
            this.DgProductos.AllowUserToDeleteRows = false;
            this.DgProductos.AllowUserToResizeColumns = false;
            this.DgProductos.AllowUserToResizeRows = false;
            this.DgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgProductos.Location = new System.Drawing.Point(12, 47);
            this.DgProductos.Name = "DgProductos";
            this.DgProductos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DgProductos.Size = new System.Drawing.Size(323, 342);
            this.DgProductos.TabIndex = 0;
            this.DgProductos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgProductos_CellContentClick);
            // 
            // DgVenta
            // 
            this.DgVenta.AllowUserToAddRows = false;
            this.DgVenta.AllowUserToDeleteRows = false;
            this.DgVenta.AllowUserToResizeColumns = false;
            this.DgVenta.AllowUserToResizeRows = false;
            this.DgVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgVenta.Enabled = false;
            this.DgVenta.Location = new System.Drawing.Point(390, 47);
            this.DgVenta.Name = "DgVenta";
            this.DgVenta.Size = new System.Drawing.Size(323, 342);
            this.DgVenta.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cobrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total A Pagar:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(696, 405);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 16);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "0";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(436, 439);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(436, 465);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Envio";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre Del Cliente";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(152, 439);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(206, 61);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Menu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Venta Actual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(192, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Detalles de envio";
            // 
            // FrmPrincial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 511);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DgVenta);
            this.Controls.Add(this.DgProductos);
            this.Location = new System.Drawing.Point(800, 0);
            this.Name = "FrmPrincial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Miguel.Landaeta 2C ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgProductos;
        private System.Windows.Forms.DataGridView DgVenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

