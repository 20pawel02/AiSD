namespace ciag_fib
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
            button = new Button();
            nudNumberN = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudNumberN).BeginInit();
            SuspendLayout();
            // 
            // button
            // 
            button.Location = new Point(305, 171);
            button.Name = "button";
            button.Size = new Size(94, 29);
            button.TabIndex = 0;
            button.Text = "przycisk";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // nudNumberN
            // 
            nudNumberN.Location = new Point(272, 221);
            nudNumberN.Name = "nudNumberN";
            nudNumberN.Size = new Size(150, 27);
            nudNumberN.TabIndex = 1;
            nudNumberN.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nudNumberN);
            Controls.Add(button);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudNumberN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button;
        private NumericUpDown nudNumberN;
    }
}