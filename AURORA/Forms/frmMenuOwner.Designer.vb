<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuOwner
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
        Me.btn_sell_gold = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_sell_gold
        '
        Me.btn_sell_gold.Location = New System.Drawing.Point(40, 47)
        Me.btn_sell_gold.Name = "btn_sell_gold"
        Me.btn_sell_gold.Size = New System.Drawing.Size(210, 59)
        Me.btn_sell_gold.TabIndex = 1
        Me.btn_sell_gold.Text = "ข้อมูลขายทอง"
        Me.btn_sell_gold.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(40, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 59)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "ข้อมูลขายทอง"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(40, 177)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(210, 59)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "ข้อมูลขายทอง"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.Location = New System.Drawing.Point(40, 242)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(210, 59)
        Me.btn_logout.TabIndex = 8
        Me.btn_logout.Text = "ออกจากระบบ"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'frmMenuOwner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 314)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_sell_gold)
        Me.Name = "frmMenuOwner"
        Me.Text = "frmMenuOwner"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_sell_gold As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_logout As System.Windows.Forms.Button
End Class
