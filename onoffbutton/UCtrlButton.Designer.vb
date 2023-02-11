<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCtrlButton
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCtrlButton))
        Me.pbButton = New System.Windows.Forms.PictureBox()
        Me.imageListButton = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.pbButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbButton
        '
        Me.pbButton.Location = New System.Drawing.Point(86, 90)
        Me.pbButton.Name = "pbButton"
        Me.pbButton.Size = New System.Drawing.Size(220, 120)
        Me.pbButton.TabIndex = 0
        Me.pbButton.TabStop = False
        '
        'imageListButton
        '
        Me.imageListButton.ImageStream = CType(resources.GetObject("imageListButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageListButton.TransparentColor = System.Drawing.Color.Transparent
        Me.imageListButton.Images.SetKeyName(0, "button off.jpg")
        Me.imageListButton.Images.SetKeyName(1, "buttonon.jpg")
        '
        'UCtrlButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbButton)
        Me.Name = "UCtrlButton"
        Me.Size = New System.Drawing.Size(800, 450)
        CType(Me.pbButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbButton As PictureBox
    Friend WithEvents imageListButton As ImageList
End Class
