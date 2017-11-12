namespace Prova2
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastraClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarGastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.custosEGanhosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.visualizarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastraClienteToolStripMenuItem,
            this.cadastrarServiçoToolStripMenuItem,
            this.cadastrarMaterialToolStripMenuItem,
            this.cadastrarGastoToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // cadastraClienteToolStripMenuItem
            // 
            this.cadastraClienteToolStripMenuItem.Name = "cadastraClienteToolStripMenuItem";
            this.cadastraClienteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cadastraClienteToolStripMenuItem.Text = "Cadastra Cliente";
            this.cadastraClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastraClienteToolStripMenuItem_Click);
            // 
            // cadastrarServiçoToolStripMenuItem
            // 
            this.cadastrarServiçoToolStripMenuItem.Name = "cadastrarServiçoToolStripMenuItem";
            this.cadastrarServiçoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cadastrarServiçoToolStripMenuItem.Text = "Cadastrar Serviço";
            this.cadastrarServiçoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarServiçoToolStripMenuItem_Click);
            // 
            // cadastrarMaterialToolStripMenuItem
            // 
            this.cadastrarMaterialToolStripMenuItem.Name = "cadastrarMaterialToolStripMenuItem";
            this.cadastrarMaterialToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cadastrarMaterialToolStripMenuItem.Text = "Cadastrar Material";
            this.cadastrarMaterialToolStripMenuItem.Click += new System.EventHandler(this.cadastrarMaterialToolStripMenuItem_Click);
            // 
            // cadastrarGastoToolStripMenuItem
            // 
            this.cadastrarGastoToolStripMenuItem.Name = "cadastrarGastoToolStripMenuItem";
            this.cadastrarGastoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cadastrarGastoToolStripMenuItem.Text = "Cadastrar Gasto";
            this.cadastrarGastoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarGastoToolStripMenuItem_Click);
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.custosEGanhosToolStripMenuItem,
            this.materiaisToolStripMenuItem});
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // custosEGanhosToolStripMenuItem
            // 
            this.custosEGanhosToolStripMenuItem.Name = "custosEGanhosToolStripMenuItem";
            this.custosEGanhosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.custosEGanhosToolStripMenuItem.Text = "Custos e Ganhos";
            this.custosEGanhosToolStripMenuItem.Click += new System.EventHandler(this.custosEGanhosToolStripMenuItem_Click);
            // 
            // materiaisToolStripMenuItem
            // 
            this.materiaisToolStripMenuItem.Name = "materiaisToolStripMenuItem";
            this.materiaisToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.materiaisToolStripMenuItem.Text = "Dados";
            this.materiaisToolStripMenuItem.Click += new System.EventHandler(this.materiaisToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 348);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastraClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem custosEGanhosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarGastoToolStripMenuItem;
    }
}

