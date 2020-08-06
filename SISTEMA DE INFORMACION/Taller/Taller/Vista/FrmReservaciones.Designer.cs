namespace Taller.Vista
{
    partial class FrmReservaciones
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbRampa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.dateTimePickerReservar = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.dgReservacion = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rampa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerVerReservas = new System.Windows.Forms.DateTimePicker();
            this.btnListarReservas = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(29, 232);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(22, 18);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "CI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(293, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "NOMBRE CLIENTE:";
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCrearCliente.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCliente.Location = new System.Drawing.Point(822, 231);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Size = new System.Drawing.Size(117, 31);
            this.btnCrearCliente.TabIndex = 14;
            this.btnCrearCliente.Text = "NUEVO CLIENTE";
            this.btnCrearCliente.UseVisualStyleBackColor = false;
            this.btnCrearCliente.Click += new System.EventHandler(this.btnCrearCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(418, 233);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(387, 25);
            this.txtCliente.TabIndex = 13;
            // 
            // txtCI
            // 
            this.txtCI.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCI.Location = new System.Drawing.Point(66, 229);
            this.txtCI.MaxLength = 9;
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(100, 25);
            this.txtCI.TabIndex = 12;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBuscar.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(190, 229);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 31);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbRampa
            // 
            this.cmbRampa.FormattingEnabled = true;
            this.cmbRampa.Location = new System.Drawing.Point(159, 284);
            this.cmbRampa.Name = "cmbRampa";
            this.cmbRampa.Size = new System.Drawing.Size(115, 21);
            this.cmbRampa.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "SELECCIONE LA RAMPA:";
            // 
            // cmbHora
            // 
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "08:00:00",
            "08:30:00",
            "09:00:00",
            "09:30:00",
            "10:00:00",
            "10:30:00",
            "11:00:00",
            "11:30:00",
            "12:00:00",
            "12:30:00",
            "13:00:00",
            "13:30:00",
            "14:00:00",
            "14:30:00",
            "15:00:00",
            "15:30:00",
            "16:00:00",
            "16:30:00",
            "17:00:00",
            "17:30:00"});
            this.cmbHora.Location = new System.Drawing.Point(822, 285);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(117, 21);
            this.cmbHora.TabIndex = 18;
            // 
            // dateTimePickerReservar
            // 
            this.dateTimePickerReservar.Location = new System.Drawing.Point(418, 286);
            this.dateTimePickerReservar.Name = "dateTimePickerReservar";
            this.dateTimePickerReservar.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReservar.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(293, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "SELECCIONE LA FECHA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(689, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "SELECCIONE LA HORA:";
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReservar.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(822, 321);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(117, 31);
            this.btnReservar.TabIndex = 22;
            this.btnReservar.Text = "RESERVAR";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // dgReservacion
            // 
            this.dgReservacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Cliente,
            this.Rampa,
            this.Horario,
            this.Fecha,
            this.Observaciones});
            this.dgReservacion.Location = new System.Drawing.Point(252, 78);
            this.dgReservacion.MultiSelect = false;
            this.dgReservacion.Name = "dgReservacion";
            this.dgReservacion.ReadOnly = true;
            this.dgReservacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReservacion.Size = new System.Drawing.Size(593, 115);
            this.dgReservacion.TabIndex = 23;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 120;
            // 
            // Rampa
            // 
            this.Rampa.HeaderText = "Rampa";
            this.Rampa.Name = "Rampa";
            this.Rampa.ReadOnly = true;
            this.Rampa.Width = 80;
            // 
            // Horario
            // 
            this.Horario.HeaderText = "Horario";
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            this.Horario.Width = 80;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 80;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Width = 150;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(413, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "RESERVACIONES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(916, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "REALIZAR RESERVA ----------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "------------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(29, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(915, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "VER RESERVAS --------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "------------------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(29, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "SELECCIONE LA FECHA:";
            // 
            // dateTimePickerVerReservas
            // 
            this.dateTimePickerVerReservas.Location = new System.Drawing.Point(32, 120);
            this.dateTimePickerVerReservas.Name = "dateTimePickerVerReservas";
            this.dateTimePickerVerReservas.Size = new System.Drawing.Size(203, 20);
            this.dateTimePickerVerReservas.TabIndex = 28;
            // 
            // btnListarReservas
            // 
            this.btnListarReservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnListarReservas.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarReservas.Location = new System.Drawing.Point(32, 146);
            this.btnListarReservas.Name = "btnListarReservas";
            this.btnListarReservas.Size = new System.Drawing.Size(203, 31);
            this.btnListarReservas.TabIndex = 29;
            this.btnListarReservas.Text = "LISTAR RESERVAS";
            this.btnListarReservas.UseVisualStyleBackColor = false;
            this.btnListarReservas.Click += new System.EventHandler(this.btnListarReservas_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(29, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "OBSERVACIONES:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(159, 321);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(646, 20);
            this.txtObservacion.TabIndex = 31;
            this.txtObservacion.Text = "Ninguna";
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancelarReserva.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarReserva.Location = new System.Drawing.Point(851, 78);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(88, 115);
            this.btnCancelarReserva.TabIndex = 32;
            this.btnCancelarReserva.Text = "CANCELAR RESERVA";
            this.btnCancelarReserva.UseVisualStyleBackColor = false;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // FrmReservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(960, 404);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnListarReservas);
            this.Controls.Add(this.dateTimePickerVerReservas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgReservacion);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerReservar);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRampa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCrearCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReservaciones";
            this.Text = "FrmReservaciones";
            this.Load += new System.EventHandler(this.FrmReservaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgReservacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCrearCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbRampa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.DateTimePicker dateTimePickerReservar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.DataGridView dgReservacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerVerReservas;
        private System.Windows.Forms.Button btnListarReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rampa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Button btnCancelarReserva;
    }
}