namespace Winforms_Spelling_Example__Csharp_
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkWordWrap1 = new System.Windows.Forms.CheckBox();
            this.winformsSpell1 = new Zoople.WinformsSpell();
            this.chkBoxInclude1 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkWordWrap2 = new System.Windows.Forms.CheckBox();
            this.winformsSpell2 = new Zoople.WinformsSpell();
            this.chkBoxInclude2 = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnLang1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnLang2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkWordWrap1);
            this.groupBox1.Controls.Add(this.winformsSpell1);
            this.groupBox1.Controls.Add(this.chkBoxInclude1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 334);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Language #1";
            // 
            // chkWordWrap1
            // 
            this.chkWordWrap1.AutoSize = true;
            this.chkWordWrap1.Location = new System.Drawing.Point(9, 204);
            this.chkWordWrap1.Name = "chkWordWrap1";
            this.chkWordWrap1.Size = new System.Drawing.Size(104, 22);
            this.chkWordWrap1.TabIndex = 8;
            this.chkWordWrap1.Text = "Word Wrap";
            this.chkWordWrap1.UseVisualStyleBackColor = true;
            this.chkWordWrap1.CheckedChanged += new System.EventHandler(this.chkWordWrap1_CheckedChanged);
            // 
            // winformsSpell1
            // 
            this.winformsSpell1.Location = new System.Drawing.Point(176, 178);
            this.winformsSpell1.Margin = new System.Windows.Forms.Padding(4);
            this.winformsSpell1.MaximumSize = new System.Drawing.Size(370, 89);
            this.winformsSpell1.MinimumSize = new System.Drawing.Size(370, 89);
            this.winformsSpell1.Name = "winformsSpell1";
            this.winformsSpell1.Size = new System.Drawing.Size(370, 89);
            this.winformsSpell1.SpellCheckDialogCurrentTextboxShortcutKey = System.Windows.Forms.Shortcut.F7;
            this.winformsSpell1.TabIndex = 6;
            // 
            // chkBoxInclude1
            // 
            this.chkBoxInclude1.AutoSize = true;
            this.chkBoxInclude1.Checked = true;
            this.chkBoxInclude1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxInclude1.Location = new System.Drawing.Point(8, 274);
            this.chkBoxInclude1.Name = "chkBoxInclude1";
            this.chkBoxInclude1.Size = new System.Drawing.Size(300, 22);
            this.chkBoxInclude1.TabIndex = 5;
            this.chkBoxInclude1.Text = "Include this textbox in the spelling checker";
            this.chkBoxInclude1.UseVisualStyleBackColor = true;
            this.chkBoxInclude1.CheckedChanged += new System.EventHandler(this.chkBoxInclude1_CheckedChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(8, 302);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(382, 24);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "an obvious speling mistake ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 90);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(382, 108);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(382, 24);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 24);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkWordWrap2);
            this.groupBox2.Controls.Add(this.winformsSpell2);
            this.groupBox2.Controls.Add(this.chkBoxInclude2);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(409, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 334);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Language #2";
            // 
            // chkWordWrap2
            // 
            this.chkWordWrap2.AutoSize = true;
            this.chkWordWrap2.Location = new System.Drawing.Point(7, 204);
            this.chkWordWrap2.Name = "chkWordWrap2";
            this.chkWordWrap2.Size = new System.Drawing.Size(104, 22);
            this.chkWordWrap2.TabIndex = 12;
            this.chkWordWrap2.Text = "Word Wrap";
            this.chkWordWrap2.UseVisualStyleBackColor = true;
            this.chkWordWrap2.CheckedChanged += new System.EventHandler(this.chkWordWrap2_CheckedChanged);
            // 
            // winformsSpell2
            // 
            this.winformsSpell2.Location = new System.Drawing.Point(116, 178);
            this.winformsSpell2.Margin = new System.Windows.Forms.Padding(4);
            this.winformsSpell2.MaximumSize = new System.Drawing.Size(370, 89);
            this.winformsSpell2.MinimumSize = new System.Drawing.Size(370, 89);
            this.winformsSpell2.Name = "winformsSpell2";
            this.winformsSpell2.Size = new System.Drawing.Size(370, 89);
            this.winformsSpell2.SpellCheckDialogCurrentTextboxShortcutKey = System.Windows.Forms.Shortcut.F7;
            this.winformsSpell2.TabIndex = 10;
            // 
            // chkBoxInclude2
            // 
            this.chkBoxInclude2.AutoSize = true;
            this.chkBoxInclude2.Checked = true;
            this.chkBoxInclude2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxInclude2.Location = new System.Drawing.Point(6, 274);
            this.chkBoxInclude2.Name = "chkBoxInclude2";
            this.chkBoxInclude2.Size = new System.Drawing.Size(300, 22);
            this.chkBoxInclude2.TabIndex = 9;
            this.chkBoxInclude2.Text = "Include this textbox in the spelling checker";
            this.chkBoxInclude2.UseVisualStyleBackColor = true;
            this.chkBoxInclude2.CheckedChanged += new System.EventHandler(this.chkBoxInclude2_CheckedChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 302);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(382, 24);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "an obvious speling mistake ";
            // 
            // textBox6
            // 
            this.textBox6.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox6.Location = new System.Drawing.Point(7, 90);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox6.Size = new System.Drawing.Size(382, 108);
            this.textBox6.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 70);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 58);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(382, 24);
            this.textBox7.TabIndex = 6;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(6, 26);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(382, 24);
            this.textBox8.TabIndex = 5;
            // 
            // btnLang1
            // 
            this.btnLang1.Location = new System.Drawing.Point(182, 22);
            this.btnLang1.Name = "btnLang1";
            this.btnLang1.Size = new System.Drawing.Size(105, 32);
            this.btnLang1.TabIndex = 22;
            this.btnLang1.Text = "Change Language";
            this.btnLang1.UseVisualStyleBackColor = true;
            this.btnLang1.Click += new System.EventHandler(this.btnLang1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // btnLang2
            // 
            this.btnLang2.Location = new System.Drawing.Point(584, 22);
            this.btnLang2.Name = "btnLang2";
            this.btnLang2.Size = new System.Drawing.Size(105, 32);
            this.btnLang2.TabIndex = 24;
            this.btnLang2.Text = "Change Language";
            this.btnLang2.UseVisualStyleBackColor = true;
            this.btnLang2.Click += new System.EventHandler(this.btnLang2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(411, 28);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(167, 21);
            this.comboBox2.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 402);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnLang2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnLang1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winforms Spelling Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button btnLang1;
        internal System.Windows.Forms.ComboBox comboBox1;
        internal System.Windows.Forms.Button btnLang2;
        internal System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.CheckBox chkBoxInclude1;
        private System.Windows.Forms.CheckBox chkBoxInclude2;
        private Zoople.WinformsSpell winformsSpell1;
        private Zoople.WinformsSpell winformsSpell2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        internal System.Windows.Forms.CheckBox chkWordWrap1;
        internal System.Windows.Forms.CheckBox chkWordWrap2;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    }
}

