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
        'Get input from each list box and set string variables accordingly
        'Add all strings together to get the final output
        'Put final output in text box
        'Generate the times the script will run

        'I know there are better ways to do this but I couldn't be bothered to learn how. There's only a few variables so it's not worth the effort learning for more just yet

        'Declare variables
        Dim MinuteSelect As String = ""
        Dim HourSelect As String = ""
        Dim DaySelect As String = ""
        Dim MonthSelect As String = ""
        Dim WeekdaySelect As String = ""
        Dim OutputSelect As String = ""
        Dim FinalOutput As String = ""

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

            If TempHour = "Midnight" Then
                HourSelect = 0
            End If
            If TempHour = "1am" Then
                HourSelect = 1
            End If
            If TempHour = "2am" Then
                HourSelect = 2
            End If
            If TempHour = "3am" Then
                HourSelect = 3
            End If
            If TempHour = "4am" Then
                HourSelect = 4
            End If
            If TempHour = "5am" Then
                HourSelect = 5
            End If
            If TempHour = "6am" Then
                HourSelect = 6
            End If
            If TempHour = "7am" Then
                HourSelect = 7
            End If
            If TempHour = "8am" Then
                HourSelect = 8
            End If
            If TempHour = "9am" Then
                HourSelect = 9
            End If
            If TempHour = "10am" Then
                HourSelect = 10
            End If
            If TempHour = "11am" Then
                HourSelect = 11
            End If
            If TempHour = "Noon" Then
                HourSelect = 12
            End If
            If TempHour = "1pm" Then
                HourSelect = 13
            End If
            If TempHour = "2pm" Then
                HourSelect = 14
            End If
            If TempHour = "3pm" Then
                HourSelect = 15
            End If
            If TempHour = "4pm" Then
                HourSelect = 16
            End If
            If TempHour = "5pm" Then
                HourSelect = 17
            End If
            If TempHour = "6pm" Then
                HourSelect = 18
            End If
            If TempHour = "7pm" Then
                HourSelect = 19
            End If
            If TempHour = "8pm" Then
                HourSelect = 20
            End If
            If TempHour = "9pm" Then
                HourSelect = 21
            End If
            If TempHour = "10pm" Then
                HourSelect = 22
            End If
            If TempHour = "11pm" Then
                HourSelect = 23
            End If
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
            'Gets value of the selected item and sets that as the string
            Dim TempDay As String = DaySelectListBox.SelectedItem
            DaySelect = TempDay
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

            'Gets month from list box and sets appropriately
            If TempMonth = "Jan" Then
                MonthSelect = 1
            End If
            If TempMonth = "Feb" Then
                MonthSelect = 2
            End If
            If TempMonth = "Mar" Then
                MonthSelect = 3
            End If
            If TempMonth = "Apr" Then
                MonthSelect = 4
            End If
            If TempMonth = "May" Then
                MonthSelect = 5
            End If
            If TempMonth = "Jun" Then
                MonthSelect = 6
            End If
            If TempMonth = "Jul" Then
                MonthSelect = 7
            End If
            If TempMonth = "Aug" Then
                MonthSelect = 8
            End If
            If TempMonth = "Sep" Then
                MonthSelect = 9
            End If
            If TempMonth = "Oct" Then
                MonthSelect = 10
            End If
            If TempMonth = "Nov" Then
                MonthSelect = 11
            End If
            If TempMonth = "Dec" Then
                MonthSelect = 12
            End If
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

            'Gets weekday from list box and sets appropriately
            If TempWeekday = "Sun" Then
                WeekdaySelect = 0
            End If
            If TempWeekday = "Mon" Then
                WeekdaySelect = 1
            End If
            If TempWeekday = "Tue" Then
                WeekdaySelect = 2
            End If
            If TempWeekday = "Wed" Then
                WeekdaySelect = 3
            End If
            If TempWeekday = "Thu" Then
                WeekdaySelect = 4
            End If
            If TempWeekday = "Fri" Then
                WeekdaySelect = 5
            End If
            If TempWeekday = "Sat" Then
                WeekdaySelect = 6
            End If
        End If


        'Output logic
        If MuteOutputRadioButton.Checked = True Then
            OutputSelect = ""
        End If
        If SaveOutputToFileRadioButton.Checked = True Then
            OutputSelect = SaveOutputToFileTextBox.Text
        End If
        If SendOutputToEmailRadioButton.Checked = True Then
            OutputSelect = SendOutputToEmailTextBox.Text
        End If

        'Output string, then sets output textbox as the combined string we create with all values
        FinalOutput = MinuteSelect + " " + HourSelect + " " + DaySelect + " " + MonthSelect + " " + WeekdaySelect + "       " + CustomCommandTextBox.Text + " " + OutputSelect
        FinalOutputTextBox.Text = FinalOutput

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

        'Does not clear custom string output just in case the user wants to try the same script but at a different time
    End Sub

    Private Sub CronReferenceLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CronReferenceLinkLabel.LinkClicked
        CrontabReference.Show()
    End Sub
End Class


