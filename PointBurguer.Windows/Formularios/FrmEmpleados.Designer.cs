namespace PointBurguer.Windows.Formularios
{
    partial class FrmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleados));
            panel1 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            btnUltimo = new Button();
            btnSiguiente = new Button();
            button2 = new Button();
            txtCantidadPaginas = new TextBox();
            textBox1 = new TextBox();
            btnAnterior = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            btnPrimero = new Button();
            button4 = new Button();
            label1 = new Label();
            label4 = new Label();
            cboPaginas = new ComboBox();
            comboBox1 = new ComboBox();
            dgvDatos = new DataGridView();
            EmpleadoId = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColDescripcion = new DataGridViewTextBoxColumn();
            ColCategoriaId = new DataGridViewTextBoxColumn();
            ColPrecioCosto = new DataGridViewTextBoxColumn();
            ColPrecioVenta = new DataGridViewTextBoxColumn();
            ColStock = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnActualizar = new Button();
            btnFiltrar = new Button();
            btnAgregar = new Button();
            btnCerrar = new PictureBox();
            btnBorrar = new Button();
            btnOrdenar = new Button();
            btnEditar = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
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
            panel3.Controls.Add(button1);
            panel3.Controls.Add(btnUltimo);
            panel3.Controls.Add(btnSiguiente);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(txtCantidadPaginas);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(btnAnterior);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnPrimero);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(cboPaginas);
            panel3.Controls.Add(comboBox1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 443);
            panel3.Name = "panel3";
            panel3.Size = new Size(799, 47);
            panel3.TabIndex = 21;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Cursor = Cursors.Hand;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(392, -50);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(649, 40);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnUltimo
            // 
            btnUltimo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUltimo.Cursor = Cursors.Hand;
            btnUltimo.Image = (Image)resources.GetObject("btnUltimo.Image");
            btnUltimo.Location = new Point(390, 3);
            btnUltimo.Margin = new Padding(3, 4, 3, 4);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(50, 40);
            btnUltimo.TabIndex = 13;
            btnUltimo.UseVisualStyleBackColor = true;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSiguiente.Cursor = Cursors.Hand;
            btnSiguiente.Image = (Image)resources.GetObject("btnSiguiente.Image");
            btnSiguiente.Location = new Point(339, 3);
            btnSiguiente.Margin = new Padding(3, 4, 3, 4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(50, 40);
            btnSiguiente.TabIndex = 14;
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Cursor = Cursors.Hand;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(341, -50);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(649, 40);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = true;
            // 
            // txtCantidadPaginas
            // 
            txtCantidadPaginas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCantidadPaginas.Location = new Point(152, 16);
            txtCantidadPaginas.Margin = new Padding(3, 4, 3, 4);
            txtCantidadPaginas.Name = "txtCantidadPaginas";
            txtCantidadPaginas.ReadOnly = true;
            txtCantidadPaginas.Size = new Size(69, 27);
            txtCantidadPaginas.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(154, -37);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(668, 27);
            textBox1.TabIndex = 10;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAnterior.Cursor = Cursors.Hand;
            btnAnterior.Image = (Image)resources.GetObject("btnAnterior.Image");
            btnAnterior.Location = new Point(287, 3);
            btnAnterior.Margin = new Padding(3, 4, 3, 4);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(50, 40);
            btnAnterior.TabIndex = 15;
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Cursor = Cursors.Hand;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(289, -50);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(649, 40);
            button3.TabIndex = 7;
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(114, 19);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 19;
            label2.Text = "De:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(116, -34);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 11;
            label3.Text = "De:";
            // 
            // btnPrimero
            // 
            btnPrimero.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPrimero.Cursor = Cursors.Hand;
            btnPrimero.Image = (Image)resources.GetObject("btnPrimero.Image");
            btnPrimero.Location = new Point(236, 3);
            btnPrimero.Margin = new Padding(3, 4, 3, 4);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(50, 40);
            btnPrimero.TabIndex = 16;
            btnPrimero.UseVisualStyleBackColor = true;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.Cursor = Cursors.Hand;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(238, -50);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(649, 40);
            button4.TabIndex = 8;
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(1, 18);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 20;
            label1.Text = "Pag.:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(3, -35);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 12;
            label4.Text = "Pag.:";
            // 
            // cboPaginas
            // 
            cboPaginas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboPaginas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaginas.FormattingEnabled = true;
            cboPaginas.Location = new Point(50, 13);
            cboPaginas.Margin = new Padding(3, 4, 3, 4);
            cboPaginas.Name = "cboPaginas";
            cboPaginas.Size = new Size(58, 28);
            cboPaginas.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(52, -40);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(657, 28);
            comboBox1.TabIndex = 9;
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
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { EmpleadoId, ColNombre, ColDescripcion, ColCategoriaId, ColPrecioCosto, ColPrecioVenta, ColStock });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.GridColor = Color.Black;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(799, 490);
            dgvDatos.TabIndex = 2;
            // 
            // EmpleadoId
            // 
            EmpleadoId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmpleadoId.HeaderText = "ID";
            EmpleadoId.MinimumWidth = 6;
            EmpleadoId.Name = "EmpleadoId";
            EmpleadoId.ReadOnly = true;
            EmpleadoId.Resizable = DataGridViewTriState.False;
            EmpleadoId.SortMode = DataGridViewColumnSortMode.NotSortable;
            EmpleadoId.Visible = false;
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
            ColDescripcion.HeaderText = "Apellido";
            ColDescripcion.MinimumWidth = 6;
            ColDescripcion.Name = "ColDescripcion";
            ColDescripcion.ReadOnly = true;
            ColDescripcion.Resizable = DataGridViewTriState.False;
            ColDescripcion.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // ColCategoriaId
            // 
            ColCategoriaId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCategoriaId.HeaderText = "Salario";
            ColCategoriaId.MinimumWidth = 6;
            ColCategoriaId.Name = "ColCategoriaId";
            ColCategoriaId.ReadOnly = true;
            ColCategoriaId.Resizable = DataGridViewTriState.False;
            ColCategoriaId.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColPrecioCosto
            // 
            ColPrecioCosto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColPrecioCosto.HeaderText = "Telefono";
            ColPrecioCosto.MinimumWidth = 6;
            ColPrecioCosto.Name = "ColPrecioCosto";
            ColPrecioCosto.ReadOnly = true;
            ColPrecioCosto.Resizable = DataGridViewTriState.False;
            ColPrecioCosto.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColPrecioVenta
            // 
            ColPrecioVenta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColPrecioVenta.HeaderText = "FechaNacimiento";
            ColPrecioVenta.MinimumWidth = 6;
            ColPrecioVenta.Name = "ColPrecioVenta";
            ColPrecioVenta.ReadOnly = true;
            ColPrecioVenta.Resizable = DataGridViewTriState.False;
            ColPrecioVenta.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColStock
            // 
            ColStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColStock.HeaderText = "Comision";
            ColStock.MinimumWidth = 6;
            ColStock.Name = "ColStock";
            ColStock.ReadOnly = true;
            ColStock.Resizable = DataGridViewTriState.False;
            ColStock.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnActualizar);
            panel2.Controls.Add(btnFiltrar);
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(btnBorrar);
            panel2.Controls.Add(btnOrdenar);
            panel2.Controls.Add(btnEditar);
            panel2.Dock = DockStyle.Right;
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
            btnActualizar.TabIndex = 24;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.Image = (Image)resources.GetObject("btnFiltrar.Image");
            btnFiltrar.Location = new Point(0, 306);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(163, 70);
            btnFiltrar.TabIndex = 24;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
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
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(118, -1);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(45, 37);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 19;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
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
            btnBorrar.TabIndex = 21;
            btnBorrar.Text = "Borrar";
            btnBorrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.FlatStyle = FlatStyle.Flat;
            btnOrdenar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrdenar.Image = (Image)resources.GetObject("btnOrdenar.Image");
            btnOrdenar.Location = new Point(0, 240);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(163, 70);
            btnOrdenar.TabIndex = 23;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrdenar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(0, 174);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(163, 70);
            btnEditar.TabIndex = 22;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // FrmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(962, 490);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEmpleados";
            Text = "FrmEmpleados";
            Load += FrmEmpleados_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnFiltrar;
        private Button btnAgregar;
        private PictureBox btnCerrar;
        private Button btnBorrar;
        private Button btnOrdenar;
        private Button btnEditar;
        private DataGridView dgvDatos;
        private Button btnUltimo;
        private Button btnSiguiente;
        private TextBox txtCantidadPaginas;
        private Button btnAnterior;
        private Label label2;
        private Button btnPrimero;
        private Label label1;
        private ComboBox cboPaginas;
        private Panel panel3;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private Label label3;
        private Button button4;
        private Label label4;
        private ComboBox comboBox1;
        private Button btnActualizar;
        private DataGridViewTextBoxColumn EmpleadoId;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColDescripcion;
        private DataGridViewTextBoxColumn ColCategoriaId;
        private DataGridViewTextBoxColumn ColPrecioCosto;
        private DataGridViewTextBoxColumn ColPrecioVenta;
        private DataGridViewTextBoxColumn ColStock;
    }
}