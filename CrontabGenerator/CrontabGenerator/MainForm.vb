Public Class MainForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SelectMinuteRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SelectMinuteRadioButton.CheckedChanged
        If SelectMinuteRadioButton.Checked = True Then
            SelectMinutesListBox.Enabled = True
            SelectMinutesListBox.SelectedIndex = 0
        ElseIf SelectMinuteRadioButton.Checked = False Then
            SelectMinutesListBox.Enabled = False
            SelectMinutesListBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub SelectHourRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SelectHourRadioButton.CheckedChanged
        If SelectHourRadioButton.Checked = True Then
            SelectHourListBox.Enabled = True
            SelectHourListBox.SelectedIndex = 0
        ElseIf SelectHourRadioButton.Checked = False Then
            SelectHourListBox.Enabled = False
            SelectHourListBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub DaySelectRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DaySelectRadioButton.CheckedChanged
        If DaySelectRadioButton.Checked = True Then
            DaySelectListBox.Enabled = True
            DaySelectListBox.SelectedIndex = 0
        ElseIf DaySelectRadioButton.Checked = False Then
            DaySelectListBox.Enabled = False
            DaySelectListBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub MonthSelectRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MonthSelectRadioButton.CheckedChanged
        If MonthSelectRadioButton.Checked = True Then
            MonthSelectListBox.Enabled = True
            MonthSelectListBox.SelectedIndex = 0
        ElseIf MonthSelectRadioButton.Checked = False Then
            MonthSelectListBox.Enabled = False
            MonthSelectListBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub WeekdaySelectRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles WeekdaySelectRadioButton.CheckedChanged
        If WeekdaySelectRadioButton.Checked = True Then
            WeekdaySelectListBox.Enabled = True
            WeekdaySelectListBox.SelectedIndex = 0
        ElseIf WeekdaySelectRadioButton.Checked = False Then
            WeekdaySelectListBox.Enabled = False
            WeekdaySelectListBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub MuteOutputRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MuteOutputRadioButton.CheckedChanged
        If MuteOutputRadioButton.Checked = True Then
            SaveOutputToFileTextBox.Enabled = False
            SendOutputToEmailTextBox.Enabled = False
            SaveOutputToFileTextBox.Text = " > /var/log/File.log"
            SendOutputToEmailTextBox.Text = "MAILTO='email@email.com'"
        End If
    End Sub

    Private Sub SaveOutputToFileRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SaveOutputToFileRadioButton.CheckedChanged
        If SaveOutputToFileRadioButton.Checked = True Then
            SaveOutputToFileTextBox.Enabled = True
            SendOutputToEmailTextBox.Enabled = False
        ElseIf SaveOutputToFileRadioButton.Checked = False Then
            SaveOutputToFileTextBox.Enabled = False
            SendOutputToEmailTextBox.Enabled = False
            SaveOutputToFileTextBox.Text = " > /var/log/File.log"
            SendOutputToEmailTextBox.Text = "MAILTO='email@email.com'"
        End If
    End Sub

    Private Sub SendOutputToEmailRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SendOutputToEmailRadioButton.CheckedChanged
        If SendOutputToEmailRadioButton.Checked = True Then
            SaveOutputToFileTextBox.Enabled = False
            SendOutputToEmailTextBox.Enabled = True
        ElseIf SendOutputToEmailRadioButton.Checked = False Then
            SaveOutputToFileTextBox.Enabled = False
            SendOutputToEmailTextBox.Enabled = False
            SaveOutputToFileTextBox.Text = " > /var/log/File.log"
            SendOutputToEmailTextBox.Text = "MAILTO='email@email.com'"
        End If
    End Sub


    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click
        'get input from each box
        'set input as a string with select/case or try/catch/finally
        'for each input have a different string
        'add all strings together to get the final output
        'put final output in text box

        'Declare variables
        Dim MinuteSelect As String
        Dim HourSelect As String
        Dim DaySelect As String
        Dim MonthSelect As String
        Dim WeekdaySelect As String
        Dim OutputSelect As String
        Dim FinalOutput As String

        'Minute checking logic
        If EveryMinuteRadioButton.Checked = True Then
            MinuteSelect = "*"
        End If
        If EvenMinutesRadioButton.Checked = True Then
            MinuteSelect = "*/2"
        End If
        If OddMinutesRadioButton.Checked = True Then
            MinuteSelect = "1-59/2"
        End If
        If Every5MinutesRadioButton.Checked = True Then
            MinuteSelect = "*/5"
        End If
        If Every15MinutesRadioButton.Checked = True Then
            MinuteSelect = "*/15"
        End If
        If Every30MinutesRadioButton.Checked = True Then
            MinuteSelect = "*/30"
        End If
        If SelectMinuteRadioButton.Checked = True Then
            'Get value of the minute and set it as the MinuteSelect (0-60)
            MinuteSelect = SelectMinutesListBox.SelectedItem
        End If


        'Hour checking logic
        If EveryHourRadioButton.Checked = True Then
            HourSelect = "*"
        End If
        If EvenHoursRadioButton.Checked = True Then
            HourSelect = "*/2"
        End If
        If OddHoursRadioButton.Checked = True Then
            HourSelect = "1-23/2"
        End If
        If Every6HoursRadioButton.Checked = True Then
            HourSelect = "*/6"
        End If
        If Every12HoursRadioButton.Checked = True Then
            HourSelect = "*/12"
        End If
        If SelectHourRadioButton.Checked = True Then
            'Get value of the hour and set as HourSelect
            Dim TempHour As String = SelectHourListBox.SelectedItem

            ''''probably have to do some logic in here to convert 1am to 1 and 2am to 2, etc


            HourSelect = 
            
        End If


        'Day checking logic
        If EveryDayRadioButton.Checked = True Then
            DaySelect = "*"
        End If
        If EvenDaysRadioButton.Checked = True Then
            DaySelect = "*/2"
        End If
        If OddDaysRadioButton.Checked = True Then
            DaySelect = "1-31/2"
        End If
        If Every5DaysRadioButton.Checked = True Then
            DaySelect = "*/5"
        End If
        If Every10DaysRadioButton.Checked = True Then
            DaySelect = "*/10"
        End If
        If EveryHalfMonthRadioButton.Checked = True Then
            DaySelect = "*/15"
        End If
        If DaySelectRadioButton.Checked = True Then
            Dim TempDay As String = DaySelectListBox.SelectedItem

            'Do some logic
            DaySelect = ""

        End If


        'Month checking logic
        If EveryMonthRadioButton.Checked = True Then
            MonthSelect = "*"
        End If
        If EvenMonthRadioButton.Checked = True Then
            MonthSelect = "*/2"
        End If
        If OddMonthRadioButton.Checked = True Then
            MonthSelect = "1-11/2"
        End If
        If Every4MonthRadioButton.Checked = True Then
            MonthSelect = "*/4"
        End If
        If EveryHalfYearRadioButton.Checked = True Then
            MonthSelect = "*/6"
        End If
        If MonthSelectRadioButton.Checked = True Then
            Dim TempMonth As String = MonthSelectListBox.SelectedItem

            'Do some logic
            MonthSelect = ""
        End If



        'Weekday checking logic
        If EveryWeekdayRadioButton.Checked = True Then
            WeekdaySelect = "*"
        End If
        If MondayFridayRadioButton.Checked = True Then
            WeekdaySelect = "1-5"
        End If
        If SaturdaySundayRadioButton.Checked = True Then
            WeekdaySelect = "0,6"
        End If
        If WeekdaySelectRadioButton.Checked = True Then
            Dim TempWeekday As String = WeekdaySelectListBox.SelectedItem
            'Do some logic

            WeekdaySelect = ""
        End If


        If MuteOutputRadioButton.Checked = True Then
            OutputSelect = ""
        End If
        If SaveOutputToFileRadioButton.Checked = True Then
            OutputSelect = SaveOutputToFileTextBox.Text
        End If
        If SendOutputToEmailRadioButton.Checked = True Then
            OutputSelect = SendOutputToEmailTextBox.Text
        End If

        FinalOutput = MinuteSelect + " " + HourSelect + " " + DaySelect + " " + MonthSelect + " " + WeekdaySelect + "   " + CustomCommandTextBox + " " + OutputSelect

        FinalOutputTextBox.Text = 
    End Sub

    
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        'Resets all radio buttons back to default
        EveryMinuteRadioButton.Checked = True
        EveryHourRadioButton.Checked = True
        EveryDayRadioButton.Checked = True
        EveryWeekdayRadioButton.Checked = True
        EveryMonthRadioButton.Checked = True

        MuteOutputRadioButton.Checked = True

        FinalOutputTextBox.Text = ""
    End Sub

    Private Sub CronReferenceLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CronReferenceLinkLabel.LinkClicked
        CrontabReference.Show()
    End Sub
End Class


