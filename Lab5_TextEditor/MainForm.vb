' Author: Nirmal Patel
' Student ID: 100767993
' Date Created: 31 July 2020
' File: Lab5_TextEditor

Option Strict On
Imports System.IO

Class frmTextEditor

    ''' <summary>
    ''' Handles New click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NewClick(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        txtArea.Clear()                                                                 ' clears txtArea
        lblStripStatus.Text = "New text file started"                                   ' shows a message to Label
    End Sub

    ''' <summary>
    ''' Handles Open click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OpenClick(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        Dim fileStreamReader As StreamReader                                            ' declare a StreamReader file

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            fileStreamReader = New StreamReader(openFileDialog.FileName)
            txtArea.Text = fileStreamReader.ReadToEnd()
            lblStripStatus.Text = "Loaded " + openFileDialog.FileName
            fileStreamReader.Close()
        End If
    End Sub

    ''' <summary>
    ''' Handles Save click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SaveClick(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        Dim location As String                                                          ' declare a string

        location = saveFileDialog.FileName                                              ' show file name

        My.Computer.FileSystem.WriteAllText(location, "" & txtArea.Text, False)         ' saves file

        lblStripStatus.Text = "Saved " + saveFileDialog.FileName                        ' shows label message
    End Sub

    ''' <summary>
    ''' Handles Save As click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SaveAsClick(sender As Object, e As EventArgs) Handles mnuFileSaveas.Click
        saveFileDialog.ShowDialog()                                                     ' opens save file dialog
        saveFileDialog.Title = "Save your text file as"                                 ' changes title of file dialog

        Dim location As String                                                          ' declare a string

        location = saveFileDialog.FileName

        My.Computer.FileSystem.WriteAllText(location, "" & txtArea.Text, False)         ' Save As click

        lblStripStatus.Text = "Saved as " + saveFileDialog.FileName                     ' shows label message
    End Sub

    ''' <summary>
    ''' Handles Close click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CloseClick(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        txtArea.Text = ""                                                               ' clears txtArea
        lblStripStatus.Text = "Closed"                                                  ' shows label message
    End Sub

    ''' <summary>
    ''' Handles Exit click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitClick(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Application.Exit()                                                              ' Exits Application
    End Sub

    ''' <summary>
    ''' Handles About click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AboutClick(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        Dim aboutDialog As New frmAbout                                                 ' declare a variable linked to frmAbout form

        aboutDialog.ShowDialog()                                                        ' shows form dialog
    End Sub

    ''' <summary>
    ''' Handles Copy event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CopyClick(sender As Object, e As EventArgs) Handles mnuEditCopy.Click
        txtArea.Copy()                                                                  ' copy txtArea textbox
    End Sub

    ''' <summary>
    ''' Handles Cut event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CutClick(sender As Object, e As EventArgs) Handles mnuEditCut.Click
        txtArea.Cut()                                                                  ' cut txtArea textbox
    End Sub

    ''' <summary>
    ''' Handles Paste event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PasteClick(sender As Object, e As EventArgs) Handles mnuEditPaste.Click
        txtArea.Paste()                                                                 ' paste txtArea textbox
    End Sub
End Class