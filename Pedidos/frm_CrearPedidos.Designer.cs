
namespace Pedidos
{
    partial class frm_CrearPedidos
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
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdDireccion = new System.Windows.Forms.TextBox();
            this.txtDireccionEnvio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.comboDirecciones = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboFabricas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumeroArticulo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.comboArticulos = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgvArticulos = new System.Windows.Forms.DataGridView();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_fabrica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Op = new System.Windows.Forms.DataGridViewButtonColumn();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.Enabled = false;
            this.dtpFechaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPedido.Location = new System.Drawing.Point(129, 26);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.Size = new System.Drawing.Size(210, 22);
            this.dtpFechaPedido.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha del pedido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // comboClientes
            // 
            this.comboClientes.Enabled = false;
            this.comboClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(62, 52);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(277, 24);
            this.comboClientes.TabIndex = 3;
            this.comboClientes.Text = "Seleccionar cliente";
            this.comboClientes.SelectionChangeCommitted += new System.EventHandler(this.comboClientes_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.comboDirecciones);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.txtIdDireccion);
            this.groupBox1.Controls.Add(this.txtDireccionEnvio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFechaPedido);
            this.groupBox1.Controls.Add(this.comboClientes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 110);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado del pedido";
            // 
            // txtIdDireccion
            // 
            this.txtIdDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDireccion.Location = new System.Drawing.Point(130, 82);
            this.txtIdDireccion.Name = "txtIdDireccion";
            this.txtIdDireccion.ReadOnly = true;
            this.txtIdDireccion.Size = new System.Drawing.Size(58, 22);
            this.txtIdDireccion.TabIndex = 6;
            // 
            // txtDireccionEnvio
            // 
            this.txtDireccionEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionEnvio.Location = new System.Drawing.Point(194, 82);
            this.txtDireccionEnvio.Name = "txtDireccionEnvio";
            this.txtDireccionEnvio.ReadOnly = true;
            this.txtDireccionEnvio.Size = new System.Drawing.Size(576, 22);
            this.txtDireccionEnvio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dirección de envio:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.comboFabricas);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboArticulos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 153);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle del pedido";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(679, 15);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(89, 31);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(584, 15);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 31);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(489, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 31);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // comboDirecciones
            // 
            this.comboDirecciones.Enabled = false;
            this.comboDirecciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDirecciones.FormattingEnabled = true;
            this.comboDirecciones.Location = new System.Drawing.Point(491, 53);
            this.comboDirecciones.Name = "comboDirecciones";
            this.comboDirecciones.Size = new System.Drawing.Size(277, 24);
            this.comboDirecciones.TabIndex = 10;
            this.comboDirecciones.Text = "Seleccionar dirección";
            this.comboDirecciones.SelectionChangeCommitted += new System.EventHandler(this.comboDirecciones_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Direcciones del cliente.";
            // 
            // comboFabricas
            // 
            this.comboFabricas.Enabled = false;
            this.comboFabricas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFabricas.FormattingEnabled = true;
            this.comboFabricas.Location = new System.Drawing.Point(147, 32);
            this.comboFabricas.Name = "comboFabricas";
            this.comboFabricas.Size = new System.Drawing.Size(167, 24);
            this.comboFabricas.TabIndex = 3;
            this.comboFabricas.Text = "Seleccione una fabrica";
            this.comboFabricas.SelectionChangeCommitted += new System.EventHandler(this.comboFabricas_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Seleccionar fabrica:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericCantidad);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.txtExistencia);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtNumeroArticulo);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtDescripcion);
            this.groupBox3.Location = new System.Drawing.Point(6, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(762, 85);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Existencia:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(382, 43);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 31);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar articulo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtExistencia
            // 
            this.txtExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExistencia.Location = new System.Drawing.Point(97, 47);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.ReadOnly = true;
            this.txtExistencia.Size = new System.Drawing.Size(65, 22);
            this.txtExistencia.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(479, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Número de articulo:";
            // 
            // txtNumeroArticulo
            // 
            this.txtNumeroArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroArticulo.Location = new System.Drawing.Point(609, 15);
            this.txtNumeroArticulo.Name = "txtNumeroArticulo";
            this.txtNumeroArticulo.ReadOnly = true;
            this.txtNumeroArticulo.Size = new System.Drawing.Size(147, 22);
            this.txtNumeroArticulo.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(97, 15);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(373, 22);
            this.txtDescripcion.TabIndex = 4;
            // 
            // comboArticulos
            // 
            this.comboArticulos.Enabled = false;
            this.comboArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboArticulos.FormattingEnabled = true;
            this.comboArticulos.Location = new System.Drawing.Point(459, 32);
            this.comboArticulos.Name = "comboArticulos";
            this.comboArticulos.Size = new System.Drawing.Size(303, 24);
            this.comboArticulos.TabIndex = 3;
            this.comboArticulos.Text = "Seleccione articulo";
            this.comboArticulos.SelectionChangeCommitted += new System.EventHandler(this.comboArticulos_SelectionChangeCommitted);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(320, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Seleccionar articulo:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgvArticulos);
            this.groupBox4.Location = new System.Drawing.Point(12, 287);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 225);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // dtgvArticulos
            // 
            this.dtgvArticulos.AllowUserToAddRows = false;
            this.dtgvArticulos.AllowUserToDeleteRows = false;
            this.dtgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion,
            this.id_fabrica,
            this.cantidad,
            this.numero_articulo,
            this.Op});
            this.dtgvArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvArticulos.Location = new System.Drawing.Point(3, 16);
            this.dtgvArticulos.Name = "dtgvArticulos";
            this.dtgvArticulos.ReadOnly = true;
            this.dtgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvArticulos.Size = new System.Drawing.Size(770, 206);
            this.dtgvArticulos.TabIndex = 0;
            this.dtgvArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvArticulos_CellClick);
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // id_fabrica
            // 
            this.id_fabrica.HeaderText = "id_fabrica";
            this.id_fabrica.Name = "id_fabrica";
            this.id_fabrica.ReadOnly = true;
            this.id_fabrica.Visible = false;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // numero_articulo
            // 
            this.numero_articulo.HeaderText = "Numero Articulo";
            this.numero_articulo.Name = "numero_articulo";
            this.numero_articulo.ReadOnly = true;
            // 
            // Op
            // 
            this.Op.HeaderText = "Op";
            this.Op.Name = "Op";
            this.Op.ReadOnly = true;
            // 
            // numericCantidad
            // 
            this.numericCantidad.Enabled = false;
            this.numericCantidad.Location = new System.Drawing.Point(256, 48);
            this.numericCantidad.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(120, 22);
            this.numericCantidad.TabIndex = 12;
            // 
            // frm_CrearPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frm_CrearPedidos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear pedidos.";
            this.Load += new System.EventHandler(this.frm_CrearPedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdDireccion;
        private System.Windows.Forms.TextBox txtDireccionEnvio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox comboDirecciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboFabricas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumeroArticulo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox comboArticulos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgvArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fabrica;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_articulo;
        private System.Windows.Forms.DataGridViewButtonColumn Op;
        private System.Windows.Forms.NumericUpDown numericCantidad;
    }
}