namespace SlnStore.Desktop
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrecio = new System.Windows.Forms.NumericUpDown();
            this.txtStock = new System.Windows.Forms.NumericUpDown();
            this.dtExpira = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(6, 210);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Guardar";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(84, 210);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Actualizar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(163, 210);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(145, 15);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modulo Productos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtExpira);
            this.panel1.Controls.Add(this.txtStock);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 247);
            this.panel1.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(145, 56);
            this.txtPrecio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(143, 20);
            this.txtPrecio.TabIndex = 3;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(145, 98);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(143, 20);
            this.txtStock.TabIndex = 4;
            // 
            // dtExpira
            // 
            this.dtExpira.Location = new System.Drawing.Point(51, 157);
            this.dtExpira.Name = "dtExpira";
            this.dtExpira.Size = new System.Drawing.Size(237, 20);
            this.dtExpira.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio Unitario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha de Expiración:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(244, 210);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgProduct
            // 
            this.dgProduct.AllowUserToDeleteRows = false;
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduct,
            this.NameProduct,
            this.PriceUnit,
            this.Stock,
            this.ExpirationDate});
            this.dgProduct.Location = new System.Drawing.Point(343, 44);
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.ReadOnly = true;
            this.dgProduct.Size = new System.Drawing.Size(442, 247);
            this.dgProduct.TabIndex = 5;
            this.dgProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduct_CellContentClick);
            this.dgProduct.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduct_CellContentDoubleClick);
            this.dgProduct.DoubleClick += new System.EventHandler(this.dgProduct_DoubleClick);
            // 
            // IdProduct
            // 
            this.IdProduct.DataPropertyName = "IdProduct";
            this.IdProduct.HeaderText = "IdProduct";
            this.IdProduct.Name = "IdProduct";
            this.IdProduct.ReadOnly = true;
            this.IdProduct.Visible = false;
            // 
            // NameProduct
            // 
            this.NameProduct.DataPropertyName = "NameProduct";
            this.NameProduct.HeaderText = "NameProduct";
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            // 
            // PriceUnit
            // 
            this.PriceUnit.DataPropertyName = "PriceUnit";
            this.PriceUnit.HeaderText = "PriceUnit";
            this.PriceUnit.Name = "PriceUnit";
            this.PriceUnit.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.DataPropertyName = "ExpirationDate";
            this.ExpirationDate.HeaderText = "ExpirationDate";
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 303);
            this.Controls.Add(this.dgProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtExpira;
        private System.Windows.Forms.NumericUpDown txtStock;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
    }
}

