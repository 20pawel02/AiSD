namespace select_sort
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
            tbInput = new Label();
            button_start = new Button();
            lbl_wynik = new Label();
            SuspendLayout();
            // 
            // tbInput
            // 
            tbInput.AutoSize = true;
            tbInput.Location = new Point(316, 226);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(53, 20);
            tbInput.TabIndex = 0;
            tbInput.Text = "2 1 3 7";
            tbInput.Click += tbInput_Click;
            // 
            // button_start
            // 
            button_start.Location = new Point(316, 149);
            button_start.Name = "button_start";
            button_start.Size = new Size(94, 29);
            button_start.TabIndex = 1;
            button_start.Text = "start";
            button_start.UseVisualStyleBackColor = true;
            button_start.Click += button_start_Click;
            // 
            // lbl_wynik
            // 
            lbl_wynik.AutoSize = true;
            lbl_wynik.Location = new Point(312, 295);
            lbl_wynik.Name = "lbl_wynik";
            lbl_wynik.Size = new Size(53, 20);
            lbl_wynik.TabIndex = 2;
            lbl_wynik.Text = "wynik: ";
            lbl_wynik.Click += lbl_wynik_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_wynik);
            Controls.Add(button_start);
            Controls.Add(tbInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tbInput;
        private Button button_start;
        private Label lbl_wynik;
    }
}