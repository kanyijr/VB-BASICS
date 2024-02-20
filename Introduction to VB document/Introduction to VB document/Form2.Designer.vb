Imports System.Windows.Forms




<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

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
        Me.DisplayGroup = New System.Windows.Forms.GroupBox()
        Me.SampleTextBox = New System.Windows.Forms.TextBox()
        Me.FontGroup = New System.Windows.Forms.GroupBox()
        Me.TahomaRadio = New System.Windows.Forms.RadioButton()
        Me.MagnetoRadio = New System.Windows.Forms.RadioButton()
        Me.GaramondRadio = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LoadImgButton = New System.Windows.Forms.Button()
        Me.FontStyleGroup = New System.Windows.Forms.GroupBox()
        Me.BoldItalicCheck = New System.Windows.Forms.CheckBox()
        Me.BoldCheck = New System.Windows.Forms.CheckBox()
        Me.ItalicCheck = New System.Windows.Forms.CheckBox()
        Me.FontColorGroup = New System.Windows.Forms.GroupBox()
        Me.RedColorCheck = New System.Windows.Forms.CheckBox()
        Me.BlueColorCheck = New System.Windows.Forms.CheckBox()
        Me.GreenColorCheck = New System.Windows.Forms.CheckBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DisplayGroup.SuspendLayout()
        Me.FontGroup.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FontStyleGroup.SuspendLayout()
        Me.FontColorGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'DisplayGroup
        '
        Me.DisplayGroup.Controls.Add(Me.SampleTextBox)
        Me.DisplayGroup.Location = New System.Drawing.Point(21, 80)
        Me.DisplayGroup.Name = "DisplayGroup"
        Me.DisplayGroup.Size = New System.Drawing.Size(329, 132)
        Me.DisplayGroup.TabIndex = 0
        Me.DisplayGroup.TabStop = False
        Me.DisplayGroup.Text = "Display Test"
        '
        'SampleTextBox
        '
        Me.SampleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SampleTextBox.Location = New System.Drawing.Point(20, 34)
        Me.SampleTextBox.Name = "SampleTextBox"
        Me.SampleTextBox.Size = New System.Drawing.Size(141, 26)
        Me.SampleTextBox.TabIndex = 1
        Me.SampleTextBox.Text = " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Sample Test"
        '
        'FontGroup
        '
        Me.FontGroup.Controls.Add(Me.TahomaRadio)
        Me.FontGroup.Controls.Add(Me.MagnetoRadio)
        Me.FontGroup.Controls.Add(Me.GaramondRadio)
        Me.FontGroup.Location = New System.Drawing.Point(393, 80)
        Me.FontGroup.Name = "FontGroup"
        Me.FontGroup.Size = New System.Drawing.Size(453, 132)
        Me.FontGroup.TabIndex = 1
        Me.FontGroup.TabStop = False
        Me.FontGroup.Text = "Font"
        '
        'TahomaRadio
        '
        Me.TahomaRadio.AutoSize = True
        Me.TahomaRadio.Location = New System.Drawing.Point(329, 44)
        Me.TahomaRadio.Name = "TahomaRadio"
        Me.TahomaRadio.Size = New System.Drawing.Size(92, 24)
        Me.TahomaRadio.TabIndex = 2
        Me.TahomaRadio.TabStop = True
        Me.TahomaRadio.Text = "Tahoma"
        Me.TahomaRadio.UseVisualStyleBackColor = True
        '
        'MagnetoRadio
        '
        Me.MagnetoRadio.AutoSize = True
        Me.MagnetoRadio.Location = New System.Drawing.Point(180, 44)
        Me.MagnetoRadio.Name = "MagnetoRadio"
        Me.MagnetoRadio.Size = New System.Drawing.Size(97, 24)
        Me.MagnetoRadio.TabIndex = 1
        Me.MagnetoRadio.TabStop = True
        Me.MagnetoRadio.Text = "Magneto"
        Me.MagnetoRadio.UseVisualStyleBackColor = True
        '
        'GaramondRadio
        '
        Me.GaramondRadio.AutoSize = True
        Me.GaramondRadio.Location = New System.Drawing.Point(20, 44)
        Me.GaramondRadio.Name = "GaramondRadio"
        Me.GaramondRadio.Size = New System.Drawing.Size(110, 24)
        Me.GaramondRadio.TabIndex = 0
        Me.GaramondRadio.TabStop = True
        Me.GaramondRadio.Text = "Garamond"
        Me.GaramondRadio.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(21, 258)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(398, 286)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'LoadImgButton
        '
        Me.LoadImgButton.Location = New System.Drawing.Point(41, 565)
        Me.LoadImgButton.Name = "LoadImgButton"
        Me.LoadImgButton.Size = New System.Drawing.Size(208, 34)
        Me.LoadImgButton.TabIndex = 3
        Me.LoadImgButton.Text = "Load Picture"
        Me.LoadImgButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.LoadImgButton.UseVisualStyleBackColor = True
        '
        'FontStyleGroup
        '
        Me.FontStyleGroup.Controls.Add(Me.BoldItalicCheck)
        Me.FontStyleGroup.Controls.Add(Me.BoldCheck)
        Me.FontStyleGroup.Controls.Add(Me.ItalicCheck)
        Me.FontStyleGroup.Location = New System.Drawing.Point(454, 258)
        Me.FontStyleGroup.Name = "FontStyleGroup"
        Me.FontStyleGroup.Size = New System.Drawing.Size(204, 286)
        Me.FontStyleGroup.TabIndex = 4
        Me.FontStyleGroup.TabStop = False
        Me.FontStyleGroup.Text = "Font Style"
        '
        'BoldItalicCheck
        '
        Me.BoldItalicCheck.AutoSize = True
        Me.BoldItalicCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.BoldItalicCheck.Location = New System.Drawing.Point(34, 206)
        Me.BoldItalicCheck.Name = "BoldItalicCheck"
        Me.BoldItalicCheck.Size = New System.Drawing.Size(115, 24)
        Me.BoldItalicCheck.TabIndex = 2
        Me.BoldItalicCheck.Text = "Bold Italic"
        Me.BoldItalicCheck.UseVisualStyleBackColor = True
        '
        'BoldCheck
        '
        Me.BoldCheck.AutoSize = True
        Me.BoldCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BoldCheck.Location = New System.Drawing.Point(34, 127)
        Me.BoldCheck.Name = "BoldCheck"
        Me.BoldCheck.Size = New System.Drawing.Size(71, 24)
        Me.BoldCheck.TabIndex = 1
        Me.BoldCheck.Text = "Bold"
        Me.BoldCheck.UseVisualStyleBackColor = True
        '
        'ItalicCheck
        '
        Me.ItalicCheck.AutoSize = True
        Me.ItalicCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic)
        Me.ItalicCheck.Location = New System.Drawing.Point(34, 61)
        Me.ItalicCheck.Name = "ItalicCheck"
        Me.ItalicCheck.Size = New System.Drawing.Size(68, 24)
        Me.ItalicCheck.TabIndex = 0
        Me.ItalicCheck.Text = "Italic"
        Me.ItalicCheck.UseVisualStyleBackColor = True
        '
        'FontColorGroup
        '
        Me.FontColorGroup.Controls.Add(Me.RedColorCheck)
        Me.FontColorGroup.Controls.Add(Me.BlueColorCheck)
        Me.FontColorGroup.Controls.Add(Me.GreenColorCheck)
        Me.FontColorGroup.Location = New System.Drawing.Point(684, 258)
        Me.FontColorGroup.Name = "FontColorGroup"
        Me.FontColorGroup.Size = New System.Drawing.Size(162, 286)
        Me.FontColorGroup.TabIndex = 5
        Me.FontColorGroup.TabStop = False
        Me.FontColorGroup.Text = "Font Color"
        '
        'RedColorCheck
        '
        Me.RedColorCheck.AutoSize = True
        Me.RedColorCheck.Location = New System.Drawing.Point(16, 206)
        Me.RedColorCheck.Name = "RedColorCheck"
        Me.RedColorCheck.Size = New System.Drawing.Size(65, 24)
        Me.RedColorCheck.TabIndex = 2
        Me.RedColorCheck.Text = "Red"
        Me.RedColorCheck.UseVisualStyleBackColor = True
        '
        'BlueColorCheck
        '
        Me.BlueColorCheck.AutoSize = True
        Me.BlueColorCheck.Location = New System.Drawing.Point(14, 127)
        Me.BlueColorCheck.Name = "BlueColorCheck"
        Me.BlueColorCheck.Size = New System.Drawing.Size(67, 24)
        Me.BlueColorCheck.TabIndex = 1
        Me.BlueColorCheck.Text = "Blue"
        Me.BlueColorCheck.UseVisualStyleBackColor = True
        '
        'GreenColorCheck
        '
        Me.GreenColorCheck.AutoSize = True
        Me.GreenColorCheck.Location = New System.Drawing.Point(16, 61)
        Me.GreenColorCheck.Name = "GreenColorCheck"
        Me.GreenColorCheck.Size = New System.Drawing.Size(80, 24)
        Me.GreenColorCheck.TabIndex = 0
        Me.GreenColorCheck.Text = "Green"
        Me.GreenColorCheck.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(754, 561)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(91, 37)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 611)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.FontColorGroup)
        Me.Controls.Add(Me.FontStyleGroup)
        Me.Controls.Add(Me.LoadImgButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.FontGroup)
        Me.Controls.Add(Me.DisplayGroup)
        Me.Name = "Form2"
        Me.Text = "Object Demonstrations"
        Me.DisplayGroup.ResumeLayout(False)
        Me.DisplayGroup.PerformLayout()
        Me.FontGroup.ResumeLayout(False)
        Me.FontGroup.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FontStyleGroup.ResumeLayout(False)
        Me.FontStyleGroup.PerformLayout()
        Me.FontColorGroup.ResumeLayout(False)
        Me.FontColorGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles GaramondRadio.CheckedChanged, MagnetoRadio.CheckedChanged, TahomaRadio.CheckedChanged
        If GaramondRadio.Checked Then
            ' Code to execute when RadioButton1 is checked
            SampleTextBox.Font = New Font(GaramondRadio.Text, FontStyle.Regular)
            MessageBox.Show("RadioButton1 Checked!")
        End If

        If MagnetoRadio.Checked Then
            ' Code to execute when RadioButton1 is checked
            SampleTextBox.Font = New Font(MagnetoRadio.Text, FontStyle.Regular)

            MessageBox.Show("RadioButton1 Checked!")
        End If

        If TahomaRadio.Checked Then

            ' Code to execute when RadioButton1 is checked
            SampleTextBox.Font = New Font(TahomaRadio.Text, FontStyle.Regular)

            MessageBox.Show("RadioButton1 Checked!")
        End If

    End Sub

    Private Sub FontColor() Handles RedColorCheck.CheckedChanged, BlueColorCheck.CheckedChanged, GreenColorCheck.CheckedChanged
        If RedColorCheck.Checked Then
            SampleTextBox.ForeColor = Color.FromName(RedColorCheck.Text)
        End If

        If BlueColorCheck.Checked Then
            SampleTextBox.ForeColor = Color.FromName(BlueColorCheck.Text)
        End If

        If GreenColorCheck.Checked Then
            SampleTextBox.ForeColor = Color.FromName(GreenColorCheck.Text)
        End If

    End Sub

    Private Sub FontFamily() Handles BoldCheck.CheckedChanged, BoldItalicCheck.CheckedChanged, ItalicCheck.CheckedChanged
        If BoldCheck.Checked Then
            SampleTextBox.Font = New Font(SampleTextBox.Font, FontStyle.Bold)
        End If

        If BoldItalicCheck.Checked Then
            SampleTextBox.Font = New Font(SampleTextBox.Font, FontStyle.Bold Or FontStyle.Italic)
        End If

        If ItalicCheck.Checked Then
            SampleTextBox.Font = New Font(SampleTextBox.Font, FontStyle.Italic)
        End If

    End Sub

    Private Sub Load_image() Handles LoadImgButton.Click
        PictureBox1.Image = Image.FromFile("C:\Users\Bobka\Downloads\download.jfif")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' Add your code here to execute when the button is clicked
        Me.Close()


    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ' Set the reference to the second form to Nothing when it is closed
        Form.secondForm = Nothing
    End Sub

    Friend WithEvents DisplayGroup As GroupBox
    Friend WithEvents SampleTextBox As TextBox
    Friend WithEvents FontGroup As GroupBox
    Friend WithEvents TahomaRadio As RadioButton
    Friend WithEvents MagnetoRadio As RadioButton
    Friend WithEvents GaramondRadio As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LoadImgButton As Button
    Friend WithEvents FontStyleGroup As GroupBox
    Friend WithEvents BoldItalicCheck As CheckBox
    Friend WithEvents BoldCheck As CheckBox
    Friend WithEvents ItalicCheck As CheckBox
    Friend WithEvents FontColorGroup As GroupBox
    Friend WithEvents RedColorCheck As CheckBox
    Friend WithEvents BlueColorCheck As CheckBox
    Friend WithEvents GreenColorCheck As CheckBox
    Friend WithEvents ExitButton As Button
End Class
