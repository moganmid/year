﻿namespace year
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
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("BOOZY", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(90, 36);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 0;
            label1.Text = "Введите год";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("BOOZY", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(90, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 41);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("BOOZY", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(90, 143);
            button1.Name = "button1";
            button1.Size = new Size(156, 57);
            button1.TabIndex = 2;
            button1.Text = "НАЖАТЬ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("BOOZY", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(90, 226);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 41);
            textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 322);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Високосный год";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
    }
}