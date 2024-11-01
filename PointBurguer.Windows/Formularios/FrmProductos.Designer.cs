namespace PointBurguer.Windows.Formularios
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            panel1 = new Panel();
            panel3 = new Panel();
            btnUltimo = new Button();
            btnSiguiente = new Button();
            txtCantidadPaginas = new TextBox();
            btnAnterior = new Button();
            label2 = new Label();
            btnPrimero = new Button();
            label1 = new Label();
            cboPaginas = new ComboBox();
            dgvDatos = new DataGridView();
            ProductoId = new DataGridViewTextBoxColumn();
            ColCategoriaId = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColDescripcion = new DataGridViewTextBoxColumn();
            ColPrecioCosto = new DataGridViewTextBoxColumn();
            ColPrecioVenta = new DataGridViewTextBoxColumn();
            ColStock = new DataGridViewTextBoxColumn();
            btnFiltrar = new Button();
            btnOrdenar = new Button();
            btnCerrar = new PictureBox();
            btnEditar = new Button();
            btnAgregar = new Button();
            btnBorrar = new Button();
            panel2 = new Panel();
            btnActualizar = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dgvDatos);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 490);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleGreen;
            panel3.Controls.Add(btnUltimo);
            panel3.Controls.Add(btnSiguiente);
            panel3.Controls.Add(txtCantidadPaginas);
            panel3.Controls.Add(btnAnterior);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btnPrimero);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cboPaginas);
            panel3.Location = new Point(0, 443);
            panel3.Name = "panel3";
            panel3.Size = new Size(799, 47);
            panel3.TabIndex = 2;
            // 
            // btnUltimo
            // 
            btnUltimo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUltimo.Cursor = Cursors.Hand;
            btnUltimo.Image = (Image)resources.GetObject("btnUltimo.Image");
            btnUltimo.Location = new Point(392, 3);
            btnUltimo.Margin = new Padding(3, 4, 3, 4);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(50, 40);
            btnUltimo.TabIndex = 5;
            btnUltimo.UseVisualStyleBackColor = true;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSiguiente.Cursor = Cursors.Hand;
            btnSiguiente.Image = (Image)resources.GetObject("btnSiguiente.Image");
            btnSiguiente.Location = new Point(341, 3);
            btnSiguiente.Margin = new Padding(3, 4, 3, 4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(50, 40);
            btnSiguiente.TabIndex = 6;
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // txtCantidadPaginas
            // 
            txtCantidadPaginas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCantidadPaginas.Location = new Point(154, 16);
            txtCantidadPaginas.Margin = new Padding(3, 4, 3, 4);
            txtCantidadPaginas.Name = "txtCantidadPaginas";
            txtCantidadPaginas.ReadOnly = true;
            txtCantidadPaginas.Size = new Size(69, 27);
            txtCantidadPaginas.TabIndex = 10;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAnterior.Cursor = Cursors.Hand;
            btnAnterior.Image = (Image)resources.GetObject("btnAnterior.Image");
            btnAnterior.Location = new Point(289, 3);
            btnAnterior.Margin = new Padding(3, 4, 3, 4);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(50, 40);
            btnAnterior.TabIndex = 7;
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(116, 19);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 11;
            label2.Text = "De:";
            // 
            // btnPrimero
            // 
            btnPrimero.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPrimero.Cursor = Cursors.Hand;
            btnPrimero.Image = (Image)resources.GetObject("btnPrimero.Image");
            btnPrimero.Location = new Point(238, 3);
            btnPrimero.Margin = new Padding(3, 4, 3, 4);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(50, 40);
            btnPrimero.TabIndex = 8;
            btnPrimero.UseVisualStyleBackColor = true;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 12;
            label1.Text = "Pag.:";
            // 
            // cboPaginas
            // 
            cboPaginas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboPaginas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaginas.FormattingEnabled = true;
            cboPaginas.Location = new Point(52, 13);
            cboPaginas.Margin = new Padding(3, 4, 3, 4);
            cboPaginas.Name = "cboPaginas";
            cboPaginas.Size = new Size(58, 28);
            cboPaginas.TabIndex = 9;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.AllowUserToResizeColumns = false;
            dgvDatos.AllowUserToResizeRows = false;
            dgvDatos.BackgroundColor = Color.PaleGreen;
            dgvDatos.BorderStyle = BorderStyle.None;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ProductoId, ColCategoriaId, ColNombre, ColDescripcion, ColPrecioCosto, ColPrecioVenta, ColStock });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.GridColor = Color.Black;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(799, 490);
            dgvDatos.TabIndex = 1;
            // 
            // ProductoId
            // 
            ProductoId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductoId.HeaderText = "ID";
            ProductoId.MinimumWidth = 6;
            ProductoId.Name = "ProductoId";
            ProductoId.ReadOnly = true;
            ProductoId.Resizable = DataGridViewTriState.False;
            ProductoId.SortMode = DataGridViewColumnSortMode.NotSortable;
            ProductoId.Visible = false;
            // 
            // ColCategoriaId
            // 
            ColCategoriaId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCategoriaId.HeaderText = "Categoria";
            ColCategoriaId.MinimumWidth = 6;
            ColCategoriaId.Name = "ColCategoriaId";
            ColCategoriaId.ReadOnly = true;
            ColCategoriaId.Resizable = DataGridViewTriState.False;
            ColCategoriaId.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColNombre
            // 
            ColNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNombre.HeaderText = "Nombre";
            ColNombre.MinimumWidth = 6;
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            ColNombre.Resizable = DataGridViewTriState.False;
            ColNombre.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColDescripcion
            // 
            ColDescripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColDescripcion.HeaderText = "Descripcion";
            ColDescripcion.MinimumWidth = 6;
            ColDescripcion.Name = "ColDescripcion";
            ColDescripcion.ReadOnly = true;
            ColDescripcion.Resizable = DataGridViewTriState.False;
            ColDescripcion.SortMode = DataGridViewColumnSortMode.Programmatic;
            ColDescripcion.Visible = false;
            // 
            // ColPrecioCosto
            // 
            ColPrecioCosto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColPrecioCosto.HeaderText = "Precio Costo";
            ColPrecioCosto.MinimumWidth = 6;
            ColPrecioCosto.Name = "ColPrecioCosto";
            ColPrecioCosto.ReadOnly = true;
            ColPrecioCosto.Resizable = DataGridViewTriState.False;
            ColPrecioCosto.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColPrecioVenta
            // 
            ColPrecioVenta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColPrecioVenta.HeaderText = "Precio Venta";
            ColPrecioVenta.MinimumWidth = 6;
            ColPrecioVenta.Name = "ColPrecioVenta";
            ColPrecioVenta.ReadOnly = true;
            ColPrecioVenta.Resizable = DataGridViewTriState.False;
            ColPrecioVenta.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColStock
            // 
            ColStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColStock.HeaderText = "Stock";
            ColStock.MinimumWidth = 6;
            ColStock.Name = "ColStock";
            ColStock.ReadOnly = true;
            ColStock.Resizable = DataGridViewTriState.False;
            ColStock.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // btnFiltrar
            // 
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.Image = (Image)resources.GetObject("btnFiltrar.Image");
            btnFiltrar.Location = new Point(0, 306);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(163, 70);
            btnFiltrar.TabIndex = 18;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.FlatStyle = FlatStyle.Flat;
            btnOrdenar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrdenar.Image = (Image)resources.GetObject("btnOrdenar.Image");
            btnOrdenar.Location = new Point(0, 240);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(163, 70);
            btnOrdenar.TabIndex = 17;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrdenar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(118, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(45, 37);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 13;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(0, 174);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(163, 70);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.PaleGreen;
            btnAgregar.BackgroundImageLayout = ImageLayout.None;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(0, 42);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(163, 70);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.PaleGreen;
            btnBorrar.BackgroundImageLayout = ImageLayout.None;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.Image = (Image)resources.GetObject("btnBorrar.Image");
            btnBorrar.Location = new Point(0, 108);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(163, 70);
            btnBorrar.TabIndex = 15;
            btnBorrar.Text = "Borrar";
            btnBorrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnActualizar);
            panel2.Controls.Add(btnFiltrar);
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(btnOrdenar);
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnBorrar);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(799, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(163, 490);
            panel2.TabIndex = 1;
            // 
            // btnActualizar
            // 
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Image = (Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.Location = new Point(0, 372);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(163, 70);
            btnActualizar.TabIndex = 25;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(962, 490);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProductos";
            Text = "FrmProductos";
            Load += FrmProductos_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnFiltrar;
        private Button btnOrdenar;
        private PictureBox btnCerrar;
        private Button btnEditar;
        private Button btnAgregar;
        private Button btnBorrar;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn ProductoId;
        private DataGridViewTextBoxColumn ColCategoriaId;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColDescripcion;
        private DataGridViewTextBoxColumn ColPrecioCosto;
        private DataGridViewTextBoxColumn ColPrecioVenta;
        private DataGridViewTextBoxColumn ColStock;
        private Panel panel3;
        private Button btnUltimo;
        private Button btnSiguiente;
        private TextBox txtCantidadPaginas;
        private Button btnAnterior;
        private Label label2;
        private Button btnPrimero;
        private Label label1;
        private ComboBox cboPaginas;
        private Button btnActualizar;
    }
}