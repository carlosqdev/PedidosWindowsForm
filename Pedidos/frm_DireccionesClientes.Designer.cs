
namespace Pedidos
{
    partial class frm_DireccionesClientes
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
            this.groupBoxDirecciones = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtDistrito = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgDirecciones = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDirecciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDirecciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDirecciones
            // 
            this.groupBoxDirecciones.Controls.Add(this.txtDistrito);
            this.groupBoxDirecciones.Controls.Add(this.label7);
            this.groupBoxDirecciones.Controls.Add(this.txtBarrio);
            this.groupBoxDirecciones.Controls.Add(this.label6);
            this.groupBoxDirecciones.Controls.Add(this.txtCalle);
            this.groupBoxDirecciones.Controls.Add(this.label1);
            this.groupBoxDirecciones.Controls.Add(this.dtgDirecciones);
            this.groupBoxDirecciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDirecciones.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDirecciones.Name = "groupBoxDirecciones";
            this.groupBoxDirecciones.Size = new System.Drawing.Size(529, 301);
            this.groupBoxDirecciones.TabIndex = 3;
            this.groupBoxDirecciones.TabStop = false;
            this.groupBoxDirecciones.Text = "Direcciones de envios";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(146, 320);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(83, 39);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtDistrito
            // 
            this.txtDistrito.Enabled = false;
            this.txtDistrito.Location = new System.Drawing.Point(71, 77);
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.Size = new System.Drawing.Size(451, 22);
            this.txtDistrito.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Distrito";
            // 
            // txtBarrio
            // 
            this.txtBarrio.Enabled = false;
            this.txtBarrio.Location = new System.Drawing.Point(71, 49);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(451, 22);
            this.txtBarrio.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Barrio";
            // 
            // txtCalle
            // 
            this.txtCalle.Enabled = false;
            this.txtCalle.Location = new System.Drawing.Point(71, 21);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(451, 22);
            this.txtCalle.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Calle:";
            // 
            // dtgDirecciones
            // 
            this.dtgDirecciones.AllowUserToAddRows = false;
            this.dtgDirecciones.AllowUserToDeleteRows = false;
            this.dtgDirecciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDirecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDirecciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calle,
            this.barrio,
            this.distrito,
            this.id_direccion});
            this.dtgDirecciones.Location = new System.Drawing.Point(6, 105);
            this.dtgDirecciones.Name = "dtgDirecciones";
            this.dtgDirecciones.ReadOnly = true;
            this.dtgDirecciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDirecciones.Size = new System.Drawing.Size(516, 190);
            this.dtgDirecciones.TabIndex = 0;
            this.dtgDirecciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDirecciones_CellDoubleClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(233, 320);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 39);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(322, 320);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 39);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // calle
            // 
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            // 
            // barrio
            // 
            this.barrio.HeaderText = "Barrio";
            this.barrio.Name = "barrio";
            this.barrio.ReadOnly = true;
            // 
            // distrito
            // 
            this.distrito.HeaderText = "Distrito";
            this.distrito.Name = "distrito";
            this.distrito.ReadOnly = true;
            // 
            // id_direccion
            // 
            this.id_direccion.HeaderText = "id_direccion";
            this.id_direccion.Name = "id_direccion";
            this.id_direccion.ReadOnly = true;
            this.id_direccion.Visible = false;
            // 
            // frm_DireccionesClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 371);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBoxDirecciones);
            this.Name = "frm_DireccionesClientes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Direcciones clientes";
            this.Load += new System.EventHandler(this.frm_DireccionesClientes_Load);
            this.groupBoxDirecciones.ResumeLayout(false);
            this.groupBoxDirecciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDirecciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDirecciones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtDistrito;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgDirecciones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn distrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_direccion;
    }
}