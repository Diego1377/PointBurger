namespace PointBurger.Windows.Formularios
{
    partial class FrmEmpleadosAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleadosAE));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            txtSalario = new TextBox();
            txtComision = new TextBox();
            btnCancelar = new Button();
            btnOk = new Button();
            dtpFechaNac = new DateTimePicker();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(102, 37);
            label1.Name = "label1";
            label1.Size = new Size(89, 22);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(102, 70);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(112, 169);
            label3.Name = "label3";
            label3.Size = new Size(79, 22);
            label3.TabIndex = 2;
            label3.Text = "Salario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(95, 136);
            label4.Name = "label4";
            label4.Size = new Size(96, 22);
            label4.TabIndex = 3;
            label4.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(12, 103);
            label5.Name = "label5";
            label5.Size = new Size(179, 22);
            label5.TabIndex = 4;
            label5.Text = "Fecha Nacimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(92, 202);
            label6.Name = "label6";
            label6.Size = new Size(99, 22);
            label6.TabIndex = 5;
            label6.Text = "Comision:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(197, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(190, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(197, 69);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(190, 27);
            txtApellido.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(197, 136);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(190, 27);
            txtTelefono.TabIndex = 6;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(197, 169);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(190, 27);
            txtSalario.TabIndex = 6;
            // 
            // txtComision
            // 
            txtComision.Location = new Point(197, 202);
            txtComision.Name = "txtComision";
            txtComision.Size = new Size(190, 27);
            txtComision.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(393, 283);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 72);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Image = (Image)resources.GetObject("btnOk.Image");
            btnOk.Location = new Point(57, 283);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(330, 72);
            btnOk.TabIndex = 7;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Location = new Point(197, 100);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(292, 27);
            dtpFechaNac.TabIndex = 9;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmEmpleadosAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(536, 377);
            Controls.Add(dtpFechaNac);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(txtComision);
            Controls.Add(txtSalario);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEmpleadosAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEmpleadosAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private TextBox txtSalario;
        private TextBox txtComision;
        private Button btnCancelar;
        private Button btnOk;
        private DateTimePicker dtpFechaNac;
        private ErrorProvider errorProvider1;
    }
}