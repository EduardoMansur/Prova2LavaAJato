namespace Prova2.Forms
{
    partial class CadastrarGasto
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
            this.label1 = new System.Windows.Forms.Label();
            this.precoNbr = new System.Windows.Forms.NumericUpDown();
            this.materialCb = new System.Windows.Forms.ComboBox();
            this.qtdNbr = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.precoNbr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtdNbr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Material:";
            // 
            // precoNbr
            // 
            this.precoNbr.DecimalPlaces = 2;
            this.precoNbr.Location = new System.Drawing.Point(265, 117);
            this.precoNbr.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.precoNbr.Name = "precoNbr";
            this.precoNbr.Size = new System.Drawing.Size(120, 20);
            this.precoNbr.TabIndex = 1;
            // 
            // materialCb
            // 
            this.materialCb.FormattingEnabled = true;
            this.materialCb.Location = new System.Drawing.Point(264, 72);
            this.materialCb.Name = "materialCb";
            this.materialCb.Size = new System.Drawing.Size(121, 21);
            this.materialCb.TabIndex = 2;
            // 
            // qtdNbr
            // 
            this.qtdNbr.Location = new System.Drawing.Point(264, 156);
            this.qtdNbr.Name = "qtdNbr";
            this.qtdNbr.Size = new System.Drawing.Size(120, 20);
            this.qtdNbr.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade:";
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(326, 207);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(75, 23);
            this.cadastrar.TabIndex = 6;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // CadastrarGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 261);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qtdNbr);
            this.Controls.Add(this.materialCb);
            this.Controls.Add(this.precoNbr);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarGasto";
            this.Text = "CadastrarGasto";
            this.Load += new System.EventHandler(this.CadastrarGasto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.precoNbr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtdNbr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown precoNbr;
        private System.Windows.Forms.ComboBox materialCb;
        private System.Windows.Forms.NumericUpDown qtdNbr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cadastrar;
    }
}