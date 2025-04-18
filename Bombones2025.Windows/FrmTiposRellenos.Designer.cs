namespace Bombones2025.Windows
{
    partial class FrmTiposRellenos
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
            dgvTiposRellenos = new DataGridView();
            TipoRellenoId = new DataGridViewTextBoxColumn();
            TiposRellenos = new DataGridViewTextBoxColumn();
            toolStripTiposRellenos = new ToolStrip();
            btnNuevo = new ToolStripButton();
            btnBorrar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnFiltrar = new ToolStripButton();
            btnRefresh = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnPrint = new ToolStripButton();
            btnCerrar = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTiposRellenos).BeginInit();
            toolStripTiposRellenos.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(dgvTiposRellenos);
            splitContainer1.Panel1.Controls.Add(toolStripTiposRellenos);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 336;
            splitContainer1.TabIndex = 0;
            // 
            // dgvTiposRellenos
            // 
            dgvTiposRellenos.AllowUserToAddRows = false;
            dgvTiposRellenos.AllowUserToDeleteRows = false;
            dgvTiposRellenos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTiposRellenos.Columns.AddRange(new DataGridViewColumn[] { TipoRellenoId, TiposRellenos });
            dgvTiposRellenos.Dock = DockStyle.Fill;
            dgvTiposRellenos.Location = new Point(0, 67);
            dgvTiposRellenos.Name = "dgvTiposRellenos";
            dgvTiposRellenos.ReadOnly = true;
            dgvTiposRellenos.RowHeadersVisible = false;
            dgvTiposRellenos.RowHeadersWidth = 51;
            dgvTiposRellenos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTiposRellenos.Size = new Size(800, 269);
            dgvTiposRellenos.TabIndex = 3;
            // 
            // TipoRellenoId
            // 
            TipoRellenoId.HeaderText = "TipoDeRellenoId";
            TipoRellenoId.MinimumWidth = 6;
            TipoRellenoId.Name = "TipoRellenoId";
            TipoRellenoId.ReadOnly = true;
            TipoRellenoId.Visible = false;
            TipoRellenoId.Width = 125;
            // 
            // TiposRellenos
            // 
            TiposRellenos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TiposRellenos.HeaderText = "Tipos de Rellenos";
            TiposRellenos.MinimumWidth = 6;
            TiposRellenos.Name = "TiposRellenos";
            TiposRellenos.ReadOnly = true;
            // 
            // toolStripTiposRellenos
            // 
            toolStripTiposRellenos.ImageScalingSize = new Size(20, 20);
            toolStripTiposRellenos.Items.AddRange(new ToolStripItem[] { btnNuevo, btnBorrar, btnEditar, toolStripSeparator1, btnFiltrar, btnRefresh, toolStripSeparator2, btnPrint, btnCerrar });
            toolStripTiposRellenos.Location = new Point(0, 0);
            toolStripTiposRellenos.Name = "toolStripTiposRellenos";
            toolStripTiposRellenos.Size = new Size(800, 67);
            toolStripTiposRellenos.TabIndex = 2;
            toolStripTiposRellenos.Text = "toolStrip1";
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
            // btnBorrar
            // 
            btnBorrar.Image = Properties.Resources.DELETE40;
            btnBorrar.ImageScaling = ToolStripItemImageScaling.None;
            btnBorrar.ImageTransparentColor = Color.Magenta;
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(70, 64);
            btnBorrar.Text = "BORRAR";
            btnBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnEditar
            // 
            btnEditar.Image = Properties.Resources.EDIT40;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(62, 64);
            btnEditar.Text = "EDITAR";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 67);
            // 
            // btnFiltrar
            // 
            btnFiltrar.Image = Properties.Resources.FILTRO40;
            btnFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(66, 64);
            btnFiltrar.Text = "FILTRAR";
            btnFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnRefresh
            // 
            btnRefresh.Image = Properties.Resources.REFRESH40;
            btnRefresh.ImageScaling = ToolStripItemImageScaling.None;
            btnRefresh.ImageTransparentColor = Color.Magenta;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(73, 64);
            btnRefresh.Text = "REFRESH";
            btnRefresh.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 67);
            // 
            // btnPrint
            // 
            btnPrint.Image = Properties.Resources.PRINT40;
            btnPrint.ImageScaling = ToolStripItemImageScaling.None;
            btnPrint.ImageTransparentColor = Color.Magenta;
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(53, 64);
            btnPrint.Text = "PRINT";
            btnPrint.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = Properties.Resources.CLOSE40;
            btnCerrar.ImageScaling = ToolStripItemImageScaling.None;
            btnCerrar.ImageTransparentColor = Color.Magenta;
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(67, 64);
            btnCerrar.Text = "CERRAR";
            btnCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmTiposRellenos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FrmTiposRellenos";
            Text = "Tipos de Rellenos";
            Load += FrmTiposRellenos_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTiposRellenos).EndInit();
            toolStripTiposRellenos.ResumeLayout(false);
            toolStripTiposRellenos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvTiposRellenos;
        private ToolStrip toolStripTiposRellenos;
        private ToolStripButton btnNuevo;
        private ToolStripButton btnBorrar;
        private ToolStripButton btnEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnFiltrar;
        private ToolStripButton btnRefresh;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnPrint;
        private ToolStripButton btnCerrar;
        private DataGridViewTextBoxColumn TipoRellenoId;
        private DataGridViewTextBoxColumn TiposRellenos;
    }
}