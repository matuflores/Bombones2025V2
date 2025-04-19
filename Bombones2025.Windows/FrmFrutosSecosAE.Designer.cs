namespace Bombones2025.Windows
{
    partial class FrmFrutosSecosAE
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
            buttonCancelFrutoSecoAE = new Button();
            buttonOkFrutoSecoAE = new Button();
            label1 = new Label();
            textBoxFrutoSeco = new TextBox();
            label2 = new Label();
            errorProviderFrutoSecoAE = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderFrutoSecoAE).BeginInit();
            SuspendLayout();
            // 
            // buttonCancelFrutoSecoAE
            // 
            buttonCancelFrutoSecoAE.Image = Properties.Resources.CANCEL40;
            buttonCancelFrutoSecoAE.Location = new Point(506, 134);
            buttonCancelFrutoSecoAE.Name = "buttonCancelFrutoSecoAE";
            buttonCancelFrutoSecoAE.Size = new Size(84, 71);
            buttonCancelFrutoSecoAE.TabIndex = 7;
            buttonCancelFrutoSecoAE.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonCancelFrutoSecoAE.UseVisualStyleBackColor = true;
            buttonCancelFrutoSecoAE.Click += buttonCancelFrutoSecoAE_Click;
            // 
            // buttonOkFrutoSecoAE
            // 
            buttonOkFrutoSecoAE.Image = Properties.Resources.OK40;
            buttonOkFrutoSecoAE.Location = new Point(156, 134);
            buttonOkFrutoSecoAE.Name = "buttonOkFrutoSecoAE";
            buttonOkFrutoSecoAE.Size = new Size(84, 71);
            buttonOkFrutoSecoAE.TabIndex = 6;
            buttonOkFrutoSecoAE.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonOkFrutoSecoAE.UseVisualStyleBackColor = true;
            buttonOkFrutoSecoAE.Click += buttonOkFrutoSecoAE_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 8;
            // 
            // textBoxFrutoSeco
            // 
            textBoxFrutoSeco.Location = new Point(205, 42);
            textBoxFrutoSeco.Name = "textBoxFrutoSeco";
            textBoxFrutoSeco.Size = new Size(415, 27);
            textBoxFrutoSeco.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 45);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 9;
            label2.Text = "Fruto Seco:";
            // 
            // errorProviderFrutoSecoAE
            // 
            errorProviderFrutoSecoAE.ContainerControl = this;
            // 
            // FrmFrutosSecosAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 247);
            Controls.Add(label2);
            Controls.Add(buttonCancelFrutoSecoAE);
            Controls.Add(buttonOkFrutoSecoAE);
            Controls.Add(label1);
            Controls.Add(textBoxFrutoSeco);
            MaximumSize = new Size(779, 294);
            MinimumSize = new Size(779, 294);
            Name = "FrmFrutosSecosAE";
            Text = "FrmFrutosSecosAE";
            ((System.ComponentModel.ISupportInitialize)errorProviderFrutoSecoAE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancelFrutoSecoAE;
        private Button buttonOkFrutoSecoAE;
        private Label label1;
        private TextBox textBoxFrutoSeco;
        private Label label2;
        private ErrorProvider errorProviderFrutoSecoAE;
    }
}