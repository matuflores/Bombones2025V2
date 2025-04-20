namespace Bombones2025.Windows
{
    partial class FrmTiposChocolatesAE
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
            labelTiposChocolate = new Label();
            buttonCancelTipoChocolateAE = new Button();
            buttonOkTipoChocolateAE = new Button();
            textBoxTipoChocolate = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // labelTiposChocolate
            // 
            labelTiposChocolate.AutoSize = true;
            labelTiposChocolate.Location = new Point(105, 45);
            labelTiposChocolate.Name = "labelTiposChocolate";
            labelTiposChocolate.Size = new Size(125, 20);
            labelTiposChocolate.TabIndex = 17;
            labelTiposChocolate.Text = "Tipo de Chcolate:";
            // 
            // buttonCancelTipoChocolateAE
            // 
            buttonCancelTipoChocolateAE.Image = Properties.Resources.CANCEL40;
            buttonCancelTipoChocolateAE.Location = new Point(541, 134);
            buttonCancelTipoChocolateAE.Name = "buttonCancelTipoChocolateAE";
            buttonCancelTipoChocolateAE.Size = new Size(84, 71);
            buttonCancelTipoChocolateAE.TabIndex = 16;
            buttonCancelTipoChocolateAE.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonCancelTipoChocolateAE.UseVisualStyleBackColor = true;
            // 
            // buttonOkTipoChocolateAE
            // 
            buttonOkTipoChocolateAE.Image = Properties.Resources.OK40;
            buttonOkTipoChocolateAE.Location = new Point(191, 134);
            buttonOkTipoChocolateAE.Name = "buttonOkTipoChocolateAE";
            buttonOkTipoChocolateAE.Size = new Size(84, 71);
            buttonOkTipoChocolateAE.TabIndex = 15;
            buttonOkTipoChocolateAE.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonOkTipoChocolateAE.UseVisualStyleBackColor = true;
            // 
            // textBoxTipoChocolate
            // 
            textBoxTipoChocolate.Location = new Point(240, 42);
            textBoxTipoChocolate.Name = "textBoxTipoChocolate";
            textBoxTipoChocolate.Size = new Size(415, 27);
            textBoxTipoChocolate.TabIndex = 14;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmTiposChocolatesAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 247);
            Controls.Add(labelTiposChocolate);
            Controls.Add(buttonCancelTipoChocolateAE);
            Controls.Add(buttonOkTipoChocolateAE);
            Controls.Add(textBoxTipoChocolate);
            Name = "FrmTiposChocolatesAE";
            Text = "Tipos Chocolates AE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTiposChocolate;
        private Button buttonCancelTipoChocolateAE;
        private Button buttonOkTipoChocolateAE;
        private TextBox textBoxTipoChocolate;
        private ErrorProvider errorProvider1;
    }
}