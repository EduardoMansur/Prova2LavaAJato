namespace Prova2.Forms
{
    partial class AtualizarMaterial
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
            this.cadastrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.qtdNbr = new System.Windows.Forms.NumericUpDown();
            this.materialCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qtdNbr)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(215, 180);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(75, 23);
            this.cadastrar.TabIndex = 13;
            this.cadastrar.Text = "Atualizar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Quantidade :";
            // 
            // qtdNbr
            // 
            this.qtdNbr.Location = new System.Drawing.Point(255, 114);
            this.qtdNbr.Name = "qtdNbr";
            this.qtdNbr.Size = new System.Drawing.Size(120, 20);
            this.qtdNbr.TabIndex = 10;
            // 
            // materialCb
            // 
            this.materialCb.FormattingEnabled = true;
            this.materialCb.Location = new System.Drawing.Point(255, 51);
            this.materialCb.Name = "materialCb";
            this.materialCb.Size = new System.Drawing.Size(121, 21);
            this.materialCb.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Material:";
            // 
            // AtualizarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 261);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.qtdNbr);
            this.Controls.Add(this.materialCb);
            this.Controls.Add(this.label1);
            this.Name = "AtualizarMaterial";
            this.Text = "AtualizarMaterial";
            this.Load += new System.EventHandler(this.AtualizarMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qtdNbr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown qtdNbr;
        private System.Windows.Forms.ComboBox materialCb;
        private System.Windows.Forms.Label label1;
    }
}