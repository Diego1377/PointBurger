namespace PointBurger.Windows.Formularios
{
    partial class FrmFiltroTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiltroTexto));
            label1 = new Label();
            btnCancelar = new Button();
            btnOk = new Button();
            label2 = new Label();
            txtTexto = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 55);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(409, 151);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 72);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Image = (Image)resources.GetObject("btnOk.Image");
            btnOk.Location = new Point(73, 151);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(330, 72);
            btnOk.TabIndex = 6;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 47);
            label2.Name = "label2";
            label2.Size = new Size(101, 24);
            label2.TabIndex = 5;
            label2.Text = "BUSCAR:";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(216, 48);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(317, 27);
            txtTexto.TabIndex = 4;
            // 
            // FrmFiltroTexto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(682, 253);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(label2);
            Controls.Add(txtTexto);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmFiltroTexto";
            Text = "FrmFiltroTexto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCancelar;
        private Button btnOk;
        private Label label2;
        private TextBox txtTexto;
    }
}