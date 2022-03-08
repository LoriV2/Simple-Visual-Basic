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
        Me.send = New System.Windows.Forms.Button()
        Me.label = New System.Windows.Forms.Label()
        Me.Text = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClientBoxIP = New System.Windows.Forms.TextBox()
        Me.ClientBoxPORT = New System.Windows.Forms.TextBox()
        Me.serverboxIP = New System.Windows.Forms.TextBox()
        Me.ServerboxPORT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'send
        '
        Me.send.Location = New System.Drawing.Point(455, 139)
        Me.send.Name = "send"
        Me.send.Size = New System.Drawing.Size(83, 24)
        Me.send.TabIndex = 0
        Me.send.Text = "Start"
        Me.send.UseVisualStyleBackColor = True
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(160, 177)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(41, 17)
        Me.label.TabIndex = 2
        Me.label.Text = "Client"
        '
        'Text
        '
        Me.Text.Location = New System.Drawing.Point(207, 110)
        Me.Text.Name = "Text"
        Me.Text.Size = New System.Drawing.Size(242, 24)
        Me.Text.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Your user name :"
        '
        'ClientBoxIP
        '
        Me.ClientBoxIP.Location = New System.Drawing.Point(207, 170)
        Me.ClientBoxIP.Name = "ClientBoxIP"
        Me.ClientBoxIP.Size = New System.Drawing.Size(118, 24)
        Me.ClientBoxIP.TabIndex = 5
        '
        'ClientBoxPORT
        '
        Me.ClientBoxPORT.Location = New System.Drawing.Point(331, 170)
        Me.ClientBoxPORT.Name = "ClientBoxPORT"
        Me.ClientBoxPORT.Size = New System.Drawing.Size(118, 24)
        Me.ClientBoxPORT.TabIndex = 6
        '
        'serverboxIP
        '
        Me.serverboxIP.Location = New System.Drawing.Point(207, 140)
        Me.serverboxIP.Name = "serverboxIP"
        Me.serverboxIP.Size = New System.Drawing.Size(118, 24)
        Me.serverboxIP.TabIndex = 7
        '
        'ServerboxPORT
        '
        Me.ServerboxPORT.Location = New System.Drawing.Point(331, 140)
        Me.ServerboxPORT.Name = "ServerboxPORT"
        Me.ServerboxPORT.Size = New System.Drawing.Size(118, 24)
        Me.ServerboxPORT.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "SERVER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(243, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "IP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(364, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "PORT"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(455, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 24)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Join"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(635, 338)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ServerboxPORT)
        Me.Controls.Add(Me.serverboxIP)
        Me.Controls.Add(Me.ClientBoxPORT)
        Me.Controls.Add(Me.ClientBoxIP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Text)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.send)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents send As Button
    Friend WithEvents label As Label
    Friend WithEvents Text As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ClientBoxIP As TextBox
    Friend WithEvents ClientBoxPORT As TextBox
    Friend WithEvents serverboxIP As TextBox
    Friend WithEvents ServerboxPORT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
