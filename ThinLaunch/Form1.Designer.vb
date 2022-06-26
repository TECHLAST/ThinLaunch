<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnshutdown = New System.Windows.Forms.Button()
        Me.btnconnect = New System.Windows.Forms.Button()
        Me.btnreboot = New System.Windows.Forms.Button()
        Me.btnemergency = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnshutdown
        '
        Me.btnshutdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshutdown.Location = New System.Drawing.Point(12, 12)
        Me.btnshutdown.Name = "btnshutdown"
        Me.btnshutdown.Size = New System.Drawing.Size(169, 93)
        Me.btnshutdown.TabIndex = 0
        Me.btnshutdown.Text = "Herunterfahren"
        Me.btnshutdown.UseVisualStyleBackColor = True
        '
        'btnconnect
        '
        Me.btnconnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconnect.Location = New System.Drawing.Point(187, 12)
        Me.btnconnect.Name = "btnconnect"
        Me.btnconnect.Size = New System.Drawing.Size(169, 93)
        Me.btnconnect.TabIndex = 1
        Me.btnconnect.Text = "Verbinden"
        Me.btnconnect.UseVisualStyleBackColor = True
        '
        'btnreboot
        '
        Me.btnreboot.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreboot.Location = New System.Drawing.Point(12, 111)
        Me.btnreboot.Name = "btnreboot"
        Me.btnreboot.Size = New System.Drawing.Size(169, 93)
        Me.btnreboot.TabIndex = 2
        Me.btnreboot.Text = "Neu starten"
        Me.btnreboot.UseVisualStyleBackColor = True
        '
        'btnemergency
        '
        Me.btnemergency.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnemergency.Location = New System.Drawing.Point(187, 111)
        Me.btnemergency.Name = "btnemergency"
        Me.btnemergency.Size = New System.Drawing.Size(169, 93)
        Me.btnemergency.TabIndex = 3
        Me.btnemergency.Text = "Notfallmodus"
        Me.btnemergency.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 216)
        Me.Controls.Add(Me.btnemergency)
        Me.Controls.Add(Me.btnreboot)
        Me.Controls.Add(Me.btnconnect)
        Me.Controls.Add(Me.btnshutdown)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "ThinLaunch"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnshutdown As Button
    Friend WithEvents btnconnect As Button
    Friend WithEvents btnreboot As Button
    Friend WithEvents btnemergency As Button
End Class
