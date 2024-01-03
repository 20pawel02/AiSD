namespace dodawanie_w_slupku
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
            start_button = new Button();
            nud_A = new NumericUpDown();
            nud_B = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nud_A).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_B).BeginInit();
            SuspendLayout();
            // 
            // start_button
            // 
            start_button.Location = new Point(303, 136);
            start_button.Name = "start_button";
            start_button.Size = new Size(94, 29);
            start_button.TabIndex = 0;
            start_button.Text = "start";
            start_button.UseVisualStyleBackColor = true;
            start_button.Click += start_button_Click;
            // 
            // nud_A
            // 
            nud_A.Location = new Point(303, 215);
            nud_A.Name = "nud_A";
            nud_A.Size = new Size(150, 27);
            nud_A.TabIndex = 2;
            // 
            // nud_B
            // 
            nud_B.Location = new Point(303, 266);
            nud_B.Name = "nud_B";
            nud_B.Size = new Size(150, 27);
            nud_B.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nud_B);
            Controls.Add(nud_A);
            Controls.Add(start_button);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nud_A).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_B).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button start_button;
        private NumericUpDown nud_A;
        private NumericUpDown nud_B;
    }
}