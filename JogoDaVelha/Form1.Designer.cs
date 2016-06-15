namespace JogoDaVelha
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.lblVitoriasX = new System.Windows.Forms.Label();
            this.lblVitoriasO = new System.Windows.Forms.Label();
            this.lblEmpate = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnZerarPont = new System.Windows.Forms.Button();
            this.lblDesenv = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(205, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 62);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(205, 81);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 62);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(125, 81);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 62);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(45, 80);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 62);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(45, 149);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 62);
            this.button7.TabIndex = 8;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(125, 149);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 62);
            this.button8.TabIndex = 7;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(205, 149);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 62);
            this.button9.TabIndex = 6;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // lblVitoriasX
            // 
            this.lblVitoriasX.AutoSize = true;
            this.lblVitoriasX.Location = new System.Drawing.Point(201, 251);
            this.lblVitoriasX.Name = "lblVitoriasX";
            this.lblVitoriasX.Size = new System.Drawing.Size(63, 13);
            this.lblVitoriasX.TabIndex = 9;
            this.lblVitoriasX.Text = "Vitórias X: 0";
            // 
            // lblVitoriasO
            // 
            this.lblVitoriasO.AutoSize = true;
            this.lblVitoriasO.Location = new System.Drawing.Point(201, 281);
            this.lblVitoriasO.Name = "lblVitoriasO";
            this.lblVitoriasO.Size = new System.Drawing.Size(64, 13);
            this.lblVitoriasO.TabIndex = 10;
            this.lblVitoriasO.Text = "Vitórias O: 0";
            // 
            // lblEmpate
            // 
            this.lblEmpate.AutoSize = true;
            this.lblEmpate.Location = new System.Drawing.Point(201, 312);
            this.lblEmpate.Name = "lblEmpate";
            this.lblEmpate.Size = new System.Drawing.Size(60, 13);
            this.lblEmpate.TabIndex = 11;
            this.lblEmpate.Text = "Empates: 0";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(45, 251);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(99, 36);
            this.btnNewGame.TabIndex = 12;
            this.btnNewGame.Text = "Novo Jogo";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnZerarPont
            // 
            this.btnZerarPont.Location = new System.Drawing.Point(45, 293);
            this.btnZerarPont.Name = "btnZerarPont";
            this.btnZerarPont.Size = new System.Drawing.Size(99, 35);
            this.btnZerarPont.TabIndex = 13;
            this.btnZerarPont.Text = "Zerar Pontuação";
            this.btnZerarPont.UseVisualStyleBackColor = true;
            this.btnZerarPont.Click += new System.EventHandler(this.btnZerarPont_Click);
            // 
            // lblDesenv
            // 
            this.lblDesenv.AutoSize = true;
            this.lblDesenv.CausesValidation = false;
            this.lblDesenv.Location = new System.Drawing.Point(51, 343);
            this.lblDesenv.Name = "lblDesenv";
            this.lblDesenv.Size = new System.Drawing.Size(204, 13);
            this.lblDesenv.TabIndex = 14;
            this.lblDesenv.TabStop = true;
            this.lblDesenv.Text = "Desenvolvido por Adriano Zavareze Righi";
            this.lblDesenv.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDesenv_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 368);
            this.Controls.Add(this.lblDesenv);
            this.Controls.Add(this.btnZerarPont);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblEmpate);
            this.Controls.Add(this.lblVitoriasO);
            this.Controls.Add(this.lblVitoriasX);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Jogo da Velha 1.0b";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label lblVitoriasX;
        private System.Windows.Forms.Label lblVitoriasO;
        private System.Windows.Forms.Label lblEmpate;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnZerarPont;
        private System.Windows.Forms.LinkLabel lblDesenv;
    }
}

