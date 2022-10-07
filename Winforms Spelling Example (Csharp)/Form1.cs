using System;
using System.Windows.Forms;

namespace Winforms_Spelling_Example__Csharp_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Items.AddRange(winformsSpell1.AvailableLanguages.ToArray());
                comboBox1.Text = winformsSpell1.LanguageID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                comboBox2.Items.AddRange(winformsSpell2.AvailableLanguages.ToArray());
                comboBox2.Text = winformsSpell2.LanguageID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            winformsSpell1.SetLicense("", "");
            winformsSpell2.SetLicense("", "");

            winformsSpell1.InitSpelling_AllTextBoxes();
            winformsSpell2.InitSpelling_AllTextBoxes();

            winformsSpell1.SpellCheckDialogCurrentTextboxShortcutKey = Shortcut.F7;
            winformsSpell2.SpellCheckDialogCurrentTextboxShortcutKey = Shortcut.F7;

            textBox3.Text = "some longer text is in this textbox. It contains a speling mistake or twwo\r\n\r\nPress F7 to open a spell checking dialog";
            textBox6.Text = "some longer text is in this textbox. It contains a speling mistake or twwo\r\n\r\nPress F7 to open a spell checking dialog\r\n\r\nthis textbox also has an existing context menu";


        }

        private void btnLang1_Click(object sender, EventArgs e)
        {
            winformsSpell1.LanguageID = comboBox1.Text;
        }

        private void btnLang2_Click(object sender, EventArgs e)
        {
            winformsSpell2.LanguageID = comboBox2.Text;
        }

        private void chkBoxInclude1_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkBoxInclude1.Checked)
                winformsSpell1.ExcludedTextBoxes.Add(ref textBox4);
            else
                winformsSpell1.ExcludedTextBoxes.Remove(ref textBox4);
        }

        private void chkBoxInclude2_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkBoxInclude2.Checked)
                winformsSpell2.ExcludedTextBoxes.Add(ref textBox5);
            else
                winformsSpell2.ExcludedTextBoxes.Remove(ref textBox5);
        }

        private void chkWordWrap1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.WordWrap = !textBox3.WordWrap;
        }

        private void chkWordWrap2_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.WordWrap = !textBox6.WordWrap;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox6.SelectedText != "")
            {
                Clipboard.SetText(textBox6.SelectedText);
                textBox6.SelectedText = "";
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox6.SelectedText != "")
            {
                Clipboard.SetText(textBox6.SelectedText);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.SelectedText = Clipboard.GetText();
        }
    }
}
