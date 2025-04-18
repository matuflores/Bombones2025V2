namespace Bombones2025.Windows
{
    partial class FrmPrincipal
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
            btnPaises = new Button();
            btnFrutosSecos = new Button();
            btnTiposRellenos = new Button();
            SuspendLayout();
            // 
            // btnPaises
            // 
            btnPaises.Location = new Point(68, 61);
            btnPaises.Name = "btnPaises";
            btnPaises.Size = new Size(145, 64);
            btnPaises.TabIndex = 0;
            btnPaises.Text = "PAISES";
            btnPaises.UseVisualStyleBackColor = true;
            btnPaises.Click += btnPaises_Click;
            // 
            // btnFrutosSecos
            // 
            btnFrutosSecos.Location = new Point(327, 61);
            btnFrutosSecos.Name = "btnFrutosSecos";
            btnFrutosSecos.Size = new Size(145, 64);
            btnFrutosSecos.TabIndex = 1;
            btnFrutosSecos.Text = "FRUTOS SECOS";
            btnFrutosSecos.UseVisualStyleBackColor = true;
            btnFrutosSecos.Click += btnFrutosSecos_Click;
            // 
            // btnTiposRellenos
            // 
            btnTiposRellenos.Location = new Point(591, 61);
            btnTiposRellenos.Name = "btnTiposRellenos";
            btnTiposRellenos.Size = new Size(145, 64);
            btnTiposRellenos.TabIndex = 2;
            btnTiposRellenos.Text = "TIPOS DE RELLENOS";
            btnTiposRellenos.UseVisualStyleBackColor = true;
            btnTiposRellenos.Click += btnTiposRellenos_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTiposRellenos);
            Controls.Add(btnFrutosSecos);
            Controls.Add(btnPaises);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPaises;
        private Button btnFrutosSecos;
        private Button btnTiposRellenos;
    }
}