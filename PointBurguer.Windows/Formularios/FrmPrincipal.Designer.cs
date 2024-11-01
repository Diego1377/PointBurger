


namespace PointBurguer.Windows
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            panel1 = new Panel();
            btnSalir = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnCategorias = new Button();
            btnEmpleados = new Button();
            button4 = new Button();
            button3 = new Button();
            btnProductos = new Button();
            panelContenedor = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSalir).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 110);
            panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(1122, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(78, 58);
            btnSalir.SizeMode = PictureBoxSizeMode.Zoom;
            btnSalir.TabIndex = 1;
            btnSalir.TabStop = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(0, -2);
            label1.Name = "label1";
            label1.Size = new Size(616, 98);
            label1.TabIndex = 0;
            label1.Text = "POINT BURGER";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
            panel2.Controls.Add(btnCategorias);
            panel2.Controls.Add(btnEmpleados);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnProductos);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(238, 490);
            panel2.TabIndex = 1;
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.PaleGreen;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            btnCategorias.Image = (Image)resources.GetObject("btnCategorias.Image");
            btnCategorias.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategorias.Location = new Point(11, 9);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(221, 85);
            btnCategorias.TabIndex = 1;
            btnCategorias.Text = "CATEGORIAS";
            btnCategorias.TextAlign = ContentAlignment.MiddleRight;
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.PaleGreen;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            btnEmpleados.Image = (Image)resources.GetObject("btnEmpleados.Image");
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(11, 373);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(221, 85);
            btnEmpleados.TabIndex = 0;
            btnEmpleados.Text = "EMPLEADOS";
            btnEmpleados.TextAlign = ContentAlignment.MiddleRight;
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.PaleGreen;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(11, 282);
            button4.Name = "button4";
            button4.Size = new Size(221, 85);
            button4.TabIndex = 0;
            button4.Text = "PEDIDOS";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(11, 191);
            button3.Name = "button3";
            button3.Size = new Size(221, 85);
            button3.TabIndex = 0;
            button3.Text = "COMBOS";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.PaleGreen;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            btnProductos.ForeColor = SystemColors.ControlText;
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(11, 100);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(221, 85);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "PRODUCTOS";
            btnProductos.TextAlign = ContentAlignment.MiddleRight;
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.PaleGreen;
            panelContenedor.BackgroundImage = (Image)resources.GetObject("panelContenedor.BackgroundImage");
            panelContenedor.BackgroundImageLayout = ImageLayout.Stretch;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.ImeMode = ImeMode.NoControl;
            panelContenedor.Location = new Point(238, 110);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(962, 490);
            panelContenedor.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            Controls.Add(panelContenedor);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSalir).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnEmpleados;
        private Button button4;
        private Button button3;
        private Button btnProductos;
        private Panel panelContenedor;
        private Button btnCategorias;
        private PictureBox btnSalir;
    }
}
