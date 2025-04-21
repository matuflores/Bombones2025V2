namespace Bombones2025.Windows
{
    partial class FrmTiposChocolates
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
            splitContainer1 = new SplitContainer();
            dgvTiposChocolates = new DataGridView();
            TipoRellenoId = new DataGridViewTextBoxColumn();
            TiposChocolates = new DataGridViewTextBoxColumn();
            toolStripTiposChocolates = new ToolStrip();
            btnNuevo = new ToolStripButton();
            btnBorrar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnFiltrar = new ToolStripButton();
            btnRefresh = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnPrint = new ToolStripButton();
            btnCerrar = new ToolStripButton();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTiposChocolates).BeginInit();
            toolStripTiposChocolates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(dgvTiposChocolates);
            splitContainer1.Panel1.Controls.Add(toolStripTiposChocolates);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 357;
            splitContainer1.TabIndex = 0;
            // 
            // dgvTiposChocolates
            // 
            dgvTiposChocolates.AllowUserToAddRows = false;
            dgvTiposChocolates.AllowUserToDeleteRows = false;
            dgvTiposChocolates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTiposChocolates.Columns.AddRange(new DataGridViewColumn[] { TipoRellenoId, TiposChocolates });
            dgvTiposChocolates.Dock = DockStyle.Fill;
            dgvTiposChocolates.Location = new Point(0, 67);
            dgvTiposChocolates.Name = "dgvTiposChocolates";
            dgvTiposChocolates.ReadOnly = true;
            dgvTiposChocolates.RowHeadersVisible = false;
            dgvTiposChocolates.RowHeadersWidth = 51;
            dgvTiposChocolates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTiposChocolates.Size = new Size(800, 290);
            dgvTiposChocolates.TabIndex = 4;
            // 
            // TipoRellenoId
            // 
            TipoRellenoId.HeaderText = "TipoRellenoId";
            TipoRellenoId.MinimumWidth = 6;
            TipoRellenoId.Name = "TipoRellenoId";
            TipoRellenoId.ReadOnly = true;
            TipoRellenoId.Visible = false;
            TipoRellenoId.Width = 125;
            // 
            // TiposChocolates
            // 
            TiposChocolates.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TiposChocolates.HeaderText = "Tipos de Chocolates";
            TiposChocolates.MinimumWidth = 6;
            TiposChocolates.Name = "TiposChocolates";
            TiposChocolates.ReadOnly = true;
            // 
            // toolStripTiposChocolates
            // 
            toolStripTiposChocolates.ImageScalingSize = new Size(20, 20);
            toolStripTiposChocolates.Items.AddRange(new ToolStripItem[] { btnNuevo, btnBorrar, btnEditar, toolStripSeparator1, btnFiltrar, btnRefresh, toolStripSeparator2, btnPrint, btnCerrar });
            toolStripTiposChocolates.Location = new Point(0, 0);
            toolStripTiposChocolates.Name = "toolStripTiposChocolates";
            toolStripTiposChocolates.Size = new Size(800, 67);
            toolStripTiposChocolates.TabIndex = 3;
            toolStripTiposChocolates.Text = "toolStrip1";
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
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmTiposChocolates
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FrmTiposChocolates";
            Text = "Tipos Chocolates";
            Load += FrmTiposChocolates_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTiposChocolates).EndInit();
            toolStripTiposChocolates.ResumeLayout(false);
            toolStripTiposChocolates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ToolStrip toolStripTiposChocolates;
        private ToolStripButton btnNuevo;
        private ToolStripButton btnBorrar;
        private ToolStripButton btnEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnFiltrar;
        private ToolStripButton btnRefresh;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnPrint;
        private ToolStripButton btnCerrar;
        private DataGridView dgvTiposChocolates;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn TipoRellenoId;
        private DataGridViewTextBoxColumn TiposChocolates;
    }
}