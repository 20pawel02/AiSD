namespace bubble_sort
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
            przycisk_start = new Button();
            tbInput = new Label();
            lbl_wynik = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // przycisk_start
            // 
            przycisk_start.Location = new Point(296, 192);
            przycisk_start.Name = "przycisk_start";
            przycisk_start.Size = new Size(94, 29);
            przycisk_start.TabIndex = 0;
            przycisk_start.Text = "start";
            przycisk_start.UseVisualStyleBackColor = true;
            przycisk_start.Click += przycisk_start_Click;
            // 
            // tbInput
            // 
            tbInput.AutoSize = true;
            tbInput.Location = new Point(296, 242);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(53, 20);
            tbInput.TabIndex = 1;
            tbInput.Text = "2 7 4 6";
            tbInput.Click += tbInput_Click;
            // 
            // lbl_wynik
            // 
            lbl_wynik.AutoSize = true;
            lbl_wynik.Location = new Point(296, 287);
            lbl_wynik.Name = "lbl_wynik";
            lbl_wynik.Size = new Size(0, 20);
            lbl_wynik.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 287);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 3;
            label1.Text = "wynik: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lbl_wynik);
            Controls.Add(tbInput);
            Controls.Add(przycisk_start);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button przycisk_start;
        private Label tbInput;
        private Label lbl_wynik;
        private Label label1;
    }
}