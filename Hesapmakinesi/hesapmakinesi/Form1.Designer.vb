﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Topla = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cıkar = New System.Windows.Forms.Button()
        Me.carp = New System.Windows.Forms.Button()
        Me.bol = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sayi1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sayi2:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(136, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(136, 74)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 3
        '
        'Topla
        '
        Me.Topla.Location = New System.Drawing.Point(85, 110)
        Me.Topla.Name = "Topla"
        Me.Topla.Size = New System.Drawing.Size(70, 43)
        Me.Topla.TabIndex = 4
        Me.Topla.Text = "+"
        Me.Topla.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sonuç"
        '
        'cıkar
        '
        Me.cıkar.Location = New System.Drawing.Point(161, 110)
        Me.cıkar.Name = "cıkar"
        Me.cıkar.Size = New System.Drawing.Size(75, 43)
        Me.cıkar.TabIndex = 6
        Me.cıkar.Text = "-"
        Me.cıkar.UseVisualStyleBackColor = True
        '
        'carp
        '
        Me.carp.Location = New System.Drawing.Point(242, 110)
        Me.carp.Name = "carp"
        Me.carp.Size = New System.Drawing.Size(75, 43)
        Me.carp.TabIndex = 7
        Me.carp.Text = "*"
        Me.carp.UseVisualStyleBackColor = True
        '
        'bol
        '
        Me.bol.Location = New System.Drawing.Point(323, 110)
        Me.bol.Name = "bol"
        Me.bol.Size = New System.Drawing.Size(77, 43)
        Me.bol.TabIndex = 8
        Me.bol.Text = "/"
        Me.bol.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bol)
        Me.Controls.Add(Me.carp)
        Me.Controls.Add(Me.cıkar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Topla)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Topla As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cıkar As Button
    Friend WithEvents carp As Button
    Friend WithEvents bol As Button
End Class
