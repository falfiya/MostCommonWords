<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        txtBox = New TextBox()
        btnCompute = New Button()
        SuspendLayout()
        ' 
        ' txtBox
        ' 
        txtBox.AcceptsReturn = True
        txtBox.AcceptsTab = True
        txtBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtBox.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtBox.Location = New Point(14, 8)
        txtBox.MaxLength = 0
        txtBox.Multiline = True
        txtBox.Name = "txtBox"
        txtBox.ScrollBars = ScrollBars.Both
        txtBox.Size = New Size(856, 396)
        txtBox.TabIndex = 0
        ' 
        ' btnCompute
        ' 
        btnCompute.Location = New Point(14, 412)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(94, 29)
        btnCompute.TabIndex = 1
        btnCompute.Text = "Compute"
        btnCompute.UseVisualStyleBackColor = True
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(882, 453)
        Controls.Add(btnCompute)
        Controls.Add(txtBox)
        Name = "frmMain"
        Text = "Most Common Words"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtBox As TextBox
    Friend WithEvents btnCompute As Button
End Class
