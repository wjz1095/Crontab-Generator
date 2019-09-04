<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.FinalOutputTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SelectMinuteRadioButton = New System.Windows.Forms.RadioButton()
        Me.SelectMinutesListBox = New System.Windows.Forms.ListBox()
        Me.EvenMinutesRadioButton = New System.Windows.Forms.RadioButton()
        Me.OddMinutesRadioButton = New System.Windows.Forms.RadioButton()
        Me.Every30MinutesRadioButton = New System.Windows.Forms.RadioButton()
        Me.Every15MinutesRadioButton = New System.Windows.Forms.RadioButton()
        Me.Every5MinutesRadioButton = New System.Windows.Forms.RadioButton()
        Me.EveryMinuteRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SelectHourRadioButton = New System.Windows.Forms.RadioButton()
        Me.SelectHourListBox = New System.Windows.Forms.ListBox()
        Me.EvenHoursRadioButton = New System.Windows.Forms.RadioButton()
        Me.OddHoursRadioButton = New System.Windows.Forms.RadioButton()
        Me.Every12HoursRadioButton = New System.Windows.Forms.RadioButton()
        Me.Every6HoursRadioButton = New System.Windows.Forms.RadioButton()
        Me.EveryHourRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.EveryHalfMonthRadioButton = New System.Windows.Forms.RadioButton()
        Me.DaySelectRadioButton = New System.Windows.Forms.RadioButton()
        Me.DaySelectListBox = New System.Windows.Forms.ListBox()
        Me.EvenDaysRadioButton = New System.Windows.Forms.RadioButton()
        Me.OddDaysRadioButton = New System.Windows.Forms.RadioButton()
        Me.Every10DaysRadioButton = New System.Windows.Forms.RadioButton()
        Me.Every5DaysRadioButton = New System.Windows.Forms.RadioButton()
        Me.EveryDayRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.MonthSelectRadioButton = New System.Windows.Forms.RadioButton()
        Me.MonthSelectListBox = New System.Windows.Forms.ListBox()
        Me.EvenMonthRadioButton = New System.Windows.Forms.RadioButton()
        Me.OddMonthRadioButton = New System.Windows.Forms.RadioButton()
        Me.EveryHalfYearRadioButton = New System.Windows.Forms.RadioButton()
        Me.Every4MonthRadioButton = New System.Windows.Forms.RadioButton()
        Me.EveryMonthRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.WeekdaySelectRadioButton = New System.Windows.Forms.RadioButton()
        Me.WeekdaySelectListBox = New System.Windows.Forms.ListBox()
        Me.MondayFridayRadioButton = New System.Windows.Forms.RadioButton()
        Me.SaturdaySundayRadioButton = New System.Windows.Forms.RadioButton()
        Me.EveryWeekdayRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CustomCommandTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.SendOutputToEmailTextBox = New System.Windows.Forms.TextBox()
        Me.SaveOutputToFileTextBox = New System.Windows.Forms.TextBox()
        Me.SendOutputToEmailRadioButton = New System.Windows.Forms.RadioButton()
        Me.SaveOutputToFileRadioButton = New System.Windows.Forms.RadioButton()
        Me.MuteOutputRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.CronReferenceLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.ScriptRunTimesListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'FinalOutputTextBox
        '
        Me.FinalOutputTextBox.Location = New System.Drawing.Point(12, 593)
        Me.FinalOutputTextBox.Name = "FinalOutputTextBox"
        Me.FinalOutputTextBox.Size = New System.Drawing.Size(643, 20)
        Me.FinalOutputTextBox.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SelectMinuteRadioButton)
        Me.GroupBox2.Controls.Add(Me.SelectMinutesListBox)
        Me.GroupBox2.Controls.Add(Me.EvenMinutesRadioButton)
        Me.GroupBox2.Controls.Add(Me.OddMinutesRadioButton)
        Me.GroupBox2.Controls.Add(Me.Every30MinutesRadioButton)
        Me.GroupBox2.Controls.Add(Me.Every15MinutesRadioButton)
        Me.GroupBox2.Controls.Add(Me.Every5MinutesRadioButton)
        Me.GroupBox2.Controls.Add(Me.EveryMinuteRadioButton)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(211, 166)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Minutes"
        '
        'SelectMinuteRadioButton
        '
        Me.SelectMinuteRadioButton.AutoSize = True
        Me.SelectMinuteRadioButton.Location = New System.Drawing.Point(128, 22)
        Me.SelectMinuteRadioButton.Name = "SelectMinuteRadioButton"
        Me.SelectMinuteRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.SelectMinuteRadioButton.TabIndex = 7
        Me.SelectMinuteRadioButton.TabStop = True
        Me.SelectMinuteRadioButton.UseVisualStyleBackColor = True
        '
        'SelectMinutesListBox
        '
        Me.SelectMinutesListBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SelectMinutesListBox.Enabled = False
        Me.SelectMinutesListBox.ForeColor = System.Drawing.SystemColors.MenuText
        Me.SelectMinutesListBox.FormattingEnabled = True
        Me.SelectMinutesListBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.SelectMinutesListBox.Location = New System.Drawing.Point(148, 13)
        Me.SelectMinutesListBox.Name = "SelectMinutesListBox"
        Me.SelectMinutesListBox.Size = New System.Drawing.Size(47, 147)
        Me.SelectMinutesListBox.TabIndex = 6
        '
        'EvenMinutesRadioButton
        '
        Me.EvenMinutesRadioButton.AutoSize = True
        Me.EvenMinutesRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EvenMinutesRadioButton.Location = New System.Drawing.Point(10, 43)
        Me.EvenMinutesRadioButton.Name = "EvenMinutesRadioButton"
        Me.EvenMinutesRadioButton.Size = New System.Drawing.Size(90, 17)
        Me.EvenMinutesRadioButton.TabIndex = 5
        Me.EvenMinutesRadioButton.Text = "Even Minutes"
        Me.EvenMinutesRadioButton.UseVisualStyleBackColor = True
        '
        'OddMinutesRadioButton
        '
        Me.OddMinutesRadioButton.AutoSize = True
        Me.OddMinutesRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OddMinutesRadioButton.Location = New System.Drawing.Point(10, 66)
        Me.OddMinutesRadioButton.Name = "OddMinutesRadioButton"
        Me.OddMinutesRadioButton.Size = New System.Drawing.Size(85, 17)
        Me.OddMinutesRadioButton.TabIndex = 4
        Me.OddMinutesRadioButton.Text = "Odd Minutes"
        Me.OddMinutesRadioButton.UseVisualStyleBackColor = True
        '
        'Every30MinutesRadioButton
        '
        Me.Every30MinutesRadioButton.AutoSize = True
        Me.Every30MinutesRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Every30MinutesRadioButton.Location = New System.Drawing.Point(10, 135)
        Me.Every30MinutesRadioButton.Name = "Every30MinutesRadioButton"
        Me.Every30MinutesRadioButton.Size = New System.Drawing.Size(92, 17)
        Me.Every30MinutesRadioButton.TabIndex = 3
        Me.Every30MinutesRadioButton.Text = "Every 30 Mins"
        Me.Every30MinutesRadioButton.UseVisualStyleBackColor = True
        '
        'Every15MinutesRadioButton
        '
        Me.Every15MinutesRadioButton.AutoSize = True
        Me.Every15MinutesRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Every15MinutesRadioButton.Location = New System.Drawing.Point(10, 112)
        Me.Every15MinutesRadioButton.Name = "Every15MinutesRadioButton"
        Me.Every15MinutesRadioButton.Size = New System.Drawing.Size(92, 17)
        Me.Every15MinutesRadioButton.TabIndex = 2
        Me.Every15MinutesRadioButton.Text = "Every 15 Mins"
        Me.Every15MinutesRadioButton.UseVisualStyleBackColor = True
        '
        'Every5MinutesRadioButton
        '
        Me.Every5MinutesRadioButton.AutoSize = True
        Me.Every5MinutesRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Every5MinutesRadioButton.Location = New System.Drawing.Point(10, 89)
        Me.Every5MinutesRadioButton.Name = "Every5MinutesRadioButton"
        Me.Every5MinutesRadioButton.Size = New System.Drawing.Size(86, 17)
        Me.Every5MinutesRadioButton.TabIndex = 1
        Me.Every5MinutesRadioButton.Text = "Every 5 Mins"
        Me.Every5MinutesRadioButton.UseVisualStyleBackColor = True
        '
        'EveryMinuteRadioButton
        '
        Me.EveryMinuteRadioButton.AutoSize = True
        Me.EveryMinuteRadioButton.Checked = True
        Me.EveryMinuteRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EveryMinuteRadioButton.Location = New System.Drawing.Point(10, 20)
        Me.EveryMinuteRadioButton.Name = "EveryMinuteRadioButton"
        Me.EveryMinuteRadioButton.Size = New System.Drawing.Size(87, 17)
        Me.EveryMinuteRadioButton.TabIndex = 0
        Me.EveryMinuteRadioButton.TabStop = True
        Me.EveryMinuteRadioButton.Text = "Every Minute"
        Me.EveryMinuteRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SelectHourRadioButton)
        Me.GroupBox3.Controls.Add(Me.SelectHourListBox)
        Me.GroupBox3.Controls.Add(Me.EvenHoursRadioButton)
        Me.GroupBox3.Controls.Add(Me.OddHoursRadioButton)
        Me.GroupBox3.Controls.Add(Me.Every12HoursRadioButton)
        Me.GroupBox3.Controls.Add(Me.Every6HoursRadioButton)
        Me.GroupBox3.Controls.Add(Me.EveryHourRadioButton)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(229, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(223, 166)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hours"
        '
        'SelectHourRadioButton
        '
        Me.SelectHourRadioButton.AutoSize = True
        Me.SelectHourRadioButton.Location = New System.Drawing.Point(128, 22)
        Me.SelectHourRadioButton.Name = "SelectHourRadioButton"
        Me.SelectHourRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.SelectHourRadioButton.TabIndex = 7
        Me.SelectHourRadioButton.TabStop = True
        Me.SelectHourRadioButton.UseVisualStyleBackColor = True
        '
        'SelectHourListBox
        '
        Me.SelectHourListBox.Enabled = False
        Me.SelectHourListBox.FormattingEnabled = True
        Me.SelectHourListBox.Items.AddRange(New Object() {"Midnight", "1am", "2am", "3am", "4am", "5am", "6am", "7am", "8am", "9am", "10am", "11am", "Noon", "1pm", "2pm", "3pm", "4pm", "5pm", "6pm", "7pm", "8pm", "9pm", "10pm", "11pm"})
        Me.SelectHourListBox.Location = New System.Drawing.Point(148, 13)
        Me.SelectHourListBox.Name = "SelectHourListBox"
        Me.SelectHourListBox.Size = New System.Drawing.Size(63, 147)
        Me.SelectHourListBox.TabIndex = 6
        '
        'EvenHoursRadioButton
        '
        Me.EvenHoursRadioButton.AutoSize = True
        Me.EvenHoursRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EvenHoursRadioButton.Location = New System.Drawing.Point(10, 43)
        Me.EvenHoursRadioButton.Name = "EvenHoursRadioButton"
        Me.EvenHoursRadioButton.Size = New System.Drawing.Size(81, 17)
        Me.EvenHoursRadioButton.TabIndex = 5
        Me.EvenHoursRadioButton.Text = "Even Hours"
        Me.EvenHoursRadioButton.UseVisualStyleBackColor = True
        '
        'OddHoursRadioButton
        '
        Me.OddHoursRadioButton.AutoSize = True
        Me.OddHoursRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OddHoursRadioButton.Location = New System.Drawing.Point(10, 66)
        Me.OddHoursRadioButton.Name = "OddHoursRadioButton"
        Me.OddHoursRadioButton.Size = New System.Drawing.Size(76, 17)
        Me.OddHoursRadioButton.TabIndex = 4
        Me.OddHoursRadioButton.Text = "Odd Hours"
        Me.OddHoursRadioButton.UseVisualStyleBackColor = True
        '
        'Every12HoursRadioButton
        '
        Me.Every12HoursRadioButton.AutoSize = True
        Me.Every12HoursRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Every12HoursRadioButton.Location = New System.Drawing.Point(10, 112)
        Me.Every12HoursRadioButton.Name = "Every12HoursRadioButton"
        Me.Every12HoursRadioButton.Size = New System.Drawing.Size(98, 17)
        Me.Every12HoursRadioButton.TabIndex = 2
        Me.Every12HoursRadioButton.Text = "Every 12 Hours"
        Me.Every12HoursRadioButton.UseVisualStyleBackColor = True
        '
        'Every6HoursRadioButton
        '
        Me.Every6HoursRadioButton.AutoSize = True
        Me.Every6HoursRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Every6HoursRadioButton.Location = New System.Drawing.Point(10, 89)
        Me.Every6HoursRadioButton.Name = "Every6HoursRadioButton"
        Me.Every6HoursRadioButton.Size = New System.Drawing.Size(92, 17)
        Me.Every6HoursRadioButton.TabIndex = 1
        Me.Every6HoursRadioButton.Text = "Every 6 Hours"
        Me.Every6HoursRadioButton.UseVisualStyleBackColor = True
        '
        'EveryHourRadioButton
        '
        Me.EveryHourRadioButton.AutoSize = True
        Me.EveryHourRadioButton.Checked = True
        Me.EveryHourRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EveryHourRadioButton.Location = New System.Drawing.Point(10, 20)
        Me.EveryHourRadioButton.Name = "EveryHourRadioButton"
        Me.EveryHourRadioButton.Size = New System.Drawing.Size(78, 17)
        Me.EveryHourRadioButton.TabIndex = 0
        Me.EveryHourRadioButton.TabStop = True
        Me.EveryHourRadioButton.Text = "Every Hour"
        Me.EveryHourRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.EveryHalfMonthRadioButton)
        Me.GroupBox4.Controls.Add(Me.DaySelectRadioButton)
        Me.GroupBox4.Controls.Add(Me.DaySelectListBox)
        Me.GroupBox4.Controls.Add(Me.EvenDaysRadioButton)
        Me.GroupBox4.Controls.Add(Me.OddDaysRadioButton)
        Me.GroupBox4.Controls.Add(Me.Every10DaysRadioButton)
        Me.GroupBox4.Controls.Add(Me.Every5DaysRadioButton)
        Me.GroupBox4.Controls.Add(Me.EveryDayRadioButton)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Location = New System.Drawing.Point(460, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(205, 166)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Days"
        '
        'EveryHalfMonthRadioButton
        '
        Me.EveryHalfMonthRadioButton.AutoSize = True
        Me.EveryHalfMonthRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EveryHalfMonthRadioButton.Location = New System.Drawing.Point(10, 135)
        Me.EveryHalfMonthRadioButton.Name = "EveryHalfMonthRadioButton"
        Me.EveryHalfMonthRadioButton.Size = New System.Drawing.Size(107, 17)
        Me.EveryHalfMonthRadioButton.TabIndex = 8
        Me.EveryHalfMonthRadioButton.Text = "Every Half Month"
        Me.EveryHalfMonthRadioButton.UseVisualStyleBackColor = True
        '
        'DaySelectRadioButton
        '
        Me.DaySelectRadioButton.AutoSize = True
        Me.DaySelectRadioButton.Location = New System.Drawing.Point(128, 22)
        Me.DaySelectRadioButton.Name = "DaySelectRadioButton"
        Me.DaySelectRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.DaySelectRadioButton.TabIndex = 7
        Me.DaySelectRadioButton.TabStop = True
        Me.DaySelectRadioButton.UseVisualStyleBackColor = True
        '
        'DaySelectListBox
        '
        Me.DaySelectListBox.Enabled = False
        Me.DaySelectListBox.FormattingEnabled = True
        Me.DaySelectListBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.DaySelectListBox.Location = New System.Drawing.Point(148, 13)
        Me.DaySelectListBox.Name = "DaySelectListBox"
        Me.DaySelectListBox.Size = New System.Drawing.Size(46, 147)
        Me.DaySelectListBox.TabIndex = 6
        '
        'EvenDaysRadioButton
        '
        Me.EvenDaysRadioButton.AutoSize = True
        Me.EvenDaysRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EvenDaysRadioButton.Location = New System.Drawing.Point(10, 43)
        Me.EvenDaysRadioButton.Name = "EvenDaysRadioButton"
        Me.EvenDaysRadioButton.Size = New System.Drawing.Size(77, 17)
        Me.EvenDaysRadioButton.TabIndex = 5
        Me.EvenDaysRadioButton.Text = "Even Days"
        Me.EvenDaysRadioButton.UseVisualStyleBackColor = True
        '
        'OddDaysRadioButton
        '
        Me.OddDaysRadioButton.AutoSize = True
        Me.OddDaysRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OddDaysRadioButton.Location = New System.Drawing.Point(10, 66)
        Me.OddDaysRadioButton.Name = "OddDaysRadioButton"
        Me.OddDaysRadioButton.Size = New System.Drawing.Size(72, 17)
        Me.OddDaysRadioButton.TabIndex = 4
        Me.OddDaysRadioButton.Text = "Odd Days"
        Me.OddDaysRadioButton.UseVisualStyleBackColor = True
        '
        'Every10DaysRadioButton
        '
        Me.Every10DaysRadioButton.AutoSize = True
        Me.Every10DaysRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Every10DaysRadioButton.Location = New System.Drawing.Point(10, 112)
        Me.Every10DaysRadioButton.Name = "Every10DaysRadioButton"
        Me.Every10DaysRadioButton.Size = New System.Drawing.Size(94, 17)
        Me.Every10DaysRadioButton.TabIndex = 2
        Me.Every10DaysRadioButton.Text = "Every 10 Days"
        Me.Every10DaysRadioButton.UseVisualStyleBackColor = True
        '
        'Every5DaysRadioButton
        '
        Me.Every5DaysRadioButton.AutoSize = True
        Me.Every5DaysRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Every5DaysRadioButton.Location = New System.Drawing.Point(10, 89)
        Me.Every5DaysRadioButton.Name = "Every5DaysRadioButton"
        Me.Every5DaysRadioButton.Size = New System.Drawing.Size(88, 17)
        Me.Every5DaysRadioButton.TabIndex = 1
        Me.Every5DaysRadioButton.Text = "Every 5 Days"
        Me.Every5DaysRadioButton.UseVisualStyleBackColor = True
        '
        'EveryDayRadioButton
        '
        Me.EveryDayRadioButton.AutoSize = True
        Me.EveryDayRadioButton.Checked = True
        Me.EveryDayRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EveryDayRadioButton.Location = New System.Drawing.Point(10, 20)
        Me.EveryDayRadioButton.Name = "EveryDayRadioButton"
        Me.EveryDayRadioButton.Size = New System.Drawing.Size(74, 17)
        Me.EveryDayRadioButton.TabIndex = 0
        Me.EveryDayRadioButton.TabStop = True
        Me.EveryDayRadioButton.Text = "Every Day"
        Me.EveryDayRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.MonthSelectRadioButton)
        Me.GroupBox5.Controls.Add(Me.MonthSelectListBox)
        Me.GroupBox5.Controls.Add(Me.EvenMonthRadioButton)
        Me.GroupBox5.Controls.Add(Me.OddMonthRadioButton)
        Me.GroupBox5.Controls.Add(Me.EveryHalfYearRadioButton)
        Me.GroupBox5.Controls.Add(Me.Every4MonthRadioButton)
        Me.GroupBox5.Controls.Add(Me.EveryMonthRadioButton)
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox5.Location = New System.Drawing.Point(12, 184)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(211, 166)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Months"
        '
        'MonthSelectRadioButton
        '
        Me.MonthSelectRadioButton.AutoSize = True
        Me.MonthSelectRadioButton.Location = New System.Drawing.Point(128, 22)
        Me.MonthSelectRadioButton.Name = "MonthSelectRadioButton"
        Me.MonthSelectRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.MonthSelectRadioButton.TabIndex = 7
        Me.MonthSelectRadioButton.TabStop = True
        Me.MonthSelectRadioButton.UseVisualStyleBackColor = True
        '
        'MonthSelectListBox
        '
        Me.MonthSelectListBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MonthSelectListBox.Enabled = False
        Me.MonthSelectListBox.ForeColor = System.Drawing.SystemColors.MenuText
        Me.MonthSelectListBox.FormattingEnabled = True
        Me.MonthSelectListBox.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
        Me.MonthSelectListBox.Location = New System.Drawing.Point(148, 13)
        Me.MonthSelectListBox.Name = "MonthSelectListBox"
        Me.MonthSelectListBox.Size = New System.Drawing.Size(47, 147)
        Me.MonthSelectListBox.TabIndex = 6
        '
        'EvenMonthRadioButton
        '
        Me.EvenMonthRadioButton.AutoSize = True
        Me.EvenMonthRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EvenMonthRadioButton.Location = New System.Drawing.Point(10, 43)
        Me.EvenMonthRadioButton.Name = "EvenMonthRadioButton"
        Me.EvenMonthRadioButton.Size = New System.Drawing.Size(88, 17)
        Me.EvenMonthRadioButton.TabIndex = 5
        Me.EvenMonthRadioButton.Text = "Even Months"
        Me.EvenMonthRadioButton.UseVisualStyleBackColor = True
        '
        'OddMonthRadioButton
        '
        Me.OddMonthRadioButton.AutoSize = True
        Me.OddMonthRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OddMonthRadioButton.Location = New System.Drawing.Point(10, 66)
        Me.OddMonthRadioButton.Name = "OddMonthRadioButton"
        Me.OddMonthRadioButton.Size = New System.Drawing.Size(83, 17)
        Me.OddMonthRadioButton.TabIndex = 4
        Me.OddMonthRadioButton.Text = "Odd Months"
        Me.OddMonthRadioButton.UseVisualStyleBackColor = True
        '
        'EveryHalfYearRadioButton
        '
        Me.EveryHalfYearRadioButton.AutoSize = True
        Me.EveryHalfYearRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EveryHalfYearRadioButton.Location = New System.Drawing.Point(10, 112)
        Me.EveryHalfYearRadioButton.Name = "EveryHalfYearRadioButton"
        Me.EveryHalfYearRadioButton.Size = New System.Drawing.Size(99, 17)
        Me.EveryHalfYearRadioButton.TabIndex = 2
        Me.EveryHalfYearRadioButton.Text = "Every Half Year"
        Me.EveryHalfYearRadioButton.UseVisualStyleBackColor = True
        '
        'Every4MonthRadioButton
        '
        Me.Every4MonthRadioButton.AutoSize = True
        Me.Every4MonthRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Every4MonthRadioButton.Location = New System.Drawing.Point(10, 89)
        Me.Every4MonthRadioButton.Name = "Every4MonthRadioButton"
        Me.Every4MonthRadioButton.Size = New System.Drawing.Size(99, 17)
        Me.Every4MonthRadioButton.TabIndex = 1
        Me.Every4MonthRadioButton.Text = "Every 4 Months"
        Me.Every4MonthRadioButton.UseVisualStyleBackColor = True
        '
        'EveryMonthRadioButton
        '
        Me.EveryMonthRadioButton.AutoSize = True
        Me.EveryMonthRadioButton.Checked = True
        Me.EveryMonthRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EveryMonthRadioButton.Location = New System.Drawing.Point(10, 20)
        Me.EveryMonthRadioButton.Name = "EveryMonthRadioButton"
        Me.EveryMonthRadioButton.Size = New System.Drawing.Size(85, 17)
        Me.EveryMonthRadioButton.TabIndex = 0
        Me.EveryMonthRadioButton.TabStop = True
        Me.EveryMonthRadioButton.Text = "Every Month"
        Me.EveryMonthRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.WeekdaySelectRadioButton)
        Me.GroupBox1.Controls.Add(Me.WeekdaySelectListBox)
        Me.GroupBox1.Controls.Add(Me.MondayFridayRadioButton)
        Me.GroupBox1.Controls.Add(Me.SaturdaySundayRadioButton)
        Me.GroupBox1.Controls.Add(Me.EveryWeekdayRadioButton)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(229, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(211, 166)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Weekday"
        '
        'WeekdaySelectRadioButton
        '
        Me.WeekdaySelectRadioButton.AutoSize = True
        Me.WeekdaySelectRadioButton.Location = New System.Drawing.Point(128, 22)
        Me.WeekdaySelectRadioButton.Name = "WeekdaySelectRadioButton"
        Me.WeekdaySelectRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.WeekdaySelectRadioButton.TabIndex = 7
        Me.WeekdaySelectRadioButton.TabStop = True
        Me.WeekdaySelectRadioButton.UseVisualStyleBackColor = True
        '
        'WeekdaySelectListBox
        '
        Me.WeekdaySelectListBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.WeekdaySelectListBox.Enabled = False
        Me.WeekdaySelectListBox.ForeColor = System.Drawing.SystemColors.MenuText
        Me.WeekdaySelectListBox.FormattingEnabled = True
        Me.WeekdaySelectListBox.Items.AddRange(New Object() {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"})
        Me.WeekdaySelectListBox.Location = New System.Drawing.Point(148, 13)
        Me.WeekdaySelectListBox.Name = "WeekdaySelectListBox"
        Me.WeekdaySelectListBox.Size = New System.Drawing.Size(47, 147)
        Me.WeekdaySelectListBox.TabIndex = 6
        '
        'MondayFridayRadioButton
        '
        Me.MondayFridayRadioButton.AutoSize = True
        Me.MondayFridayRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MondayFridayRadioButton.Location = New System.Drawing.Point(10, 43)
        Me.MondayFridayRadioButton.Name = "MondayFridayRadioButton"
        Me.MondayFridayRadioButton.Size = New System.Drawing.Size(94, 17)
        Me.MondayFridayRadioButton.TabIndex = 5
        Me.MondayFridayRadioButton.Text = "Monday-Friday"
        Me.MondayFridayRadioButton.UseVisualStyleBackColor = True
        '
        'SaturdaySundayRadioButton
        '
        Me.SaturdaySundayRadioButton.AutoSize = True
        Me.SaturdaySundayRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SaturdaySundayRadioButton.Location = New System.Drawing.Point(10, 66)
        Me.SaturdaySundayRadioButton.Name = "SaturdaySundayRadioButton"
        Me.SaturdaySundayRadioButton.Size = New System.Drawing.Size(106, 17)
        Me.SaturdaySundayRadioButton.TabIndex = 4
        Me.SaturdaySundayRadioButton.Text = "Saturday-Sunday"
        Me.SaturdaySundayRadioButton.UseVisualStyleBackColor = True
        '
        'EveryWeekdayRadioButton
        '
        Me.EveryWeekdayRadioButton.AutoSize = True
        Me.EveryWeekdayRadioButton.Checked = True
        Me.EveryWeekdayRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EveryWeekdayRadioButton.Location = New System.Drawing.Point(10, 20)
        Me.EveryWeekdayRadioButton.Name = "EveryWeekdayRadioButton"
        Me.EveryWeekdayRadioButton.Size = New System.Drawing.Size(101, 17)
        Me.EveryWeekdayRadioButton.TabIndex = 0
        Me.EveryWeekdayRadioButton.TabStop = True
        Me.EveryWeekdayRadioButton.Text = "Every Weekday"
        Me.EveryWeekdayRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CustomCommandTextBox)
        Me.GroupBox6.Controls.Add(Me.TextBox3)
        Me.GroupBox6.Controls.Add(Me.TextBox2)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox6.Location = New System.Drawing.Point(12, 359)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(428, 100)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Commands"
        '
        'CustomCommandTextBox
        '
        Me.CustomCommandTextBox.Location = New System.Drawing.Point(78, 67)
        Me.CustomCommandTextBox.Name = "CustomCommandTextBox"
        Me.CustomCommandTextBox.Size = New System.Drawing.Size(223, 20)
        Me.CustomCommandTextBox.TabIndex = 5
        Me.CustomCommandTextBox.Text = "/bin/bash -c '"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(78, 41)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(223, 20)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Text = "/usr/bin/php /home/username/script.php"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(78, 17)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(223, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "/bin/bash -c '/home/username/script.sh'"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Custom:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "PHP Script:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Bash Script:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.SendOutputToEmailTextBox)
        Me.GroupBox7.Controls.Add(Me.SaveOutputToFileTextBox)
        Me.GroupBox7.Controls.Add(Me.SendOutputToEmailRadioButton)
        Me.GroupBox7.Controls.Add(Me.SaveOutputToFileRadioButton)
        Me.GroupBox7.Controls.Add(Me.MuteOutputRadioButton)
        Me.GroupBox7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox7.Location = New System.Drawing.Point(12, 465)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(428, 100)
        Me.GroupBox7.TabIndex = 11
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Output Handling"
        '
        'SendOutputToEmailTextBox
        '
        Me.SendOutputToEmailTextBox.Enabled = False
        Me.SendOutputToEmailTextBox.Location = New System.Drawing.Point(148, 64)
        Me.SendOutputToEmailTextBox.Name = "SendOutputToEmailTextBox"
        Me.SendOutputToEmailTextBox.Size = New System.Drawing.Size(153, 20)
        Me.SendOutputToEmailTextBox.TabIndex = 4
        Me.SendOutputToEmailTextBox.Text = "MAILTO=""email@email.com"""
        '
        'SaveOutputToFileTextBox
        '
        Me.SaveOutputToFileTextBox.Enabled = False
        Me.SaveOutputToFileTextBox.Location = New System.Drawing.Point(148, 41)
        Me.SaveOutputToFileTextBox.Name = "SaveOutputToFileTextBox"
        Me.SaveOutputToFileTextBox.Size = New System.Drawing.Size(153, 20)
        Me.SaveOutputToFileTextBox.TabIndex = 3
        Me.SaveOutputToFileTextBox.Text = " > /var/log/File.log"
        '
        'SendOutputToEmailRadioButton
        '
        Me.SendOutputToEmailRadioButton.AutoSize = True
        Me.SendOutputToEmailRadioButton.Location = New System.Drawing.Point(10, 65)
        Me.SendOutputToEmailRadioButton.Name = "SendOutputToEmailRadioButton"
        Me.SendOutputToEmailRadioButton.Size = New System.Drawing.Size(123, 17)
        Me.SendOutputToEmailRadioButton.TabIndex = 2
        Me.SendOutputToEmailRadioButton.Text = "Send output to Email"
        Me.SendOutputToEmailRadioButton.UseVisualStyleBackColor = True
        '
        'SaveOutputToFileRadioButton
        '
        Me.SaveOutputToFileRadioButton.AutoSize = True
        Me.SaveOutputToFileRadioButton.Location = New System.Drawing.Point(10, 42)
        Me.SaveOutputToFileRadioButton.Name = "SaveOutputToFileRadioButton"
        Me.SaveOutputToFileRadioButton.Size = New System.Drawing.Size(111, 17)
        Me.SaveOutputToFileRadioButton.TabIndex = 1
        Me.SaveOutputToFileRadioButton.Text = "Save output to file"
        Me.SaveOutputToFileRadioButton.UseVisualStyleBackColor = True
        '
        'MuteOutputRadioButton
        '
        Me.MuteOutputRadioButton.AutoSize = True
        Me.MuteOutputRadioButton.Checked = True
        Me.MuteOutputRadioButton.Location = New System.Drawing.Point(10, 19)
        Me.MuteOutputRadioButton.Name = "MuteOutputRadioButton"
        Me.MuteOutputRadioButton.Size = New System.Drawing.Size(178, 17)
        Me.MuteOutputRadioButton.TabIndex = 0
        Me.MuteOutputRadioButton.TabStop = True
        Me.MuteOutputRadioButton.Text = "Mute (don't save or send output)"
        Me.MuteOutputRadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 574)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Output"
        '
        'GenerateButton
        '
        Me.GenerateButton.Location = New System.Drawing.Point(12, 619)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(107, 23)
        Me.GenerateButton.TabIndex = 13
        Me.GenerateButton.Text = "Generate Cron"
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(125, 619)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(107, 23)
        Me.ResetButton.TabIndex = 14
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'CronReferenceLinkLabel
        '
        Me.CronReferenceLinkLabel.AutoSize = True
        Me.CronReferenceLinkLabel.LinkColor = System.Drawing.Color.LightSkyBlue
        Me.CronReferenceLinkLabel.Location = New System.Drawing.Point(241, 624)
        Me.CronReferenceLinkLabel.Name = "CronReferenceLinkLabel"
        Me.CronReferenceLinkLabel.Size = New System.Drawing.Size(97, 13)
        Me.CronReferenceLinkLabel.TabIndex = 15
        Me.CronReferenceLinkLabel.TabStop = True
        Me.CronReferenceLinkLabel.Text = "Crontab Reference"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(564, 624)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "V1.0, 9/4/2019"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.ScriptRunTimesListBox)
        Me.GroupBox8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox8.Location = New System.Drawing.Point(460, 184)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(205, 381)
        Me.GroupBox8.TabIndex = 17
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Script Will Run At These Times"
        '
        'ScriptRunTimesListBox
        '
        Me.ScriptRunTimesListBox.FormattingEnabled = True
        Me.ScriptRunTimesListBox.Location = New System.Drawing.Point(10, 17)
        Me.ScriptRunTimesListBox.Name = "ScriptRunTimesListBox"
        Me.ScriptRunTimesListBox.Size = New System.Drawing.Size(184, 355)
        Me.ScriptRunTimesListBox.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(667, 646)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CronReferenceLinkLabel)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.GenerateButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.FinalOutputTextBox)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Crontab Generator"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FinalOutputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SelectHourRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SelectHourListBox As System.Windows.Forms.ListBox
    Friend WithEvents EvenHoursRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents OddHoursRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Every12HoursRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Every6HoursRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents EveryHourRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SelectMinuteRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SelectMinutesListBox As System.Windows.Forms.ListBox
    Friend WithEvents EvenMinutesRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents OddMinutesRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Every30MinutesRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Every15MinutesRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Every5MinutesRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents EveryMinuteRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents EveryHalfMonthRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DaySelectRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DaySelectListBox As System.Windows.Forms.ListBox
    Friend WithEvents EvenDaysRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents OddDaysRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Every10DaysRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Every5DaysRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents EveryDayRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents MonthSelectRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MonthSelectListBox As System.Windows.Forms.ListBox
    Friend WithEvents EvenMonthRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents OddMonthRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents EveryHalfYearRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Every4MonthRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents EveryMonthRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents WeekdaySelectRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents WeekdaySelectListBox As System.Windows.Forms.ListBox
    Friend WithEvents MondayFridayRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SaturdaySundayRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents EveryWeekdayRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents SendOutputToEmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveOutputToFileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SendOutputToEmailRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SaveOutputToFileRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MuteOutputRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GenerateButton As System.Windows.Forms.Button
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents CronReferenceLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CustomCommandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents ScriptRunTimesListBox As System.Windows.Forms.ListBox

End Class
