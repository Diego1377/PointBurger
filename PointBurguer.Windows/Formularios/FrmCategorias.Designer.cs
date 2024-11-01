namespace PointBurguer.Windows.Formularios
{
    partial class FrmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategorias));
            panel1 = new Panel();
            dgvDatos = new DataGridView();
            ColNombre = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnCerrar = new PictureBox();
            btnAgregar = new Button();
            btnOrdenar = new Button();
            btnBorrar = new Button();
            btnEditar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvDatos);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 490);
            panel1.TabIndex = 0;
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
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColNombre });
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
            // panel2
            // 
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(btnOrdenar);
            panel2.Controls.Add(btnBorrar);
            panel2.Controls.Add(btnEditar);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(799, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(163, 490);
            panel2.TabIndex = 1;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(118, 1);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(45, 37);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 18;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.PaleGreen;
            btnAgregar.BackgroundImageLayout = ImageLayout.None;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(0, 61);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(163, 76);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.FlatStyle = FlatStyle.Flat;
            btnOrdenar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrdenar.Image = (Image)resources.GetObject("btnOrdenar.Image");
            btnOrdenar.Location = new Point(0, 307);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(163, 76);
            btnOrdenar.TabIndex = 22;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrdenar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.PaleGreen;
            btnBorrar.BackgroundImageLayout = ImageLayout.None;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.Image = (Image)resources.GetObject("btnBorrar.Image");
            btnBorrar.Location = new Point(0, 143);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(163, 76);
            btnBorrar.TabIndex = 20;
            btnBorrar.Text = "Borrar";
            btnBorrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(0, 225);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(163, 76);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(962, 490);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCategorias";
            Text = "FrmCategorias";
            Load += FrmCategorias_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox btnCerrar;
        private Button btnAgregar;
        private Button btnOrdenar;
        private Button btnBorrar;
        private Button btnEditar;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn ColNombre;
    }
}