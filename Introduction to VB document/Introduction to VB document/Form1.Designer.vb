<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
    Inherits System.Windows.Forms.Form
    Public secondForm As Form2


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub



    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LoadImgButton
        '
        Me.LoadButton.Location = New System.Drawing.Point(405, 194)
        Me.LoadButton.Name = "LoadImgButton"
        Me.LoadButton.Size = New System.Drawing.Size(231, 46)
        Me.LoadButton.TabIndex = 1
        Me.LoadButton.Text = "EXIT"
        Me.LoadButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(148, 194)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(240, 46)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Load Object Demo"
        Me.ExitButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.LoadButton)
        Me.Name = "Form"
        Me.Text = "Welcoming Form"
        Me.ResumeLayout(False)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        ' Add your code here to execute when the button is clicked
        Me.Close()


    End Sub

    Private Sub Form_Click() Handles Me.Click
        Me.BackColor = Color.FromName("red")
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' Create a new instance of Form2 if it doesn't exist yet
        If secondForm Is Nothing Then
            secondForm = New Form2()
        End If

        ' Show the second form
        secondForm.Show()
    End Sub
    Friend WithEvents LoadButton As Button
    Friend WithEvents ExitButton As Button
End Class
