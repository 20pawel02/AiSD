﻿namespace lab2
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
            button1 = new Button();
            label2 = new Label();
            tbInput = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(340, 352);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Posortuj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_BubbleSort;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 207);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            label2.Click += lbl_wynik;
            // 
            // tbInput
            // 
            tbInput.Location = new Point(208, 106);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(403, 27);
            tbInput.TabIndex = 4;
            tbInput.TextChanged += tbl_Input;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbInput);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label2;
        private TextBox tbInput;
    }
}