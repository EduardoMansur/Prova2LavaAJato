namespace Prova2
{
    partial class CadastrarMaterial
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
            this.CadastrarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.qtdNbr = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.qtdNbr)).BeginInit();
            this.SuspendLayout();
            // 
            // CadastrarButton
            // 
            this.CadastrarButton.Location = new System.Drawing.Point(307, 210);
            this.CadastrarButton.Name = "CadastrarButton";
            this.CadastrarButton.Size = new System.Drawing.Size(75, 23);
            this.CadastrarButton.TabIndex = 0;
            this.CadastrarButton.Text = "Cadastrar";
            this.CadastrarButton.UseVisualStyleBackColor = true;
            this.CadastrarButton.Click += new System.EventHandler(this.CadastrarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // nomeBox
            // 
            this.nomeBox.Location = new System.Drawing.Point(292, 93);
            this.nomeBox.Name = "nomeBox";
            this.nomeBox.Size = new System.Drawing.Size(100, 20);
            this.nomeBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade:";
            // 
            // qtdNbr
            // 
            this.qtdNbr.Location = new System.Drawing.Point(292, 159);
            this.qtdNbr.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.qtdNbr.Name = "qtdNbr";
            this.qtdNbr.Size = new System.Drawing.Size(120, 20);
            this.qtdNbr.TabIndex = 5;
            // 
            // CadastrarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 307);
            this.Controls.Add(this.qtdNbr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CadastrarButton);
            this.Name = "CadastrarMaterial";
            this.Text = "CadastrarMaterial";
            this.Load += new System.EventHandler(this.CadastrarMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qtdNbr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CadastrarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown qtdNbr;
    }
}