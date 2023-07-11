namespace Pedra
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tesoura = new Button();
            pedra = new Button();
            papel = new Button();
            label5 = new Label();
            label6 = new Label();
            mostra = new Label();
            label8 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = Properties.Resources.branco;
            pictureBox2.Location = new Point(421, 111);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(162, 141);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.branco;
            pictureBox1.Image = Properties.Resources.branco;
            pictureBox1.Location = new Point(121, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 76);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 43);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 4;
            label2.Text = "Você";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(475, 76);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 5;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(475, 43);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 6;
            label4.Text = "Bot";
            label4.Click += label4_Click;
            // 
            // tesoura
            // 
            tesoura.Location = new Point(203, 305);
            tesoura.Name = "tesoura";
            tesoura.Size = new Size(94, 29);
            tesoura.TabIndex = 7;
            tesoura.Text = "Tesoura";
            tesoura.UseVisualStyleBackColor = true;
            tesoura.Click += button1_Click;
            // 
            // pedra
            // 
            pedra.Location = new Point(303, 305);
            pedra.Name = "pedra";
            pedra.Size = new Size(94, 29);
            pedra.TabIndex = 8;
            pedra.Text = "Pedra";
            pedra.UseVisualStyleBackColor = true;
            pedra.Click += pedra_Click;
            // 
            // papel
            // 
            papel.Location = new Point(403, 305);
            papel.Name = "papel";
            papel.Size = new Size(94, 29);
            papel.TabIndex = 9;
            papel.Text = "Papel";
            papel.UseVisualStyleBackColor = true;
            papel.Click += papel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(174, 262);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 10;
            label5.Text = "0 ponto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(475, 262);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 11;
            label6.Text = "0 ponto";
            // 
            // mostra
            // 
            mostra.AutoSize = true;
            mostra.Location = new Point(325, 169);
            mostra.Name = "mostra";
            mostra.Size = new Size(0, 20);
            mostra.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(316, 64);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 13;
            label8.Text = "contador";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(339, 93);
            label7.Name = "label7";
            label7.Size = new Size(17, 20);
            label7.TabIndex = 14;
            label7.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 418);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(mostra);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(papel);
            Controls.Add(pedra);
            Controls.Add(tesoura);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button tesoura;
        private Button pedra;
        private Button papel;
        private Label label5;
        private Label label6;
        private Label mostra;
        private Label label8;
        private Label label7;
    }
}