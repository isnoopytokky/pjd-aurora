<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeMember_Showall
    'Inherits System.Windows.Forms.Form
    Inherits frmBase

    'Form overrides dispose to clean up the component list.
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
        Me.gvMember = New System.Windows.Forms.DataGridView()
        CType(Me.gvMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvMember
        '
        Me.gvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvMember.Location = New System.Drawing.Point(12, 12)
        Me.gvMember.Name = "gvMember"
        Me.gvMember.Size = New System.Drawing.Size(699, 422)
        Me.gvMember.TabIndex = 0
        '
        'frmEmployeeMember_Showall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 445)
        Me.Controls.Add(Me.gvMember)
        Me.MaximumSize = New System.Drawing.Size(739, 726)
        Me.MinimumSize = New System.Drawing.Size(739, 39)
        Me.Name = "frmEmployeeMember_Showall"
        Me.Text = "frmEmployeeMember_Showall"
        CType(Me.gvMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gvMember As System.Windows.Forms.DataGridView
End Class
