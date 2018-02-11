namespace Assessment_2B
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
            this.lbl_joke = new System.Windows.Forms.Label();
            this.btn_setup = new System.Windows.Forms.Button();
            this.btn_punchline = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_joke
            // 
            this.lbl_joke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_joke.Location = new System.Drawing.Point(104, 9);
            this.lbl_joke.Name = "lbl_joke";
            this.lbl_joke.Size = new System.Drawing.Size(199, 65);
            this.lbl_joke.TabIndex = 0;
            this.lbl_joke.Text = "Ready for a Joke?";
            this.lbl_joke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_setup
            // 
            this.btn_setup.Location = new System.Drawing.Point(23, 16);
            this.btn_setup.Name = "btn_setup";
            this.btn_setup.Size = new System.Drawing.Size(75, 23);
            this.btn_setup.TabIndex = 1;
            this.btn_setup.Text = "Setup";
            this.btn_setup.UseVisualStyleBackColor = true;
            this.btn_setup.Click += new System.EventHandler(this.btn_setup_Click);
            // 
            // btn_punchline
            // 
            this.btn_punchline.Location = new System.Drawing.Point(23, 55);
            this.btn_punchline.Name = "btn_punchline";
            this.btn_punchline.Size = new System.Drawing.Size(75, 23);
            this.btn_punchline.TabIndex = 2;
            this.btn_punchline.Text = "Punchline";
            this.btn_punchline.UseVisualStyleBackColor = true;
            this.btn_punchline.Click += new System.EventHandler(this.btn_punchline_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(23, 94);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(217, 94);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(313, 130);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_punchline);
            this.Controls.Add(this.btn_setup);
            this.Controls.Add(this.lbl_joke);
            this.Name = "Form1";
            this.Text = "Assessment 2B";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_joke;
        private System.Windows.Forms.Button btn_setup;
        private System.Windows.Forms.Button btn_punchline;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_close;
    }
}

