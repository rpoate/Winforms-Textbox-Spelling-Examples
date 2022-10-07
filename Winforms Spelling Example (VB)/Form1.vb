Imports Zoople

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            comboBox1.Items.AddRange(winformsSpell1.AvailableLanguages.ToArray())
            comboBox1.Text = winformsSpell1.LanguageID
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            comboBox2.Items.AddRange(winformsSpell2.AvailableLanguages.ToArray())
            comboBox2.Text = winformsSpell2.LanguageID
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        winformsSpell1.SetLicense("", "")
        winformsSpell2.SetLicense("", "")

        winformsSpell2.SpellCheckAllCapitalsWords = True
        winformsSpell1.InitSpelling_AllTextBoxes()
        winformsSpell2.InitSpelling_AllTextBoxes()

        winformsSpell1.SpellCheckDialogCurrentTextboxShortcutKey = Shortcut.F7
        winformsSpell2.SpellCheckDialogCurrentTextboxShortcutKey = Shortcut.F7

        textBox3.Text = "some longer text is in this textbox. It contains a speling mistake or twwo" & vbCrLf & vbCrLf & "Press F7 to open a spell checking dialog"
        textBox6.Text = "some longer text is in this textbox. It contains a speling mistake or twwo" & vbCrLf & vbCrLf & "Press F7 to open a spell checking dialog" _
            & vbCrLf & vbCrLf & "this textbox also has an existing context menu"

    End Sub

    Private Sub btnLang1_Click(sender As Object, e As EventArgs) Handles btnLang1.Click
        winformsSpell1.LanguageID = comboBox1.Text
    End Sub

    Private Sub btnLang2_Click(sender As Object, e As EventArgs) Handles btnLang2.Click
        winformsSpell2.LanguageID = comboBox2.Text
    End Sub

    Private Sub chkBoxInclude1_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxInclude1.CheckedChanged

        If Not chkBoxInclude1.Checked Then
            winformsSpell1.ExcludedTextBoxes.Add(textBox4)
        Else
            winformsSpell1.ExcludedTextBoxes.Remove(textBox4)
        End If

    End Sub

    Private Sub chkBoxInclude2_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxInclude2.CheckedChanged

        If Not chkBoxInclude2.Checked Then
            winformsSpell2.ExcludedTextBoxes.Add(textBox5)
        Else
            winformsSpell2.ExcludedTextBoxes.Remove(textBox5)
        End If

    End Sub

    Private Sub winformsSpell1_SpellCheckComplete(sender As Object, e As EventArgs) Handles winformsSpell1.SpellCheckComplete, winformsSpell2.SpellCheckComplete

        MsgBox("Spelling check completed")

    End Sub

    Private Sub winformsSpell1_SpellingObjectError(ByRef sender As Object, e As OperationErrorEventArgs) Handles winformsSpell1.SpellingObjectError, winformsSpell2.SpellingObjectError

    End Sub

    Private Sub chkWordWrap2_CheckedChanged(sender As Object, e As EventArgs) Handles chkWordWrap2.CheckedChanged

        Me.textBox6.WordWrap = Not Me.textBox6.WordWrap

    End Sub

    Private Sub chkWordWrap1_CheckedChanged(sender As Object, e As EventArgs) Handles chkWordWrap1.CheckedChanged

        Me.textBox3.WordWrap = Not Me.textBox3.WordWrap

    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click

        If textBox6.SelectedText <> vbNullString Then
            Clipboard.SetText(textBox6.SelectedText)
            textBox6.SelectedText = ""
        End If

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click

        If textBox6.SelectedText <> vbNullString Then
            Clipboard.SetText(textBox6.SelectedText)
        End If

    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        textBox6.SelectedText = Clipboard.GetText()
    End Sub
End Class
