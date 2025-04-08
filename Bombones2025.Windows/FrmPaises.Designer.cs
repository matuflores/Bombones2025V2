namespace Bombones2025.Windows
{
    partial class FrmPaises
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
            splitContainer1 = new SplitContainer();
            dgvDatosPaises = new DataGridView();
            PaisId = new DataGridViewTextBoxColumn();
            Paises = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            btnNuevo = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripButton7 = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatosPaises).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDatosPaises);
            splitContainer1.Panel1.Controls.Add(toolStrip1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 373;
            splitContainer1.TabIndex = 0;
            // 
            // dgvDatosPaises
            // 
            dgvDatosPaises.AllowUserToAddRows = false;
            dgvDatosPaises.AllowUserToDeleteRows = false;
            dgvDatosPaises.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosPaises.Columns.AddRange(new DataGridViewColumn[] { PaisId, Paises });
            dgvDatosPaises.Dock = DockStyle.Fill;
            dgvDatosPaises.Location = new Point(0, 67);
            dgvDatosPaises.Name = "dgvDatosPaises";
            dgvDatosPaises.ReadOnly = true;
            dgvDatosPaises.RowHeadersVisible = false;
            dgvDatosPaises.RowHeadersWidth = 51;
            dgvDatosPaises.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatosPaises.Size = new Size(800, 306);
            dgvDatosPaises.TabIndex = 1;
            // 
            // PaisId
            // 
            PaisId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            PaisId.HeaderText = "Id";
            PaisId.MinimumWidth = 6;
            PaisId.Name = "PaisId";
            PaisId.ReadOnly = true;
            PaisId.SortMode = DataGridViewColumnSortMode.NotSortable;
            PaisId.Visible = false;
            PaisId.Width = 51;
            // 
            // Paises
            // 
            Paises.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Paises.HeaderText = "Pais";
            Paises.MinimumWidth = 6;
            Paises.Name = "Paises";
            Paises.ReadOnly = true;
            Paises.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, toolStripButton3, toolStripButton4, toolStripSeparator1, toolStripButton5, toolStripButton6, toolStripSeparator2, toolStripButton2, toolStripButton7 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 67);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            btnNuevo.Image = Properties.Resources.NEW40;
            btnNuevo.ImageScaling = ToolStripItemImageScaling.None;
            btnNuevo.ImageTransparentColor = Color.Magenta;
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(62, 64);
            btnNuevo.Text = "NUEVO";
            btnNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = Properties.Resources.DELETE40;
            toolStripButton3.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(70, 64);
            toolStripButton3.Text = "BORRAR";
            toolStripButton3.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = Properties.Resources.EDIT40;
            toolStripButton4.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(62, 64);
            toolStripButton4.Text = "EDITAR";
            toolStripButton4.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 67);
            // 
            // toolStripButton5
            // 
            toolStripButton5.Image = Properties.Resources.FILTRO40;
            toolStripButton5.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(66, 64);
            toolStripButton5.Text = "FILTRAR";
            toolStripButton5.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripButton6
            // 
            toolStripButton6.Image = Properties.Resources.REFRESH40;
            toolStripButton6.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(73, 64);
            toolStripButton6.Text = "REFRESH";
            toolStripButton6.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 67);
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources.PRINT40;
            toolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(53, 64);
            toolStripButton2.Text = "PRINT";
            toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripButton7
            // 
            toolStripButton7.Image = Properties.Resources.CLOSE40;
            toolStripButton7.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(67, 64);
            toolStripButton7.Text = "CERRAR";
            toolStripButton7.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton7.Click += toolStripButton7_Click;
            // 
            // FrmPaises
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FrmPaises";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PAISES";
            Load += FrmPaises_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatosPaises).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton btnNuevo;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton7;
        private DataGridView dgvDatosPaises;
        private DataGridViewTextBoxColumn PaisId;
        private DataGridViewTextBoxColumn Paises;
    }
}