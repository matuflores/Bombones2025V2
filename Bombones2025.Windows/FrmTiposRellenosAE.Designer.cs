namespace Bombones2025.Windows
{
    partial class FrmTiposRellenosAE
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
            label2 = new Label();
            buttonCancelTipoRellenoAE = new Button();
            buttonOkTipoRellenoAE = new Button();
            textBoxTipoRelleno = new TextBox();
            errorProviderTipoRellenoAE = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderTipoRellenoAE).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 45);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 13;
            label2.Text = "Tipo de Relleno:";
            // 
            // buttonCancelTipoRellenoAE
            // 
            buttonCancelTipoRellenoAE.Image = Properties.Resources.CANCEL40;
            buttonCancelTipoRellenoAE.Location = new Point(525, 134);
            buttonCancelTipoRellenoAE.Name = "buttonCancelTipoRellenoAE";
            buttonCancelTipoRellenoAE.Size = new Size(84, 71);
            buttonCancelTipoRellenoAE.TabIndex = 12;
            buttonCancelTipoRellenoAE.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonCancelTipoRellenoAE.UseVisualStyleBackColor = true;
            buttonCancelTipoRellenoAE.Click += buttonCancelTipoRellenoAE_Click;
            // 
            // buttonOkTipoRellenoAE
            // 
            buttonOkTipoRellenoAE.Image = Properties.Resources.OK40;
            buttonOkTipoRellenoAE.Location = new Point(175, 134);
            buttonOkTipoRellenoAE.Name = "buttonOkTipoRellenoAE";
            buttonOkTipoRellenoAE.Size = new Size(84, 71);
            buttonOkTipoRellenoAE.TabIndex = 11;
            buttonOkTipoRellenoAE.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonOkTipoRellenoAE.UseVisualStyleBackColor = true;
            buttonOkTipoRellenoAE.Click += buttonOkTipoRellenoAE_Click;
            // 
            // textBoxTipoRelleno
            // 
            textBoxTipoRelleno.Location = new Point(224, 42);
            textBoxTipoRelleno.Name = "textBoxTipoRelleno";
            textBoxTipoRelleno.Size = new Size(415, 27);
            textBoxTipoRelleno.TabIndex = 10;
            // 
            // errorProviderTipoRellenoAE
            // 
            errorProviderTipoRellenoAE.ContainerControl = this;
            // 
            // FrmTiposRellenosAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 247);
            Controls.Add(label2);
            Controls.Add(buttonCancelTipoRellenoAE);
            Controls.Add(buttonOkTipoRellenoAE);
            Controls.Add(textBoxTipoRelleno);
            Name = "FrmTiposRellenosAE";
            Text = "Tipos de Rellenos AE";
            ((System.ComponentModel.ISupportInitialize)errorProviderTipoRellenoAE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button buttonCancelTipoRellenoAE;
        private Button buttonOkTipoRellenoAE;
        private TextBox textBoxTipoRelleno;
        private ErrorProvider errorProviderTipoRellenoAE;
    }
}