<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.startButton = New System.Windows.Forms.Button()
        Me.sourceFolder = New System.Windows.Forms.TextBox()
        Me.searchSource = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.destinationFolder = New System.Windows.Forms.TextBox()
        Me.searchDestination = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.minSizeWidth = New System.Windows.Forms.TextBox()
        Me.minSizeHeight = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(12, 226)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(260, 23)
        Me.startButton.TabIndex = 0
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'sourceFolder
        '
        Me.sourceFolder.Location = New System.Drawing.Point(12, 43)
        Me.sourceFolder.Name = "sourceFolder"
        Me.sourceFolder.Size = New System.Drawing.Size(179, 20)
        Me.sourceFolder.TabIndex = 1
        '
        'searchSource
        '
        Me.searchSource.Location = New System.Drawing.Point(197, 43)
        Me.searchSource.Name = "searchSource"
        Me.searchSource.Size = New System.Drawing.Size(75, 20)
        Me.searchSource.TabIndex = 2
        Me.searchSource.Text = "Search"
        Me.searchSource.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(13, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(259, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Source Folder"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(13, 84)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(259, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Destination Folder"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'destinationFolder
        '
        Me.destinationFolder.Location = New System.Drawing.Point(13, 113)
        Me.destinationFolder.Name = "destinationFolder"
        Me.destinationFolder.Size = New System.Drawing.Size(179, 20)
        Me.destinationFolder.TabIndex = 5
        '
        'searchDestination
        '
        Me.searchDestination.Location = New System.Drawing.Point(197, 113)
        Me.searchDestination.Name = "searchDestination"
        Me.searchDestination.Size = New System.Drawing.Size(75, 20)
        Me.searchDestination.TabIndex = 6
        Me.searchDestination.Text = "Search"
        Me.searchDestination.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(13, 156)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(259, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Min Size (Width x Height)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'minSizeWidth
        '
        Me.minSizeWidth.Location = New System.Drawing.Point(13, 185)
        Me.minSizeWidth.Name = "minSizeWidth"
        Me.minSizeWidth.Size = New System.Drawing.Size(128, 20)
        Me.minSizeWidth.TabIndex = 8
        '
        'minSizeHeight
        '
        Me.minSizeHeight.Location = New System.Drawing.Point(144, 185)
        Me.minSizeHeight.Name = "minSizeHeight"
        Me.minSizeHeight.Size = New System.Drawing.Size(128, 20)
        Me.minSizeHeight.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.minSizeHeight)
        Me.Controls.Add(Me.minSizeWidth)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.searchDestination)
        Me.Controls.Add(Me.destinationFolder)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.searchSource)
        Me.Controls.Add(Me.sourceFolder)
        Me.Controls.Add(Me.startButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents startButton As Button
    Friend WithEvents sourceFolder As TextBox
    Friend WithEvents searchSource As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents destinationFolder As TextBox
    Friend WithEvents searchDestination As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents minSizeWidth As TextBox
    Friend WithEvents minSizeHeight As TextBox
End Class
