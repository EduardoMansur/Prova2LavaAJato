namespace Prova2
{
    partial class Custos
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
            this.custoLbl = new System.Windows.Forms.Label();
            this.LucroLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Custos:";
            // 
            // custoLbl
            // 
            this.custoLbl.AutoSize = true;
            this.custoLbl.Location = new System.Drawing.Point(349, 105);
            this.custoLbl.Name = "custoLbl";
            this.custoLbl.Size = new System.Drawing.Size(35, 13);
            this.custoLbl.TabIndex = 1;
            this.custoLbl.Text = "label2";
            // 
            // LucroLbl
            // 
            this.LucroLbl.AutoSize = true;
            this.LucroLbl.Location = new System.Drawing.Point(349, 149);
            this.LucroLbl.Name = "LucroLbl";
            this.LucroLbl.Size = new System.Drawing.Size(35, 13);
            this.LucroLbl.TabIndex = 2;
            this.LucroLbl.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lucros:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Custos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 300);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LucroLbl);
            this.Controls.Add(this.custoLbl);
            this.Controls.Add(this.label1);
            this.Name = "Custos";
            this.Text = "Custos";
            this.Load += new System.EventHandler(this.Custos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label custoLbl;
        private System.Windows.Forms.Label LucroLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}