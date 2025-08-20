<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        BtnViewSubmissions = New Button()
        BtnCreateSubmission = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(282, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(270, 20)
        Label1.TabIndex = 0
        Label1.Text = "Group 11- Submission Form App"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' BtnViewSubmissions
        ' 
        BtnViewSubmissions.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        BtnViewSubmissions.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnViewSubmissions.Location = New Point(256, 138)
        BtnViewSubmissions.Margin = New Padding(3, 2, 3, 2)
        BtnViewSubmissions.Name = "BtnViewSubmissions"
        BtnViewSubmissions.Padding = New Padding(2)
        BtnViewSubmissions.Size = New Size(309, 39)
        BtnViewSubmissions.TabIndex = 1
        BtnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)"
        BtnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' BtnCreateSubmission
        ' 
        BtnCreateSubmission.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        BtnCreateSubmission.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnCreateSubmission.Location = New Point(256, 267)
        BtnCreateSubmission.Margin = New Padding(3, 2, 3, 2)
        BtnCreateSubmission.Name = "BtnCreateSubmission"
        BtnCreateSubmission.Padding = New Padding(2)
        BtnCreateSubmission.Size = New Size(309, 50)
        BtnCreateSubmission.TabIndex = 2
        BtnCreateSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        BtnCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(818, 374)
        Controls.Add(BtnCreateSubmission)
        Controls.Add(BtnViewSubmissions)
        Controls.Add(Label1)
        Font = New Font("Tempus Sans ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ActiveCaptionText
        KeyPreview = True
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Padding = New Padding(4)
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnViewSubmissions As Button
    Friend WithEvents BtnCreateSubmission As Button

End Class
