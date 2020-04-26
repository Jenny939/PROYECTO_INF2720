namespace Taller.Vista
{
    partial class MdiOperador
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnReservacion = new System.Windows.Forms.Button();
            this.btnReporteVentas = new System.Windows.Forms.Button();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(168)))), ((int)(((byte)(227)))));
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.btnCliente);
            this.flowLayoutPanel1.Controls.Add(this.btnVenta);
            this.flowLayoutPanel1.Controls.Add(this.btnReservacion);
            this.flowLayoutPanel1.Controls.Add(this.btnReporteVentas);
            this.flowLayoutPanel1.Controls.Add(this.btnCuenta);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1008, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 97);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(111, 3);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(99, 97);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "CLIENTES";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(216, 3);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(99, 97);
            this.btnVenta.TabIndex = 3;
            this.btnVenta.Text = "VENTAS";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnReservacion
            // 
            this.btnReservacion.Location = new System.Drawing.Point(321, 3);
            this.btnReservacion.Name = "btnReservacion";
            this.btnReservacion.Size = new System.Drawing.Size(113, 97);
            this.btnReservacion.TabIndex = 4;
            this.btnReservacion.Text = "RESERVACIONES";
            this.btnReservacion.UseVisualStyleBackColor = true;
            // 
            // btnReporteVentas
            // 
            this.btnReporteVentas.Location = new System.Drawing.Point(440, 3);
            this.btnReporteVentas.Name = "btnReporteVentas";
            this.btnReporteVentas.Size = new System.Drawing.Size(99, 97);
            this.btnReporteVentas.TabIndex = 5;
            this.btnReporteVentas.Text = "REPORTE VENTAS";
            this.btnReporteVentas.UseVisualStyleBackColor = true;
            // 
            // btnCuenta
            // 
            this.btnCuenta.Location = new System.Drawing.Point(545, 3);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(99, 97);
            this.btnCuenta.TabIndex = 6;
            this.btnCuenta.Text = "MI CUENTA";
            this.btnCuenta.UseVisualStyleBackColor = true;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 100);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1008, 518);
            this.panelContenedor.TabIndex = 1;
            // 
            // MdiOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 618);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MdiOperador";
            this.Text = "MdiOperador";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnReservacion;
        private System.Windows.Forms.Button btnReporteVentas;
        private System.Windows.Forms.Button btnCuenta;
    }
}