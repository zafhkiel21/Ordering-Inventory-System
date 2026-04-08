<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.user = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.loginbtt = New System.Windows.Forms.Button()
        Me.lbl_connection = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'user
        '
        Me.user.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.Location = New System.Drawing.Point(257, 49)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(203, 29)
        Me.user.TabIndex = 2
        '
        'pass
        '
        Me.pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.Location = New System.Drawing.Point(257, 104)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(203, 29)
        Me.pass.TabIndex = 3
        '
        'loginbtt
        '
        Me.loginbtt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbtt.Location = New System.Drawing.Point(338, 160)
        Me.loginbtt.Name = "loginbtt"
        Me.loginbtt.Size = New System.Drawing.Size(122, 40)
        Me.loginbtt.TabIndex = 4
        Me.loginbtt.Text = "Login"
        Me.loginbtt.UseVisualStyleBackColor = True
        '
        'lbl_connection
        '
        Me.lbl_connection.AutoSize = True
        Me.lbl_connection.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_connection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_connection.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_connection.Location = New System.Drawing.Point(581, 9)
        Me.lbl_connection.Name = "lbl_connection"
        Me.lbl_connection.Size = New System.Drawing.Size(34, 15)
        Me.lbl_connection.TabIndex = 7
        Me.lbl_connection.Text = "conn"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(553, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(21, 17)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(448, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "connection state:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(626, 264)
        Me.Controls.Add(Me.lbl_connection)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.loginbtt)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "U.I."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents user As TextBox
    Friend WithEvents pass As TextBox
    Friend WithEvents loginbtt As Button
    Friend WithEvents lbl_connection As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
End Class
