
namespace Pedidos
{
    partial class frm_AdministrarPedidos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCrearPedido = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgPedidos = new System.Windows.Forms.DataGridView();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVerDetalles);
            this.groupBox1.Controls.Add(this.btnCrearPedido);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnCrearPedido
            // 
            this.btnCrearPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPedido.Location = new System.Drawing.Point(262, 19);
            this.btnCrearPedido.Name = "btnCrearPedido";
            this.btnCrearPedido.Size = new System.Drawing.Size(103, 33);
            this.btnCrearPedido.TabIndex = 0;
            this.btnCrearPedido.Text = "Crear pedido";
            this.btnCrearPedido.UseVisualStyleBackColor = true;
            this.btnCrearPedido.Click += new System.EventHandler(this.btnCrearPedido_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgPedidos);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 369);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dtgPedidos
            // 
            this.dtgPedidos.AllowUserToAddRows = false;
            this.dtgPedidos.AllowUserToDeleteRows = false;
            this.dtgPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPedidos.Location = new System.Drawing.Point(3, 16);
            this.dtgPedidos.Name = "dtgPedidos";
            this.dtgPedidos.ReadOnly = true;
            this.dtgPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPedidos.Size = new System.Drawing.Size(770, 350);
            this.dtgPedidos.TabIndex = 0;
            this.dtgPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPedidos_CellDoubleClick);
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.Enabled = false;
            this.btnVerDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalles.Location = new System.Drawing.Point(371, 19);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(103, 33);
            this.btnVerDetalles.TabIndex = 1;
            this.btnVerDetalles.Text = "Ver detalles";
            this.btnVerDetalles.UseVisualStyleBackColor = true;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // frm_AdministrarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AdministrarPedidos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar pedidos";
            this.Load += new System.EventHandler(this.frm_AdministrarPedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCrearPedido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgPedidos;
        private System.Windows.Forms.Button btnVerDetalles;
    }
}