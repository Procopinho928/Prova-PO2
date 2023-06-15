namespace Prova_POO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btn_cadastrar = new Button();
            txt_valor = new TextBox();
            txt_pis = new TextBox();
            txt_icms = new TextBox();
            txt_confins = new TextBox();
            txt_lucro = new TextBox();
            lbl_valorVenda = new Label();
            combo_unidade = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(341, 37);
            label1.TabIndex = 0;
            label1.Text = "Cadastramento De Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 106);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Unidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 154);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "Descrição:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 208);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Valor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(166, 208);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 5;
            label6.Text = "PIS:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 276);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "ICMS:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(166, 276);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 7;
            label8.Text = "CONFINS:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 347);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 8;
            label9.Text = "Lucro:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 396);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 9;
            label10.Text = "Valor de venda:";
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(416, 193);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(125, 70);
            btn_cadastrar.TabIndex = 10;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += button1_Click;
            // 
            // txt_valor
            // 
            txt_valor.Location = new Point(54, 205);
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(100, 23);
            txt_valor.TabIndex = 11;
            // 
            // txt_pis
            // 
            txt_pis.Location = new Point(198, 208);
            txt_pis.Name = "txt_pis";
            txt_pis.Size = new Size(100, 23);
            txt_pis.TabIndex = 12;
            // 
            // txt_icms
            // 
            txt_icms.Location = new Point(54, 273);
            txt_icms.Name = "txt_icms";
            txt_icms.Size = new Size(100, 23);
            txt_icms.TabIndex = 13;
            // 
            // txt_confins
            // 
            txt_confins.Location = new Point(223, 273);
            txt_confins.Name = "txt_confins";
            txt_confins.Size = new Size(100, 23);
            txt_confins.TabIndex = 14;
            // 
            // txt_lucro
            // 
            txt_lucro.Location = new Point(54, 339);
            txt_lucro.Name = "txt_lucro";
            txt_lucro.Size = new Size(100, 23);
            txt_lucro.TabIndex = 15;
            // 
            // lbl_valorVenda
            // 
            lbl_valorVenda.AutoSize = true;
            lbl_valorVenda.Location = new Point(105, 396);
            lbl_valorVenda.Name = "lbl_valorVenda";
            lbl_valorVenda.Size = new Size(44, 15);
            lbl_valorVenda.TabIndex = 16;
            lbl_valorVenda.Text = "label11";
            // 
            // combo_unidade
            // 
            combo_unidade.FormattingEnabled = true;
            combo_unidade.Items.AddRange(new object[] { "UN", "LT", "KL" });
            combo_unidade.Location = new Point(355, 103);
            combo_unidade.Name = "combo_unidade";
            combo_unidade.Size = new Size(121, 23);
            combo_unidade.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 23);
            textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 23);
            textBox2.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(combo_unidade);
            Controls.Add(lbl_valorVenda);
            Controls.Add(txt_lucro);
            Controls.Add(txt_confins);
            Controls.Add(txt_icms);
            Controls.Add(txt_pis);
            Controls.Add(txt_valor);
            Controls.Add(btn_cadastrar);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btn_cadastrar;
        private TextBox txt_valor;
        private TextBox txt_pis;
        private TextBox txt_icms;
        private TextBox txt_confins;
        private TextBox txt_lucro;
        private Label lbl_valorVenda;
        private ComboBox combo_unidade;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}