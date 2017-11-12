namespace Prova2
{
    partial class Serviço
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
            this.PlacaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.precoBnr = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ClienteCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.moto = new System.Windows.Forms.RadioButton();
            this.carro = new System.Windows.Forms.RadioButton();
            this.caminhao = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.precoBnr)).BeginInit();
            this.SuspendLayout();
            // 
            // PlacaBox
            // 
            this.PlacaBox.Location = new System.Drawing.Point(242, 47);
            this.PlacaBox.Name = "PlacaBox";
            this.PlacaBox.Size = new System.Drawing.Size(100, 20);
            this.PlacaBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Placa:";
            // 
            // precoBnr
            // 
            this.precoBnr.DecimalPlaces = 2;
            this.precoBnr.Location = new System.Drawing.Point(242, 107);
            this.precoBnr.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.precoBnr.Name = "precoBnr";
            this.precoBnr.Size = new System.Drawing.Size(120, 20);
            this.precoBnr.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preço:";
            // 
            // ClienteCb
            // 
            this.ClienteCb.FormattingEnabled = true;
            this.ClienteCb.Location = new System.Drawing.Point(242, 164);
            this.ClienteCb.Name = "ClienteCb";
            this.ClienteCb.Size = new System.Drawing.Size(121, 21);
            this.ClienteCb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cliente:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // moto
            // 
            this.moto.AutoSize = true;
            this.moto.Location = new System.Drawing.Point(203, 79);
            this.moto.Name = "moto";
            this.moto.Size = new System.Drawing.Size(49, 17);
            this.moto.TabIndex = 7;
            this.moto.TabStop = true;
            this.moto.Text = "Moto";
            this.moto.UseVisualStyleBackColor = true;
            // 
            // carro
            // 
            this.carro.AutoSize = true;
            this.carro.Location = new System.Drawing.Point(267, 79);
            this.carro.Name = "carro";
            this.carro.Size = new System.Drawing.Size(50, 17);
            this.carro.TabIndex = 8;
            this.carro.TabStop = true;
            this.carro.Text = "Carro";
            this.carro.UseVisualStyleBackColor = true;
            // 
            // caminhao
            // 
            this.caminhao.AutoSize = true;
            this.caminhao.Location = new System.Drawing.Point(339, 79);
            this.caminhao.Name = "caminhao";
            this.caminhao.Size = new System.Drawing.Size(72, 17);
            this.caminhao.TabIndex = 9;
            this.caminhao.TabStop = true;
            this.caminhao.Text = "Caminhão";
            this.caminhao.UseVisualStyleBackColor = true;
            // 
            // Serviço
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 283);
            this.Controls.Add(this.caminhao);
            this.Controls.Add(this.carro);
            this.Controls.Add(this.moto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClienteCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.precoBnr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlacaBox);
            this.Name = "Serviço";
            this.Text = "Cadastrar Serviço";
            this.Load += new System.EventHandler(this.Serviço_Load);
            ((System.ComponentModel.ISupportInitialize)(this.precoBnr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlacaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown precoBnr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ClienteCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton moto;
        private System.Windows.Forms.RadioButton carro;
        private System.Windows.Forms.RadioButton caminhao;
    }
}