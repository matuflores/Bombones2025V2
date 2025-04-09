namespace Bombones2025.Windows
{
    partial class FrmPaisesAE
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
            textBoxPais = new TextBox();
            label1 = new Label();
            buttonOkPaisAE = new Button();
            buttonCancelPaisAE = new Button();
            errorProviderPaisAe = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderPaisAe).BeginInit();
            SuspendLayout();
            // 
            // textBoxPais
            // 
            textBoxPais.Location = new Point(208, 47);
            textBoxPais.Name = "textBoxPais";
            textBoxPais.Size = new Size(415, 27);
            textBoxPais.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 50);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 1;
            label1.Text = "Pais:";
            // 
            // buttonOkPaisAE
            // 
            buttonOkPaisAE.Image = Properties.Resources.OK40;
            buttonOkPaisAE.Location = new Point(159, 139);
            buttonOkPaisAE.Name = "buttonOkPaisAE";
            buttonOkPaisAE.Size = new Size(84, 71);
            buttonOkPaisAE.TabIndex = 2;
            buttonOkPaisAE.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonOkPaisAE.UseVisualStyleBackColor = true;
            buttonOkPaisAE.Click += buttonOkPaisAE_Click;
            // 
            // buttonCancelPaisAE
            // 
            buttonCancelPaisAE.Image = Properties.Resources.CANCEL40;
            buttonCancelPaisAE.Location = new Point(509, 139);
            buttonCancelPaisAE.Name = "buttonCancelPaisAE";
            buttonCancelPaisAE.Size = new Size(84, 71);
            buttonCancelPaisAE.TabIndex = 3;
            buttonCancelPaisAE.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonCancelPaisAE.UseVisualStyleBackColor = true;
            buttonCancelPaisAE.Click += buttonCancelPaisAE_Click;
            // 
            // errorProviderPaisAe
            // 
            errorProviderPaisAe.ContainerControl = this;
            // 
            // FrmPaisesAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 247);
            Controls.Add(buttonCancelPaisAE);
            Controls.Add(buttonOkPaisAE);
            Controls.Add(label1);
            Controls.Add(textBoxPais);
            MaximumSize = new Size(779, 294);
            MinimumSize = new Size(779, 294);
            Name = "FrmPaisesAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PAISES AE";
            ((System.ComponentModel.ISupportInitialize)errorProviderPaisAe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPais;
        private Label label1;
        private Button buttonOkPaisAE;
        private Button buttonCancelPaisAE;
        private ErrorProvider errorProviderPaisAe;
    }
}