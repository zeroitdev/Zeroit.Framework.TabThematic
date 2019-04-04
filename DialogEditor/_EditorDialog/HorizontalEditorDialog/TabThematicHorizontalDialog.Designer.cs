namespace Zeroit.Framework.TabThematic.DialogEditor
{
    partial class TabThematicHorizontalDialog
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
            this.backgroundTheme = new Zeroit.Framework.TabThematic.ThemeManagers.SpicyLips();
            this.closeBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mainControl_SlideSpeed_ComboBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.mainControl_TabStyle_ComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundTheme.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainControl_SlideSpeed_ComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundTheme
            // 
            this.backgroundTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.backgroundTheme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.backgroundTheme.Colors = new Zeroit.Framework.TabThematic.ThemeManagers.Bloom[0];
            this.backgroundTheme.Controls.Add(this.closeBtn);
            this.backgroundTheme.Controls.Add(this.okBtn);
            this.backgroundTheme.Controls.Add(this.cancelBtn);
            this.backgroundTheme.Controls.Add(this.groupBox1);
            this.backgroundTheme.Customization = "";
            this.backgroundTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundTheme.Font = new System.Drawing.Font("Verdana", 9F);
            this.backgroundTheme.Image = null;
            this.backgroundTheme.Location = new System.Drawing.Point(0, 0);
            this.backgroundTheme.Movable = true;
            this.backgroundTheme.Name = "backgroundTheme";
            this.backgroundTheme.NoRounding = false;
            this.backgroundTheme.Sizable = false;
            this.backgroundTheme.Size = new System.Drawing.Size(1183, 667);
            this.backgroundTheme.SmartBounds = true;
            this.backgroundTheme.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.backgroundTheme.TabIndex = 0;
            this.backgroundTheme.Text = "TabThematic Horizontal Editor";
            this.backgroundTheme.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.backgroundTheme.Transparent = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Verdana", 7F);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(1164, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(19, 19);
            this.closeBtn.TabIndex = 63;
            this.closeBtn.Text = "x";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBtn.UseCompatibleTextRendering = true;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.okBtn.Location = new System.Drawing.Point(955, 601);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(96, 39);
            this.okBtn.TabIndex = 61;
            this.okBtn.Text = "&OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancelBtn.Location = new System.Drawing.Point(1057, 601);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(96, 39);
            this.cancelBtn.TabIndex = 62;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mainControl_SlideSpeed_ComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mainControl_TabStyle_ComboBox);
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(26, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 132);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(17, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 89;
            this.label2.Text = "Slide Speed";
            // 
            // mainControl_SlideSpeed_ComboBox
            // 
            this.mainControl_SlideSpeed_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mainControl_SlideSpeed_ComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mainControl_SlideSpeed_ComboBox.ForeColor = System.Drawing.Color.White;
            this.mainControl_SlideSpeed_ComboBox.Location = new System.Drawing.Point(162, 99);
            this.mainControl_SlideSpeed_ComboBox.Name = "mainControl_SlideSpeed_ComboBox";
            this.mainControl_SlideSpeed_ComboBox.Size = new System.Drawing.Size(117, 25);
            this.mainControl_SlideSpeed_ComboBox.TabIndex = 64;
            this.mainControl_SlideSpeed_ComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainControl_SlideSpeed_ComboBox.ValueChanged += new System.EventHandler(this.mainControl_SlideSpeed_ComboBox_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 82;
            this.label1.Text = "Tab Style";
            // 
            // mainControl_TabStyle_ComboBox
            // 
            this.mainControl_TabStyle_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mainControl_TabStyle_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainControl_TabStyle_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainControl_TabStyle_ComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mainControl_TabStyle_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mainControl_TabStyle_ComboBox.FormattingEnabled = true;
            this.mainControl_TabStyle_ComboBox.Location = new System.Drawing.Point(162, 42);
            this.mainControl_TabStyle_ComboBox.Name = "mainControl_TabStyle_ComboBox";
            this.mainControl_TabStyle_ComboBox.Size = new System.Drawing.Size(117, 25);
            this.mainControl_TabStyle_ComboBox.Sorted = true;
            this.mainControl_TabStyle_ComboBox.TabIndex = 83;
            this.mainControl_TabStyle_ComboBox.SelectedIndexChanged += new System.EventHandler(this.mainControl_TabStyle_ComboBox_SelectedIndexChanged);
            // 
            // TabThematicHorizontalDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 667);
            this.Controls.Add(this.backgroundTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TabThematicHorizontalDialog";
            this.Text = "TabThematicHorizontal Dialog";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.backgroundTheme.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainControl_SlideSpeed_ComboBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ThemeManagers.SpicyLips backgroundTheme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox mainControl_TabStyle_ComboBox;
        public System.Windows.Forms.Button okBtn;
        public System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown mainControl_SlideSpeed_ComboBox;
    }
}