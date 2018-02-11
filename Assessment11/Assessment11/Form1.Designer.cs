namespace Assessment11
{
    partial class Assessment11
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.listBoxSummary = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblExpNumb = new System.Windows.Forms.Label();
            this.lblExpDescrp = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblResultColor = new System.Windows.Forms.Label();
            this.lblResultVolume = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxExpNumb = new System.Windows.Forms.TextBox();
            this.txtBoxExpDescrp = new System.Windows.Forms.TextBox();
            this.txtBoxResultWeight = new System.Windows.Forms.TextBox();
            this.txtBoxResultVolume = new System.Windows.Forms.TextBox();
            this.combBoxColor = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 38);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(12, 83);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 129);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listBoxSummary
            // 
            this.listBoxSummary.FormattingEnabled = true;
            this.listBoxSummary.Location = new System.Drawing.Point(498, 38);
            this.listBoxSummary.Name = "listBoxSummary";
            this.listBoxSummary.Size = new System.Drawing.Size(272, 277);
            this.listBoxSummary.TabIndex = 3;
            this.listBoxSummary.DoubleClick += new System.EventHandler(this.listBoxSummary_DoubleClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(147, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblExpNumb
            // 
            this.lblExpNumb.AutoSize = true;
            this.lblExpNumb.Location = new System.Drawing.Point(147, 78);
            this.lblExpNumb.Name = "lblExpNumb";
            this.lblExpNumb.Size = new System.Drawing.Size(99, 13);
            this.lblExpNumb.TabIndex = 5;
            this.lblExpNumb.Text = "Experiment Number";
            // 
            // lblExpDescrp
            // 
            this.lblExpDescrp.AutoSize = true;
            this.lblExpDescrp.Location = new System.Drawing.Point(147, 119);
            this.lblExpDescrp.Name = "lblExpDescrp";
            this.lblExpDescrp.Size = new System.Drawing.Size(115, 13);
            this.lblExpDescrp.TabIndex = 6;
            this.lblExpDescrp.Text = "Experiment Description";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(147, 164);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(74, 13);
            this.lblWeight.TabIndex = 7;
            this.lblWeight.Text = "Result Weight";
            // 
            // lblResultColor
            // 
            this.lblResultColor.AutoSize = true;
            this.lblResultColor.Location = new System.Drawing.Point(147, 214);
            this.lblResultColor.Name = "lblResultColor";
            this.lblResultColor.Size = new System.Drawing.Size(64, 13);
            this.lblResultColor.TabIndex = 8;
            this.lblResultColor.Text = "Result Color";
            // 
            // lblResultVolume
            // 
            this.lblResultVolume.AutoSize = true;
            this.lblResultVolume.Location = new System.Drawing.Point(147, 259);
            this.lblResultVolume.Name = "lblResultVolume";
            this.lblResultVolume.Size = new System.Drawing.Size(75, 13);
            this.lblResultVolume.TabIndex = 9;
            this.lblResultVolume.Text = "Result Volume";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(297, 35);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxName.TabIndex = 10;
            // 
            // txtBoxExpNumb
            // 
            this.txtBoxExpNumb.Location = new System.Drawing.Point(297, 75);
            this.txtBoxExpNumb.Name = "txtBoxExpNumb";
            this.txtBoxExpNumb.Size = new System.Drawing.Size(100, 20);
            this.txtBoxExpNumb.TabIndex = 11;
            // 
            // txtBoxExpDescrp
            // 
            this.txtBoxExpDescrp.Location = new System.Drawing.Point(297, 116);
            this.txtBoxExpDescrp.Name = "txtBoxExpDescrp";
            this.txtBoxExpDescrp.Size = new System.Drawing.Size(100, 20);
            this.txtBoxExpDescrp.TabIndex = 12;
            // 
            // txtBoxResultWeight
            // 
            this.txtBoxResultWeight.Location = new System.Drawing.Point(297, 161);
            this.txtBoxResultWeight.Name = "txtBoxResultWeight";
            this.txtBoxResultWeight.Size = new System.Drawing.Size(100, 20);
            this.txtBoxResultWeight.TabIndex = 13;
            // 
            // txtBoxResultVolume
            // 
            this.txtBoxResultVolume.Location = new System.Drawing.Point(297, 256);
            this.txtBoxResultVolume.Name = "txtBoxResultVolume";
            this.txtBoxResultVolume.Size = new System.Drawing.Size(100, 20);
            this.txtBoxResultVolume.TabIndex = 14;
            // 
            // combBoxColor
            // 
            this.combBoxColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combBoxColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combBoxColor.FormattingEnabled = true;
            this.combBoxColor.Location = new System.Drawing.Point(297, 211);
            this.combBoxColor.Name = "combBoxColor";
            this.combBoxColor.Size = new System.Drawing.Size(100, 21);
            this.combBoxColor.TabIndex = 15;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 253);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 292);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Assessment11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 337);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.combBoxColor);
            this.Controls.Add(this.txtBoxResultVolume);
            this.Controls.Add(this.txtBoxResultWeight);
            this.Controls.Add(this.txtBoxExpDescrp);
            this.Controls.Add(this.txtBoxExpNumb);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblResultVolume);
            this.Controls.Add(this.lblResultColor);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblExpDescrp);
            this.Controls.Add(this.lblExpNumb);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.listBoxSummary);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnCreate);
            this.Name = "Assessment11";
            this.Text = "Assessment11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listBoxSummary;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblExpNumb;
        private System.Windows.Forms.Label lblExpDescrp;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblResultColor;
        private System.Windows.Forms.Label lblResultVolume;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxExpNumb;
        private System.Windows.Forms.TextBox txtBoxExpDescrp;
        private System.Windows.Forms.TextBox txtBoxResultWeight;
        private System.Windows.Forms.TextBox txtBoxResultVolume;
        private System.Windows.Forms.ComboBox combBoxColor;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
    }
}

