namespace Random_NoteBooks
{
    partial class Title
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Title));
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.comboBoxSaved = new System.Windows.Forms.ComboBox();
            this.labelSaved = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNew.Location = new System.Drawing.Point(89, 84);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(153, 42);
            this.buttonNew.TabIndex = 1;
            this.buttonNew.Text = "Save";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCopy.Location = new System.Drawing.Point(491, 308);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 42);
            this.buttonCopy.TabIndex = 2;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOutput.Location = new System.Drawing.Point(12, 359);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(975, 231);
            this.textBoxOutput.TabIndex = 3;
            this.textBoxOutput.TextChanged += new System.EventHandler(this.textBoxOutput_TextChanged);
            // 
            // comboBoxSaved
            // 
            this.comboBoxSaved.FormattingEnabled = true;
            this.comboBoxSaved.Location = new System.Drawing.Point(101, 316);
            this.comboBoxSaved.Name = "comboBoxSaved";
            this.comboBoxSaved.Size = new System.Drawing.Size(215, 28);
            this.comboBoxSaved.TabIndex = 4;
            this.comboBoxSaved.Text = "Saved Notes";
            this.comboBoxSaved.SelectedIndexChanged += new System.EventHandler(this.comboBoxSaved_SelectedIndexChanged);
            // 
            // labelSaved
            // 
            this.labelSaved.AutoSize = true;
            this.labelSaved.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSaved.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSaved.Location = new System.Drawing.Point(12, 319);
            this.labelSaved.Name = "labelSaved";
            this.labelSaved.Size = new System.Drawing.Size(83, 20);
            this.labelSaved.TabIndex = 5;
            this.labelSaved.Text = "Saved List";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGenerate.Location = new System.Drawing.Point(322, 308);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(153, 42);
            this.buttonGenerate.TabIndex = 6;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxTitle.Location = new System.Drawing.Point(89, 52);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(153, 26);
            this.textBoxTitle.TabIndex = 7;
            // 
            // textBoxInput
            // 
            this.textBoxInput.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxInput.Location = new System.Drawing.Point(334, 49);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(653, 240);
            this.textBoxInput.TabIndex = 8;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Black;
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitle.Location = new System.Drawing.Point(8, 55);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(73, 20);
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "New Title";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelInput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInput.Location = new System.Drawing.Point(255, 55);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(74, 20);
            this.labelInput.TabIndex = 10;
            this.labelInput.Text = "New Text";
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuit.Location = new System.Drawing.Point(584, 308);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(204, 42);
            this.buttonQuit.TabIndex = 11;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Random_NoteBooks.Properties.Resources.Moai_wallpapers;
            this.ClientSize = new System.Drawing.Size(1012, 602);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.labelSaved);
            this.Controls.Add(this.comboBoxSaved);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Title";
            this.Text = "Random NoteBooks";
            this.Load += new System.EventHandler(this.Title_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.ComboBox comboBoxSaved;
        private System.Windows.Forms.Label labelSaved;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Button buttonQuit;
    }
}

