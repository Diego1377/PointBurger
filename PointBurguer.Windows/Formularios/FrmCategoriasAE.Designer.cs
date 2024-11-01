namespace PointBurger.Windows.Formularios
{
    partial class FrmCategoriasAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoriasAE));
            txtCategoria = new TextBox();
            label1 = new Label();
            btnOk = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(169, 52);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(317, 27);
            txtCategoria.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 51);
            label1.Name = "label1";
            label1.Size = new Size(137, 24);
            label1.TabIndex = 1;
            label1.Text = "CATEGORIA:";
            // 
            // btnOk
            // 
            btnOk.Image = (Image)resources.GetObject("btnOk.Image");
            btnOk.Location = new Point(26, 155);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(330, 72);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(362, 155);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 72);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmCategoriasAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(528, 271);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(label1);
            Controls.Add(txtCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCategoriasAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCategoriasAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCategoria;
        private Label label1;
        private Button btnOk;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}