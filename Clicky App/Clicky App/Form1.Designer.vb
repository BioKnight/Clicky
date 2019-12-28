<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Me.components = New System.ComponentModel.Container()
        Me.btn_Click = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.lbl_Click_Count = New System.Windows.Forms.Label()
        Me.nud_Click_Count = New System.Windows.Forms.NumericUpDown()
        Me.nud_Wait = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Timer = New System.Windows.Forms.Label()
        Me.tmr_Click = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_Test = New System.Windows.Forms.Label()
        Me.tmr_Delay = New System.Windows.Forms.Timer(Me.components)
        CType(Me.nud_Click_Count, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_Wait, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Click
        '
        Me.btn_Click.Location = New System.Drawing.Point(12, 102)
        Me.btn_Click.Name = "btn_Click"
        Me.btn_Click.Size = New System.Drawing.Size(75, 23)
        Me.btn_Click.TabIndex = 0
        Me.btn_Click.Text = "Click"
        Me.btn_Click.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel.Location = New System.Drawing.Point(93, 102)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel.TabIndex = 1
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'lbl_Click_Count
        '
        Me.lbl_Click_Count.AutoSize = True
        Me.lbl_Click_Count.Location = New System.Drawing.Point(12, 9)
        Me.lbl_Click_Count.Name = "lbl_Click_Count"
        Me.lbl_Click_Count.Size = New System.Drawing.Size(78, 17)
        Me.lbl_Click_Count.TabIndex = 2
        Me.lbl_Click_Count.Text = "&Click Count"
        '
        'nud_Click_Count
        '
        Me.nud_Click_Count.Location = New System.Drawing.Point(12, 29)
        Me.nud_Click_Count.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Click_Count.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_Click_Count.Name = "nud_Click_Count"
        Me.nud_Click_Count.Size = New System.Drawing.Size(120, 22)
        Me.nud_Click_Count.TabIndex = 4
        Me.nud_Click_Count.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nud_Wait
        '
        Me.nud_Wait.Location = New System.Drawing.Point(12, 74)
        Me.nud_Wait.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nud_Wait.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_Wait.Name = "nud_Wait"
        Me.nud_Wait.Size = New System.Drawing.Size(120, 22)
        Me.nud_Wait.TabIndex = 6
        Me.nud_Wait.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbl_Timer
        '
        Me.lbl_Timer.AutoSize = True
        Me.lbl_Timer.Location = New System.Drawing.Point(12, 54)
        Me.lbl_Timer.Name = "lbl_Timer"
        Me.lbl_Timer.Size = New System.Drawing.Size(44, 17)
        Me.lbl_Timer.TabIndex = 5
        Me.lbl_Timer.Text = "&Delay"
        '
        'tmr_Click
        '
        Me.tmr_Click.Interval = 10
        '
        'lbl_Test
        '
        Me.lbl_Test.Location = New System.Drawing.Point(138, 9)
        Me.lbl_Test.Name = "lbl_Test"
        Me.lbl_Test.Size = New System.Drawing.Size(30, 87)
        Me.lbl_Test.TabIndex = 7
        Me.lbl_Test.Text = "0"
        '
        'tmr_Delay
        '
        Me.tmr_Delay.Interval = 1000
        '
        'frm_Main
        '
        Me.AcceptButton = Me.btn_Click
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cancel
        Me.ClientSize = New System.Drawing.Size(178, 134)
        Me.Controls.Add(Me.lbl_Test)
        Me.Controls.Add(Me.nud_Wait)
        Me.Controls.Add(Me.lbl_Timer)
        Me.Controls.Add(Me.nud_Click_Count)
        Me.Controls.Add(Me.lbl_Click_Count)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Click)
        Me.MaximumSize = New System.Drawing.Size(196, 181)
        Me.MinimumSize = New System.Drawing.Size(196, 181)
        Me.Name = "frm_Main"
        CType(Me.nud_Click_Count, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_Wait, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Click As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents lbl_Click_Count As Label
    Friend WithEvents nud_Click_Count As NumericUpDown
    Friend WithEvents nud_Wait As NumericUpDown
    Friend WithEvents lbl_Timer As Label
    Friend WithEvents tmr_Click As Timer
    Friend WithEvents lbl_Test As Label
    Friend WithEvents tmr_Delay As Timer
End Class
