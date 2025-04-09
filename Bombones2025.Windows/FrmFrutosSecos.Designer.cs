namespace Bombones2025.Windows
{
    partial class FrmFrutosSecos
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
            dgvDatosFrutosSecos = new DataGridView();
            btnNuevo = new ToolStripButton();
            btnBorrar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnFiltrar = new ToolStripButton();
            btnRefresh = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnPrint = new ToolStripButton();
            toolStripButton7 = new ToolStripButton();
            toolStripFrutosSecos = new ToolStrip();
            FrutoSecoId = new DataGridViewTextBoxColumn();
            FrutosSecos = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatosFrutosSecos).BeginInit();
            toolStripFrutosSecos.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(toolStripFrutosSecos);
            splitContainer1.Panel1.Controls.Add(dgvDatosFrutosSecos);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 360;
            splitContainer1.TabIndex = 0;
            // 
            // dgvDatosFrutosSecos
            // 
            dgvDatosFrutosSecos.AllowUserToAddRows = false;
            dgvDatosFrutosSecos.AllowUserToDeleteRows = false;
            dgvDatosFrutosSecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosFrutosSecos.Columns.AddRange(new DataGridViewColumn[] { FrutoSecoId, FrutosSecos });
            dgvDatosFrutosSecos.Location = new Point(0, 70);
            dgvDatosFrutosSecos.Name = "dgvDatosFrutosSecos";
            dgvDatosFrutosSecos.ReadOnly = true;
            dgvDatosFrutosSecos.RowHeadersVisible = false;
            dgvDatosFrutosSecos.RowHeadersWidth = 51;
            dgvDatosFrutosSecos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatosFrutosSecos.Size = new Size(800, 290);
            dgvDatosFrutosSecos.TabIndex = 0;
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
            // toolStripButton7
            // 
            toolStripButton7.Image = Properties.Resources.CLOSE40;
            toolStripButton7.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(67, 64);
            toolStripButton7.Text = "CERRAR";
            toolStripButton7.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripFrutosSecos
            // 
            toolStripFrutosSecos.ImageScalingSize = new Size(20, 20);
            toolStripFrutosSecos.Items.AddRange(new ToolStripItem[] { btnNuevo, btnBorrar, btnEditar, toolStripSeparator1, btnFiltrar, btnRefresh, toolStripSeparator2, btnPrint, toolStripButton7 });
            toolStripFrutosSecos.Location = new Point(0, 0);
            toolStripFrutosSecos.Name = "toolStripFrutosSecos";
            toolStripFrutosSecos.Size = new Size(800, 67);
            toolStripFrutosSecos.TabIndex = 1;
            toolStripFrutosSecos.Text = "toolStrip1";
            // 
            // FrutoSecoId
            // 
            FrutoSecoId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            FrutoSecoId.HeaderText = "Id";
            FrutoSecoId.MinimumWidth = 6;
            FrutoSecoId.Name = "FrutoSecoId";
            FrutoSecoId.ReadOnly = true;
            FrutoSecoId.SortMode = DataGridViewColumnSortMode.NotSortable;
            FrutoSecoId.Visible = false;
            FrutoSecoId.Width = 125;
            // 
            // FrutosSecos
            // 
            FrutosSecos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FrutosSecos.HeaderText = "Fruto Seco";
            FrutosSecos.MinimumWidth = 6;
            FrutosSecos.Name = "FrutosSecos";
            FrutosSecos.ReadOnly = true;
            FrutosSecos.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmFrutosSecos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FrmFrutosSecos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmFrutosSecos";
            Load += FrmFrutosSecos_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatosFrutosSecos).EndInit();
            toolStripFrutosSecos.ResumeLayout(false);
            toolStripFrutosSecos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvDatosFrutosSecos;
        private ToolStrip toolStripFrutosSecos;
        private ToolStripButton btnNuevo;
        private ToolStripButton btnBorrar;
        private ToolStripButton btnEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnFiltrar;
        private ToolStripButton btnRefresh;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnPrint;
        private ToolStripButton toolStripButton7;
        private DataGridViewTextBoxColumn FrutoSecoId;
        private DataGridViewTextBoxColumn FrutosSecos;
    }
}