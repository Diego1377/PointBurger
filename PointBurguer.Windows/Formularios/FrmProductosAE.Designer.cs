namespace PointBurger.Windows.Formularios
{
    partial class FrmProductosAE
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductosAE));
            btnCancelar = new Button();
            label7 = new Label();
            btnBuscarImagen = new Button();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            cboCategorias = new ComboBox();
            btnOk = new Button();
            label10 = new Label();
            chkSuspendido = new CheckBox();
            groupBox2 = new GroupBox();
            nupPrecioV = new NumericUpDown();
            nupPrecioC = new NumericUpDown();
            txtDescripcion = new TextBox();
            label8 = new Label();
            txtProducto = new TextBox();
            groupBox3 = new GroupBox();
            picImagen = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            nupStock = new NumericUpDown();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupPrecioV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupPrecioC).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupStock).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(395, 423);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 72);
            btnCancelar.TabIndex = 56;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 351);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 53;
            label7.Text = "Stock:";
            // 
            // btnBuscarImagen
            // 
            btnBuscarImagen.Location = new Point(607, 294);
            btnBuscarImagen.Margin = new Padding(3, 4, 3, 4);
            btnBuscarImagen.Name = "btnBuscarImagen";
            btnBuscarImagen.Size = new Size(208, 65);
            btnBuscarImagen.TabIndex = 52;
            btnBuscarImagen.Text = "Buscar";
            btnBuscarImagen.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarImagen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 16);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 45;
            label1.Text = "Producto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(222, 37);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 0;
            label6.Text = "P. Vta.:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 34);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 0;
            label5.Text = "P. Costo:";
            // 
            // cboCategorias
            // 
            cboCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategorias.FormattingEnabled = true;
            cboCategorias.Location = new Point(128, 191);
            cboCategorias.Margin = new Padding(3, 4, 3, 4);
            cboCategorias.Name = "cboCategorias";
            cboCategorias.Size = new Size(241, 28);
            cboCategorias.TabIndex = 50;
            // 
            // btnOk
            // 
            btnOk.Image = (Image)resources.GetObject("btnOk.Image");
            btnOk.Location = new Point(24, 423);
            btnOk.Margin = new Padding(3, 4, 3, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(330, 72);
            btnOk.TabIndex = 57;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(46, 194);
            label10.Name = "label10";
            label10.Size = new Size(77, 20);
            label10.TabIndex = 47;
            label10.Text = "Categoria:";
            // 
            // chkSuspendido
            // 
            chkSuspendido.AutoSize = true;
            chkSuspendido.Location = new Point(618, 12);
            chkSuspendido.Margin = new Padding(3, 4, 3, 4);
            chkSuspendido.Name = "chkSuspendido";
            chkSuspendido.Size = new Size(109, 24);
            chkSuspendido.TabIndex = 55;
            chkSuspendido.Text = "Suspendido";
            chkSuspendido.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nupPrecioV);
            groupBox2.Controls.Add(nupPrecioC);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(46, 238);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(433, 89);
            groupBox2.TabIndex = 51;
            groupBox2.TabStop = false;
            groupBox2.Text = " Precios ";
            // 
            // nupPrecioV
            // 
            nupPrecioV.Location = new Point(280, 35);
            nupPrecioV.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nupPrecioV.Name = "nupPrecioV";
            nupPrecioV.Size = new Size(120, 27);
            nupPrecioV.TabIndex = 61;
            // 
            // nupPrecioC
            // 
            nupPrecioC.Location = new Point(82, 32);
            nupPrecioC.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nupPrecioC.Name = "nupPrecioC";
            nupPrecioC.Size = new Size(120, 27);
            nupPrecioC.TabIndex = 60;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(128, 51);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.MaxLength = 256;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(470, 120);
            txtDescripcion.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 51);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 46;
            label8.Text = "Descripción:";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(128, 12);
            txtProducto.Margin = new Padding(3, 4, 3, 4);
            txtProducto.MaxLength = 120;
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(470, 27);
            txtProducto.TabIndex = 49;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(picImagen);
            groupBox3.Location = new Point(604, 55);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(211, 251);
            groupBox3.TabIndex = 58;
            groupBox3.TabStop = false;
            groupBox3.Text = " Imágen ";
            // 
            // picImagen
            // 
            picImagen.Location = new Point(19, 28);
            picImagen.Margin = new Padding(3, 4, 3, 4);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(174, 203);
            picImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagen.TabIndex = 0;
            picImagen.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // nupStock
            // 
            nupStock.Location = new Point(108, 351);
            nupStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nupStock.Name = "nupStock";
            nupStock.Size = new Size(150, 27);
            nupStock.TabIndex = 59;
            // 
            // FrmProductosAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(832, 510);
            Controls.Add(nupStock);
            Controls.Add(groupBox3);
            Controls.Add(btnCancelar);
            Controls.Add(label7);
            Controls.Add(btnBuscarImagen);
            Controls.Add(label1);
            Controls.Add(cboCategorias);
            Controls.Add(btnOk);
            Controls.Add(label10);
            Controls.Add(chkSuspendido);
            Controls.Add(groupBox2);
            Controls.Add(txtDescripcion);
            Controls.Add(label8);
            Controls.Add(txtProducto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProductosAE";
            Text = "FrmProductosAE";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupPrecioV).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupPrecioC).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Label label7;
        private Button btnBuscarImagen;
        private Label label1;
        private Label label6;
        private Label label5;
        private ComboBox cboCategorias;
        private Button btnOk;
        private Label label10;
        private CheckBox chkSuspendido;
        private GroupBox groupBox2;
        private TextBox txtDescripcion;
        private Label label8;
        private TextBox txtProducto;
        private GroupBox groupBox3;
        private PictureBox picImagen;
        private ErrorProvider errorProvider1;
        private NumericUpDown nupStock;
        private NumericUpDown nupPrecioV;
        private NumericUpDown nupPrecioC;
    }
}