Imports System.IO
Imports System.Xml

Public Class Form1
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

    Dim channelUpdateClicked(0 To 2) As Boolean
    Dim recvdData As String = ""
    Dim UserSelectedChannel As Boolean
    Dim stopProgrammingRequested As Boolean
    Public Const DEBUG As Boolean = False
    Const NORMAL_RADIO_TIMING As Integer = 80
    Const SLOW_RADIO_TIMING As Integer = 250
    Const DEBUG_RADIO_TIMING As Integer = 500
    Dim decimalSeparator As String = ""
    Function setStepSize(ByRef stepSizeStr As String) As Boolean
        Dim KhzToolStripComboBoxObj As ToolStripComboBox

        If TabControl.SelectedIndex = 0 Then
            KhzToolStripComboBoxObj = Tab1KHzToolStripComboBox
        ElseIf TabControl.SelectedIndex = 1 Then
            KhzToolStripComboBoxObj = Tab2KHzToolStripComboBox
        Else
            KhzToolStripComboBoxObj = Tab3KHzToolStripComboBox
        End If

        setStepSize = True
        If stepSizeStr.Equals("10") Then
            KhzToolStripComboBoxObj.SelectedIndex = 0
        ElseIf stepSizeStr.Equals("12.5") Then
            KhzToolStripComboBoxObj.SelectedIndex = 1
        ElseIf stepSizeStr.Equals("5") Then
            KhzToolStripComboBoxObj.SelectedIndex = 2
        ElseIf stepSizeStr.Equals("25") Then
            KhzToolStripComboBoxObj.SelectedIndex = 3
        Else
            setStepSize = False
        End If

    End Function

    Function initializeForm() As Boolean

        Dim ChannelListViewObj As ListView
        Dim KhzToolStripComboBoxObj As ToolStripComboBox
        Dim ToolStripStatusLabelObj As ToolStripStatusLabel
        Dim XmitButton As RadioButton
        Dim XmitRecButton As RadioButton
        Dim CtcssOffButton As RadioButton
        Dim ToneComboBox As ComboBox
        Dim MhzComboBox As ComboBox

        decimalSeparator = Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator

        For x As Integer = 0 To 2
            channelUpdateClicked(x) = False
        Next

        Tab1UsbRcvdLabel.Text = ""
        Tab2UsbRcvdLabel.Text = ""
        Tab3UsbRcvdLabel.Text = ""

        stopProgrammingRequested = False

        ChannelListViewObj = Tab1ChannelListView
        KhzToolStripComboBoxObj = Tab1KHzToolStripComboBox
        ToolStripStatusLabelObj = Tab1ToolStripStatusLabel
        XmitButton = Tab1CtcssXmit
        XmitRecButton = Tab1CtcssXmitRec
        CtcssOffButton = Tab1CtcssOff
        ToneComboBox = Tab1ToneComboBox
        MhzComboBox = Tab1MHzComboBox

        TabControl.SelectedIndex = 0
        KhzToolStripComboBoxObj.Text = 5
        ChannelListViewObj.Items.Add(0)
        ChannelListViewObj.Items(0).SubItems.Add("")
        ChannelListViewObj.Items(0).Text = "1"
        ChannelListViewObj.Items(0).SubItems.Add("")
        ChannelListViewObj.Items(0).SubItems.Add("")
        ChannelListViewObj.Items(0).SubItems.Add("")
        ChannelListViewObj.Items(0).SubItems.Add("")
        ChannelListViewObj.Text = 0
        ChannelListViewObj.Items(0).Selected = True
        ChannelListViewObj.HideSelection() = False
        UserSelectedChannel = False
        If Not setStepSize(Form2.radioConfig.tab1StepSize) Then
            KhzToolStripComboBoxObj.Text = KhzToolStripComboBoxObj.Items(0)
            If TabControl.SelectedTab.Text.Contains("144e") Then
                KhzToolStripComboBoxObj.Text = KhzToolStripComboBoxObj.Items(1)
            ElseIf TabControl.SelectedTab.Text.Contains("144") Then
                KhzToolStripComboBoxObj.Text = KhzToolStripComboBoxObj.Items(2)
            ElseIf TabControl.SelectedTab.Text.Contains("440") Then
                KhzToolStripComboBoxObj.Text = KhzToolStripComboBoxObj.Items(1)
            ElseIf TabControl.SelectedTab.Text.Contains("1200") Then
                KhzToolStripComboBoxObj.Text = KhzToolStripComboBoxObj.Items(3)
            End If
        End If
        ToolStripStatusLabelObj.Text = ""
        XmitButton.Checked = False
        XmitRecButton.Checked = False
        CtcssOffButton.Checked = True
        ToneComboBox.Text = ToneComboBox.Items(0)
        ToneComboBox.Enabled = False
        MhzComboBox.Text = MhzComboBox.Items(0)
        ChannelListViewObj.Items(0).SubItems(1).Text = MhzComboBox.Items(0)

        ChannelListViewObj = Tab2ChannelListView
        KhzToolStripComboBoxObj = Tab2KHzToolStripComboBox
        ToolStripStatusLabelObj = Tab2ToolStripStatusLabel
        XmitButton = Tab2CtcssXmit
        XmitRecButton = Tab2CtcssXmitRec
        CtcssOffButton = Tab2CtcssOff
        ToneComboBox = Tab2ToneComboBox
        MhzComboBox = Tab2MHzComboBox

        TabControl.SelectedIndex = 1
        KhzToolStripComboBoxObj.Text = 5
        ChannelListViewObj.Items.Add(0)
        ChannelListViewObj.Items(0).SubItems.Add("")
        ChannelListViewObj.Items(0).Text = "1"
        ChannelListViewObj.Items(0).SubItems.Add("")
        ChannelListViewObj.Items(0).SubItems.Add("")
        ChannelListViewObj.Items(0).SubItems.Add("")
        ChannelListViewObj.Items(0).SubItems.Add("")
        ChannelListViewObj.Text = 0
        ChannelListViewObj.Items(0).Selected = True
        ChannelListViewObj.HideSelection() = False
        UserSelectedChannel = False
        If Not setStepSize(Form2.radioConfig.tab2StepSize) Then
            KhzToolStripComboBoxObj.Text = KhzToolStripComboBoxObj.Items(0)
            If TabControl.SelectedTab.Text.Contains("144e") Then
                KhzToolStripComboBoxObj.Text = KhzToolStripComboBoxObj.Items(1)
            ElseIf TabControl.SelectedTab.Text.Contains("144") Then
                KhzToolStripComboBoxObj.Text = KhzToolStripComboBoxObj.Items(2)
            ElseIf TabControl.SelectedTab.Text.Contains("440") Then
                KhzToolStripComboBoxObj.Text = KhzToolStripComboBoxObj.Items(1)
            ElseIf TabControl.SelectedTab.Text.Contains("1200") Then
                KhzToolStripComboBoxObj.Text = KhzToolStripComboBoxObj.Items(3)
            End If
        End If
        ToolStripStatusLabelObj.Text = ""
        XmitButton.Checked = False
        XmitRecButton.Checked = False
        CtcssOffButton.Checked = True
        ToneComboBox.Text = ToneComboBox.Items(0)
        ToneComboBox.Enabled = False
        MhzComboBox.Text = MhzComboBox.Items(0)
        ChannelListViewObj.Items(0).SubItems(1).Text = MhzComboBox.Items(0)

        ChannelListViewObj = Tab3ChannelListView
        KhzToolStripComboBoxObj = Tab3KHzToolStripComboBox
        ToolStripStatusLabelObj = Tab3ToolStripStatusLabel
        XmitButton = Tab3CtcssXmit
        XmitRecButton = Tab3CtcssXmitRec
        CtcssOffButton = Tab3CtcssOff
        ToneComboBox = Tab3ToneComboBox
        MhzComboBox = Tab3MHzComboBox

        TabControl.SelectedIndex = 2
        KhzToolStripComboBoxObj.Text = 5
        ChannelListViewObj.Items.Add(0)
        ChannelListViewObj.Items(0).SubItems.Add("")
        ChannelListViewObj.Items(0).Text = "1"
        ChannelListViewObj.Items(0).SubItems.Add("")
        ChannelListViewObj.Items(0).SubItems.Add("")
        ChannelListViewObj.Items(0).SubItems.Add("")
        ChannelListViewObj.Items(0).SubItems.Add("")
        ChannelListViewObj.Text = 0
        ChannelListViewObj.Items(0).Selected = True
        ChannelListViewObj.HideSelection() = False
        UserSelectedChannel = False
        If Not setStepSize(Form2.radioConfig.tab3StepSize) Then
            KhzToolStripComboBoxObj.Text = KhzToolStripComboBoxObj.Items(0)
            If TabControl.SelectedTab.Text.Contains("144e") Then
                KhzToolStripComboBoxObj.Text = KhzToolStripComboBoxObj.Items(1)
            ElseIf TabControl.SelectedTab.Text.Contains("144") Then
                KhzToolStripComboBoxObj.Text = KhzToolStripComboBoxObj.Items(2)
            ElseIf TabControl.SelectedTab.Text.Contains("440") Then
                KhzToolStripComboBoxObj.Text = KhzToolStripComboBoxObj.Items(1)
            ElseIf TabControl.SelectedTab.Text.Contains("1200") Then
                KhzToolStripComboBoxObj.Text = KhzToolStripComboBoxObj.Items(3)
            End If
        End If
        ToolStripStatusLabelObj.Text = ""
        XmitButton.Checked = False
        XmitRecButton.Checked = False
        CtcssOffButton.Checked = True
        ToneComboBox.Text = ToneComboBox.Items(0)
        ToneComboBox.Enabled = False
        MhzComboBox.Text = MhzComboBox.Items(0)
        ChannelListViewObj.Items(0).SubItems(1).Text = MhzComboBox.Items(0)

        TabControl.SelectedIndex = 0

        initializeForm = True

    End Function

    Private Function openSerialPort() As Boolean
        openSerialPort = False

        If (DEBUG) Then
            openSerialPort = True
            Exit Function
        End If

        If SerialPort1.IsOpen Then
            openSerialPort = True
            Exit Function
        End If

        Dim textBoxObj As TextBox

        If TabControl.SelectedIndex = 0 Then
            textBoxObj = Tab1ComPortTextBox
        ElseIf TabControl.SelectedIndex = 1 Then
            textBoxObj = Tab2ComPortTextBox
        Else
            textBoxObj = Tab3ComPortTextBox
        End If

        Dim tryDefaultPort As Boolean = False
        Try
            Dim portString As String = "COM"
            portString += Convert.ToString(Form2.radioConfig.usbPort)
            SerialPort1.PortName = portString
            SerialPort1.Open()
            Sleep(3000)
            tryDefaultPort = True
        Catch ex1 As Exception
            Sleep(500)
        End Try

        If (tryDefaultPort) Then
            tryDefaultPort = False
            Dim testMsg As Boolean = sendString(" ")
            If (testMsg) Then
                Dim message As String = "Found Arduino on on COM port: "
                message += Convert.ToString(Form2.radioConfig.usbPort)
                MessageBox.Show(message)
                openSerialPort = True
                Exit Function
            Else
                SerialPort1.Close()
                Sleep(500)
            End If
        End If

        textBoxObj.Visible = True
        For x As Integer = 1 To 20
            textBoxObj.Text = "Searching for Arduino on COM Port: " & x
            textBoxObj.Update()

            Try
                Dim portString As String = "COM"
                portString += Convert.ToString(x)
                SerialPort1.PortName = portString
                SerialPort1.Open()
                Sleep(3000)
            Catch ex1 As Exception
                Sleep(500)
                Continue For
            End Try
            Dim testMsg As Boolean = sendString(" ")
            If (testMsg) Then
                Dim message As String = "Found Arduino on on COM port: "
                message += Convert.ToString(x)
                MessageBox.Show(message)
                openSerialPort = True

                Dim testXml As New XmlDocument
                testXml.Load(Form2.xmlFile)
                testXml.SelectSingleNode("TM742/usbPort").InnerText = Convert.ToString(x)
                testXml.Save(Form2.xmlFile)
                textBoxObj.Visible = False

                Exit Function
            Else
                SerialPort1.Close()
                Sleep(500)
                Continue For
            End If
        Next
        textBoxObj.Visible = False

    End Function

    Private Sub SetChannelButtone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab1SetChannelButtone.Click, Tab2SetChannelButtone.Click, Tab3SetChannelButtone.Click
        Dim ChannelListViewObj As ListView
        Dim MHzComboBoxObj As ComboBox
        Dim KHzComboBoxObj As ComboBox
        Dim RepeaterComboBoxObj As ComboBox
        Dim ToneComboBoxObj As ComboBox
        Dim CtcssRadioButtonObj As RadioButton
        Dim ToneRadioButtonObj As RadioButton
        Dim selectedIndex As Int32
        Dim NotesObj As TextBox

        If TabControl.SelectedIndex = 0 Then
            ChannelListViewObj = Tab1ChannelListView
            MHzComboBoxObj = Tab1MHzComboBox
            KHzComboBoxObj = Tab1KHzCombBox
            RepeaterComboBoxObj = Tab1RepeaterComboBox
            ToneComboBoxObj = Tab1ToneComboBox
            CtcssRadioButtonObj = Tab1CtcssXmitRec
            ToneRadioButtonObj = Tab1CtcssXmit
            NotesObj = Tab1ChannelNotes
        ElseIf TabControl.SelectedIndex = 1 Then
            ChannelListViewObj = Tab2ChannelListView
            MHzComboBoxObj = Tab2MHzComboBox
            KHzComboBoxObj = Tab2KHzCombBox
            RepeaterComboBoxObj = Tab2RepeaterComboBox
            ToneComboBoxObj = Tab2ToneComboBox
            CtcssRadioButtonObj = Tab2CtcssXmitRec
            ToneRadioButtonObj = Tab2CtcssXmit
            NotesObj = Tab2ChannelNotes
        Else
            ChannelListViewObj = Tab3ChannelListView
            MHzComboBoxObj = Tab3MHzComboBox
            KHzComboBoxObj = Tab3KHzCombBox
            RepeaterComboBoxObj = Tab3RepeaterComboBox
            ToneComboBoxObj = Tab3ToneComboBox
            CtcssRadioButtonObj = Tab3CtcssXmitRec
            ToneRadioButtonObj = Tab3CtcssXmit
            NotesObj = Tab3ChannelNotes
        End If

        channelUpdateClicked(TabControl.SelectedIndex) = True

        If Not MHzComboBoxObj.Text = "BLANK" Then
            If Not MHzComboBoxObj.Items.Contains(MHzComboBoxObj.Text) Then
                MsgBox("Mhz selected is not a valid choice.", MsgBoxStyle.Critical, "Set Channel Error Message")
                Exit Sub
            End If
            If Not (((Convert.ToDouble(fixDecimalSeparator(KHzComboBoxObj.Text)) * 10000) Mod 12.5 = 0) Or ((Convert.ToDouble(fixDecimalSeparator(KHzComboBoxObj.Text)) * 10000) Mod 5 = 0)) Then
                MsgBox("Khz selected is not a valid choice.", MsgBoxStyle.Critical, "Set Channel Error Message")
                Exit Sub
            End If
            If Not RepeaterComboBoxObj.Items.Contains(RepeaterComboBoxObj.Text) Then
                MsgBox("Repeater value selected is not a valid choice.", MsgBoxStyle.Critical, "Set Channel Error Message")
                Exit Sub
            End If
            If Not ToneComboBoxObj.Items.Contains(ToneComboBoxObj.Text) Then
                MsgBox("Tone frequency selected is not a valid choice.", MsgBoxStyle.Critical, "Set Channel Error Message")
                Exit Sub
            End If
        End If

        selectedIndex = ChannelListViewObj.SelectedItems.Item(0).Index
        ChannelListViewObj.Items(selectedIndex).SubItems.Item(1).Text = MHzComboBoxObj.Text

        If (Not (MHzComboBoxObj.Text.Equals("BLANK"))) Then
            Dim test As Double = Convert.ToDouble(fixDecimalSeparator(MHzComboBoxObj.Text)) + (Convert.ToDouble(fixDecimalSeparator(KHzComboBoxObj.Text)) * 0.001)
            ChannelListViewObj.Items(selectedIndex).SubItems.Item(1).Text = String.Format("{0:F4}", test)
            ChannelListViewObj.Items(selectedIndex).SubItems.Item(2).Text = RepeaterComboBoxObj.Text
            ChannelListViewObj.Items(selectedIndex).SubItems.Item(3).Text = ToneComboBoxObj.Text
            If ToneRadioButtonObj.Checked Then
                ChannelListViewObj.Items(selectedIndex).SubItems.Item(4).Text = ToneRadioButtonObj.Text
            ElseIf CtcssRadioButtonObj.Checked = True Then
                ChannelListViewObj.Items(selectedIndex).SubItems.Item(4).Text = CtcssRadioButtonObj.Text
            Else
                ChannelListViewObj.Items(selectedIndex).SubItems.Item(4).Text = "OFF"
            End If
        Else
            ChannelListViewObj.Items(selectedIndex).SubItems.Item(2).Text = ""
            ChannelListViewObj.Items(selectedIndex).SubItems.Item(3).Text = ""
            ChannelListViewObj.Items(selectedIndex).SubItems.Item(4).Text = ""
        End If

        ChannelListViewObj.Items(selectedIndex).SubItems.Item(5).Text = NotesObj.Text

        If selectedIndex = ChannelListViewObj.Items.Count - 1 Then
            ChannelListViewObj.Items(selectedIndex).Selected = False
            selectedIndex += 1
            ChannelListViewObj.Items.Add(selectedIndex)
            ChannelListViewObj.Items(selectedIndex).SubItems.Add("")
            If (selectedIndex = 1) Then
            End If
            ChannelListViewObj.Items(selectedIndex).Text = selectedIndex + 1
            ChannelListViewObj.Items(selectedIndex).SubItems.Add("") '(1).Text = MHzComboBoxObj.Items(0)
            ChannelListViewObj.Items(selectedIndex).SubItems.Add("")
            ChannelListViewObj.Items(selectedIndex).SubItems.Add("")
            ChannelListViewObj.Items(selectedIndex).SubItems.Add("")
            ChannelListViewObj.Items(selectedIndex).Selected = True
            ChannelListViewObj.Items(selectedIndex).Checked = True
            ChannelListViewObj.Items(selectedIndex).EnsureVisible()
            ChannelListViewObj.Items(selectedIndex).Selected = True
            ChannelListViewObj.Select()
            UserSelectedChannel = False

            If ChannelListViewObj.Items.Count > 101 Then
                MsgBox("The number of channels in the list has exceeded 100.  Unexpected results may occur if the radio does not support this feature", MsgBoxStyle.Information, "Channel count warning message")
            End If
        End If
    End Sub

    Private Sub ChannelListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab1ChannelListView.SelectedIndexChanged, Tab2ChannelListView.SelectedIndexChanged, Tab3ChannelListView.SelectedIndexChanged
        Dim ChannelListViewObj As ListView
        Dim MHzComboBoxObj As ComboBox
        Dim KHzComboBoxObj As ComboBox
        Dim RepeaterComboBoxObj As ComboBox
        Dim ToneComboBoxObj As ComboBox
        Dim ChannelTextBoxObj As TextBox
        Dim CtcssRadioButtonObj As RadioButton
        Dim ToneRadioButtonObj As RadioButton
        Dim NotesTextObj As TextBox

        If TabControl.SelectedIndex = 0 Then
            ChannelListViewObj = Tab1ChannelListView
            MHzComboBoxObj = Tab1MHzComboBox
            KHzComboBoxObj = Tab1KHzCombBox
            RepeaterComboBoxObj = Tab1RepeaterComboBox
            ToneComboBoxObj = Tab1ToneComboBox
            ChannelTextBoxObj = Tab1ChannelTextBox
            CtcssRadioButtonObj = Tab1CtcssXmitRec
            ToneRadioButtonObj = Tab1CtcssXmit
            NotesTextObj = Tab1ChannelNotes
        ElseIf TabControl.SelectedIndex = 1 Then
            ChannelListViewObj = Tab2ChannelListView
            MHzComboBoxObj = Tab2MHzComboBox
            KHzComboBoxObj = Tab2KHzCombBox
            RepeaterComboBoxObj = Tab2RepeaterComboBox
            ToneComboBoxObj = Tab2ToneComboBox
            ChannelTextBoxObj = Tab2ChannelTextBox
            CtcssRadioButtonObj = Tab2CtcssXmitRec
            ToneRadioButtonObj = Tab2CtcssXmit
            NotesTextObj = Tab2ChannelNotes
        Else
            ChannelListViewObj = Tab3ChannelListView
            MHzComboBoxObj = Tab3MHzComboBox
            KHzComboBoxObj = Tab3KHzCombBox
            RepeaterComboBoxObj = Tab3RepeaterComboBox
            ToneComboBoxObj = Tab3ToneComboBox
            ChannelTextBoxObj = Tab3ChannelTextBox
            CtcssRadioButtonObj = Tab3CtcssXmitRec
            ToneRadioButtonObj = Tab3CtcssXmit
            NotesTextObj = Tab3ChannelNotes
        End If

        If (ChannelListViewObj.SelectedItems.Count > 0) Then
            UserSelectedChannel = True
            ChannelTextBoxObj.Text = ChannelListViewObj.SelectedItems.Item(0).Text
            Dim channelIndex As Int32 = Convert.ToInt32(ChannelListViewObj.SelectedItems.Item(0).Text)
            Dim frequency As Double
            If ((ChannelListViewObj.SelectedItems.Item(0).SubItems.Item(1).Text <> "") And (ChannelListViewObj.SelectedItems.Item(0).SubItems.Item(1).Text <> "BLANK")) Then
                frequency = Convert.ToDouble(fixDecimalSeparator(ChannelListViewObj.SelectedItems.Item(0).SubItems.Item(1).Text))
                MHzComboBoxObj.Text = Convert.ToInt32(frequency - (frequency Mod 1))
                Dim kHzVal As Double = Convert.ToDouble(Math.Round((frequency Mod 1) * 1000, 1))
                Dim kHzString As String = Convert.ToString(kHzVal)
                If kHzVal < 10 Then
                    kHzString = "00" + kHzString
                ElseIf kHzVal < 100 Then
                    kHzString = "0" + kHzString
                End If
                KHzComboBoxObj.Text = kHzString 'Convert.ToInt32((frequency Mod 1) * 1000)
                RepeaterComboBoxObj.Text = ChannelListViewObj.SelectedItems.Item(0).SubItems.Item(2).Text
                ToneComboBoxObj.Text = ChannelListViewObj.SelectedItems.Item(0).SubItems.Item(3).Text
                If ChannelListViewObj.SelectedItems.Item(0).SubItems.Item(3).Text = "OFF" Then
                    CtcssRadioButtonObj.Checked = False
                    ToneRadioButtonObj.Checked = False
                    ToneComboBoxObj.Enabled = False
                ElseIf ChannelListViewObj.SelectedItems.Item(0).SubItems.Item(4).Text = "Xmit" Then
                    ToneRadioButtonObj.Checked = True
                    ToneComboBoxObj.Enabled = True
                ElseIf ChannelListViewObj.SelectedItems.Item(0).SubItems.Item(4).Text = "Xmit/Rec" Then
                    CtcssRadioButtonObj.Checked = True
                    ToneComboBoxObj.Enabled = True
                End If
            ElseIf (ChannelListViewObj.SelectedItems.Item(0).SubItems.Item(1).Text = "BLANK") Then
                MHzComboBoxObj.Text = "BLANK"
                KHzComboBoxObj.Text = ""
                RepeaterComboBoxObj.Text = ""
                ToneComboBoxObj.Text = ""
                ToneComboBoxObj.Enabled = False
                ToneComboBoxObj.Text = ToneComboBoxObj.Items(0)
                CtcssRadioButtonObj.Checked = False
                ToneRadioButtonObj.Checked = False
            End If
            NotesTextObj.Text = ChannelListViewObj.SelectedItems.Item(0).SubItems.Item(5).Text
        End If
    End Sub

    Private Sub MHzComboBox_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tab1MHzComboBox.DropDown, Tab2MHzComboBox.DropDown, Tab3MHzComboBox.DropDown
        'Dim MHzComboBoxObject As ComboBox

        'MHzComboBoxObject = Tab1MHzComboBox
        'Dim itemSelect As Integer = MHzComboBoxObject.Items.Count / 2
        'Dim test As System.IntPtr = Tab1MHzComboBox.Handle
        'test->Events
        'Tab1MHzComboBox.Enabled = False
        'Tab1MHzComboBox.SelectedIndex = 2 'itemSelect

        ''MHzComboBoxObject.DroppedDown = True

    End Sub

    Private Sub MHzComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab1MHzComboBox.SelectedIndexChanged, Tab2MHzComboBox.SelectedIndexChanged, Tab3MHzComboBox.SelectedIndexChanged

        Dim ChannelListViewObj As ListView
        Dim MHzComboBoxObj As ComboBox
        Dim KHzComboBoxObj As ComboBox
        Dim RepeaterComboBoxObj As ComboBox
        Dim ToneComboBoxObj As ComboBox
        Dim ChannelTextBoxObj As TextBox
        Dim KhzStepSizeObj As ToolStripComboBox
        Dim CtcssRadioButtonObj As RadioButton
        Dim ToneRadioButtonObj As RadioButton

        If TabControl.SelectedIndex = 0 Then
            ChannelListViewObj = Tab1ChannelListView
            MHzComboBoxObj = Tab1MHzComboBox
            KHzComboBoxObj = Tab1KHzCombBox
            RepeaterComboBoxObj = Tab1RepeaterComboBox
            ToneComboBoxObj = Tab1ToneComboBox
            ChannelTextBoxObj = Tab1ChannelTextBox
            KhzStepSizeObj = Tab1KHzToolStripComboBox
            CtcssRadioButtonObj = Tab1CtcssXmitRec
            ToneRadioButtonObj = Tab1CtcssXmit
        ElseIf TabControl.SelectedIndex = 1 Then
            ChannelListViewObj = Tab2ChannelListView
            MHzComboBoxObj = Tab2MHzComboBox
            KHzComboBoxObj = Tab2KHzCombBox
            RepeaterComboBoxObj = Tab2RepeaterComboBox
            ToneComboBoxObj = Tab2ToneComboBox
            ChannelTextBoxObj = Tab2ChannelTextBox
            KhzStepSizeObj = Tab2KHzToolStripComboBox
            CtcssRadioButtonObj = Tab2CtcssXmitRec
            ToneRadioButtonObj = Tab2CtcssXmit
        Else
            ChannelListViewObj = Tab3ChannelListView
            MHzComboBoxObj = Tab3MHzComboBox
            KHzComboBoxObj = Tab3KHzCombBox
            RepeaterComboBoxObj = Tab3RepeaterComboBox
            ToneComboBoxObj = Tab3ToneComboBox
            ChannelTextBoxObj = Tab3ChannelTextBox
            KhzStepSizeObj = Tab3KHzToolStripComboBox
            CtcssRadioButtonObj = Tab3CtcssXmitRec
            ToneRadioButtonObj = Tab3CtcssXmit
        End If

        Dim KhzStepSize As Double = KhzStepSizeObj.Text
        If KhzStepSizeObj.Text.StartsWith("12") And decimalSeparator = "," Then
            KhzStepSize = 12.5
        End If

        If ChannelListViewObj.SelectedItems.Count > 0 Then
            If ((UserSelectedChannel = False) Or (ChannelListViewObj.SelectedItems.Item(0).Index = ChannelListViewObj.Items.Count - 1)) Then
                If ((MHzComboBoxObj.Text <> "BLANK") And (MHzComboBoxObj.Text <> "")) Then
                    RepeaterComboBoxObj.Text = "SIMPLEX"
                    If ToneRadioButtonObj.Checked = True Then
                        ToneComboBoxObj.Text = "88.5"
                    Else
                        ToneComboBoxObj.Text = "OFF"
                    End If

                    KHzComboBoxObj.Items.Clear()
                    Dim x As Double
                    x = 0.0
                    Do While x < 1000
                        If (x < 10) Then
                            KHzComboBoxObj.Items.Add(String.Concat("00", Convert.ToString(x)))
                        ElseIf (x < 100) Then
                            KHzComboBoxObj.Items.Add(String.Concat("0", Convert.ToString(x)))
                        Else
                            KHzComboBoxObj.Items.Add(Convert.ToString(x))
                        End If
                        x = x + KhzStepSize
                    Loop

                    'Tab1KHzCombBox.SelectionStart = 100
                    'Tab1KHzCombBox.SelectedIndex = 50
                    KHzComboBoxObj.DroppedDown = True

                End If
            End If
        End If

        RepeaterComboBoxObj.Text = getRepeaterVal(MHzComboBoxObj.Text, KHzComboBoxObj.Text, TabControl.SelectedIndex)

        If ((MHzComboBoxObj.Text = "BLANK") Or (MHzComboBoxObj.Text = "")) Then
            RepeaterComboBoxObj.Text = ""
            ToneComboBoxObj.Text = ""
            KHzComboBoxObj.Text = ""
            CtcssRadioButtonObj.Checked = False
            ToneRadioButtonObj.Checked = False

        End If
    End Sub

    Dim ProgramCannelCount As Int32
    Dim repeaterAryIndex As Integer
    Dim repeaterElements As Integer

    Function getRepeaterIncrement(ByVal str As String) As Integer
        Dim count As Integer = 0

        Static Dim repeaterAry() As String = {"SIMPLEX", "PLUS", "MINUS", "DBL MINUS"}

        Do While str.ToUpper <> repeaterAry(repeaterAryIndex)
            repeaterAryIndex = repeaterAryIndex + 1
            If repeaterAryIndex >= repeaterElements Then
                repeaterAryIndex = 0
            End If
            count = count + 1
            'todo check for overflow
        Loop

        getRepeaterIncrement = count

    End Function

    Dim ctcssAryIndex As Integer

    Function getCtcssIncrement(ByVal str As String) As Integer
        Dim count As Integer = 0

        Static Dim ctcssAry() As String = {"OFF", "XMIT", "XMIT/REC"}
        Static Dim ctcssElements As Integer = 2
        If Form2.Tsu7CheckBox.Checked Then
            ctcssElements = 3
        Else
            ctcssElements = 2
        End If

        Do While str.ToUpper <> ctcssAry(ctcssAryIndex)
            ctcssAryIndex = ctcssAryIndex + 1
            If ctcssAryIndex > ctcssElements - 1 Then
                ctcssAryIndex = 0
            End If
            count = count + 1
            'todo check for overflow
        Loop

        getCtcssIncrement = count

    End Function

    Dim toneAryIndex As Integer

    Function getToneIncrement(ByVal str As String, ByRef command As String) As Integer
        Dim count As Integer = 0

        Static Dim toneAry() As Double = {67.0, 71.9, 74.4, 77.0, 79.7, 82.5, 85.4, 88.5, 91.5, 94.8, 97.4, 100.0, 103.5, 107.2, 110.9, 114.8, 118.8, 123.0, 127.3, 131.8, 136.5, 141.3, 146.2, 151.4, 156.7, 162.2, 167.9, 173.8, 179.9, 186.2, 192.8, 203.5, 210.7, 218.1, 225.7, 233.6, 241.8, 250.3}
        Static Dim toneElements As Integer = toneAry.Length

        If Convert.ToDouble(fixDecimalSeparator(str)) <= toneAry(toneAryIndex) Then
            command = "DOWN"
            Do While Convert.ToDouble(fixDecimalSeparator(str)) <> toneAry(toneAryIndex)
                toneAryIndex = toneAryIndex - 1
                If toneAryIndex = -1 Then
                    'publish an error
                End If
                count = count + 1
            Loop
            getToneIncrement = count
            Exit Function
        Else
            command = "UP"
            Do While Convert.ToDouble(fixDecimalSeparator(str)) <> toneAry(toneAryIndex)
                toneAryIndex = toneAryIndex + 1
                If toneAryIndex = toneElements Then
                    'publish an error
                End If
                count = count + 1
            Loop
            getToneIncrement = count
            Exit Function
        End If

    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab1ProgramButton.Click, Tab2ProgramButton.Click, Tab3ProgramButton.Click
        Dim ProgressBarObj As ProgressBar
        Dim ChannelListViewObj As ListView
        Dim ToolStripStatusLabel As ToolStripStatusLabel
        Dim ToolStripComboBoxObj As ToolStripComboBox
        Dim serialStatus As Boolean = False
        Dim blankChannelCount As Integer = 0
        Dim firstChannelComplete As Boolean = False
        Dim commandLabel As Label

        stopProgrammingRequested = False

        If channelUpdateClicked(TabControl.SelectedIndex) = True Then
            displaySaveMessage()
        End If
        channelUpdateClicked(TabControl.SelectedIndex) = False

        If openSerialPort() <> True Then
            MessageBox.Show("Could not determine Arduino COM port.  Ensure USB cable is plugged in.")
            Exit Sub
        End If

        If TabControl.SelectedIndex = 0 Then
            ProgressBarObj = Tab1ProgressBar1
            ChannelListViewObj = Tab1ChannelListView
            ToolStripStatusLabel = Tab1ToolStripStatusLabel
            ToolStripComboBoxObj = Tab1KHzToolStripComboBox
            commandLabel = Tab1UsbCmdLabel
        ElseIf TabControl.SelectedIndex = 1 Then
            ProgressBarObj = Tab2ProgressBar1
            ChannelListViewObj = Tab2ChannelListView
            ToolStripStatusLabel = Tab2ToolStripStatusLabel
            ToolStripComboBoxObj = Tab2KHzToolStripComboBox
            commandLabel = Tab2UsbCmdLabel
        Else
            ProgressBarObj = Tab3ProgressBar1
            ChannelListViewObj = Tab3ChannelListView
            ToolStripStatusLabel = Tab3ToolStripStatusLabel
            ToolStripComboBoxObj = Tab3KHzToolStripComboBox
            commandLabel = Tab3UsbCmdLabel
        End If

        repeaterAryIndex = 0
        toneAryIndex = 7
        ctcssAryIndex = 0
        repeaterElements = 3

        ToolStripStatusLabel.Text = ""

        Dim modLabel As String = TabControl.SelectedTab.Text
        If modLabel.EndsWith("440e") Or modLabel.EndsWith("1200") Then
            repeaterElements = 4
        End If

        If ChannelListViewObj.Items.Count - 2 < 0 Then
            MsgBox("Error.  At least 1 channel must be set for programming.", MsgBoxStyle.Critical, "Programming error message")
            Exit Sub
        End If

        ProgressBarObj.Maximum = ChannelListViewObj.Items.Count - 2
        Dim mhzLabel As String = TabControl.SelectedTab.Text
        Dim msgResult As MsgBoxResult = MsgBox("1. Reset Band in radio." & _
                                               vbCrLf & "   " & Chr(149) & " Hold 'F' and Band select while turning on radio." _
                                               & vbCrLf & "2. Put radio in 'RC' mode." & vbCrLf & _
                                               "3. Select " & Mid(mhzLabel, 3, mhzLabel.Length - 2) & " MHz band on radio." _
                                               & vbCrLf & "4. Ensure that both the radio and the tabbed channel list frequency step size are correct." _
                                               & vbCrLf & "   " & Chr(149) & " Step size is selectable per tab under the Options menu", MsgBoxStyle.OkCancel + MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton2, "Programming setup message")
        If msgResult = Microsoft.VisualBasic.MsgBoxResult.Cancel Then
            Exit Sub
        End If
        Timer1.Enabled = True

        Dim toneAndButtonOnTime As Integer = 0
        If (Form2.normalRadioTimingButton.Checked) Then
            toneAndButtonOnTime = NORMAL_RADIO_TIMING
        ElseIf (Form2.slowRadioTimingButton.Checked) Then
            toneAndButtonOnTime = SLOW_RADIO_TIMING
        Else
            toneAndButtonOnTime = DEBUG_RADIO_TIMING
        End If

        Dim timeString As String
        timeString = "SET_TONE_TIME:"
        serialStatus = sendString(timeString)
        If serialStatus <> True Then
            Exit Sub
        End If
        timeString = Convert.ToString(toneAndButtonOnTime)
        serialStatus = sendString(timeString)
        If serialStatus <> True Then
            Exit Sub
        End If

        timeString = "SET_BUTTON_TIME:"
        serialStatus = sendString(timeString)
        If serialStatus <> True Then
            Exit Sub
        End If
        timeString = Convert.ToString(toneAndButtonOnTime)
        serialStatus = sendString(timeString)
        If serialStatus <> True Then
            Exit Sub
        End If

        serialStatus = sendString("VFO")
        If serialStatus <> True Then
            Exit Sub
        End If

        For channelIndex As Integer = 0 To ChannelListViewObj.Items.Count - 2
            'change the color of the channel list item for visual programming progress
            ChannelListViewObj.EnsureVisible(channelIndex)
            ProgressBarObj.Value = channelIndex
            ChannelListViewObj.Items(channelIndex).BackColor = Color.LightGreen
            ChannelListViewObj.Update()

            If ChannelListViewObj.Items(channelIndex).SubItems.Item(1).Text = "BLANK" Or ChannelListViewObj.Items(channelIndex).SubItems.Item(1).Text = "" Then
                blankChannelCount = blankChannelCount + 1
            Else
                'send freq digits
                Dim freq As String
                freq = ChannelListViewObj.Items(channelIndex).SubItems.Item(1).Text

                Dim decimalPointLocation = freq.IndexOf(".")
                If decimalPointLocation = -1 Then
                    decimalPointLocation = freq.IndexOf(",")
                End If
                Dim mhzVal As String = Convert.ToString(Mid(freq, 1, decimalPointLocation))
                Dim kHzVal As String = Convert.ToString(Mid(freq, decimalPointLocation + 2))
                Dim numOfKhzChars = 3
                If Convert.ToDouble(fixDecimalSeparator(ToolStripComboBoxObj.SelectedItem)) = 12.5 Or ToolStripComboBoxObj.SelectedItem = 25 Then
                    numOfKhzChars = 2
                End If

                sendString("A")
                Dim freqCharIndex As Integer = 1
                'For loopVar1 As Integer = 0 To mhzVal.Length - 2
                'sendString(mhzVal.Chars(freqCharIndex))
                'freqCharIndex = freqCharIndex + 1
                'Next

                If (Form2.wideBandCheckBox.Checked And TabControl.SelectedTab.Text.Contains("1200")) Then
                    sendString(mhzVal.Chars(mhzVal.Length - 3))
                End If

                If (Not TabControl.SelectedTab.Text.Contains("e") Or TabControl.SelectedTab.Text.Contains("1200")) Then
                    sendString(mhzVal.Chars(mhzVal.Length - 2))
                End If
                sendString(mhzVal.Chars(mhzVal.Length - 1))

                freqCharIndex = 0
                For loopVar As Integer = 0 To numOfKhzChars - 1
                    sendString(kHzVal.Chars(freqCharIndex))
                    freqCharIndex = freqCharIndex + 1
                Next

                If (Form2.AROcheckBox.Checked) Then
                    If (TabControl.SelectedIndex = 0 And Form2.Mod1UT144.Checked) Or _
                       (TabControl.SelectedIndex = 1 And Form2.Mod2UT144.Checked) Or _
                       (TabControl.SelectedIndex = 2 And Form2.Mod3UT144.Checked) Then
                        If (Not Form2.eTypeRadioCheckBox.Checked) Then
                            If Convert.ToDouble(fixDecimalSeparator(freq)) < 145.1 Then
                                getRepeaterIncrement("SIMPLEX")
                            ElseIf Convert.ToDouble(fixDecimalSeparator(freq)) < 145.5 Then
                                getRepeaterIncrement("MINUS")
                            ElseIf Convert.ToDouble(fixDecimalSeparator(freq)) < 146.0 Then
                                getRepeaterIncrement("SIMPLEX")
                            ElseIf Convert.ToDouble(fixDecimalSeparator(freq)) < 146.4 Then
                                getRepeaterIncrement("PLUS")
                            ElseIf Convert.ToDouble(fixDecimalSeparator(freq)) < 146.6 Then
                                getRepeaterIncrement("SIMPLEX")
                            ElseIf Convert.ToDouble(fixDecimalSeparator(freq)) < 147.0 Then
                                getRepeaterIncrement("MINUS")
                            ElseIf Convert.ToDouble(fixDecimalSeparator(freq)) < 147.4 Then
                                getRepeaterIncrement("PLUS")
                            ElseIf Convert.ToDouble(fixDecimalSeparator(freq)) < 147.6 Then
                                getRepeaterIncrement("SIMPLEX")
                            ElseIf Convert.ToDouble(fixDecimalSeparator(freq)) < 148.0 Then
                                getRepeaterIncrement("MINUS")
                            Else
                                getRepeaterIncrement("SIMPLEX")
                            End If
                        Else
                            If Convert.ToDouble(fixDecimalSeparator(freq)) < 145.6 Then
                                getRepeaterIncrement("SIMPLEX")
                            ElseIf Convert.ToDouble(fixDecimalSeparator(freq)) < 145.8 Then
                                getRepeaterIncrement("MINUS")
                            Else
                                getRepeaterIncrement("SIMPLEX")
                            End If
                        End If
                    ElseIf (TabControl.SelectedIndex = 0 And Form2.Mod1UT220.Checked And Not Form2.eTypeRadioCheckBox.Checked) Or _
                           (TabControl.SelectedIndex = 1 And Form2.Mod2UT220.Checked And Not Form2.eTypeRadioCheckBox.Checked) Or _
                           (TabControl.SelectedIndex = 2 And Form2.Mod3UT220.Checked And Not Form2.eTypeRadioCheckBox.Checked) Then
                        If Convert.ToDouble(fixDecimalSeparator(freq)) < 223.92 Then
                            getRepeaterIncrement("SIMPLEX")
                        ElseIf Convert.ToDouble(fixDecimalSeparator(freq)) < 225.0 Then
                            getRepeaterIncrement("MINUS")
                        Else
                            getRepeaterIncrement("SIMPLEX")
                        End If
                    End If
                End If

                Dim repeaterCount As Integer = getRepeaterIncrement(ChannelListViewObj.Items(channelIndex).SubItems.Item(2).Text)
                If repeaterCount > 0 Then
                    For loopVar As Integer = 0 To repeaterCount - 1
                        sendString("1")
                    Next
                End If

                'send ctcss mode
                Dim ctcssCount As Integer = getCtcssIncrement(ChannelListViewObj.Items(channelIndex).SubItems.Item(4).Text)
                If ctcssCount > 0 Then
                    For loopVar As Integer = 0 To ctcssCount - 1
                        sendString("2")
                    Next
                End If

                'send tone increment/decrement
                If ChannelListViewObj.Items(channelIndex).SubItems.Item(4).Text.ToUpper <> "OFF" Then
                    Dim direction As String = ""
                    Dim toneCount As Integer = getToneIncrement(ChannelListViewObj.Items(channelIndex).SubItems.Item(3).Text, direction)
                    If toneCount > 0 Then
                        sendString("D")
                        sendString("2")
                        For loopVar As Integer = 0 To toneCount - 1
                            sendString(direction)
                        Next
                        sendString("2")
                        sendString("PAUSE: ")
                    End If
                End If

                'send memory store and increment
                sendString("D")
                If Not firstChannelComplete Then
                    For y As Integer = 0 To blankChannelCount - 1
                        sendString("UP")
                    Next
                    firstChannelComplete = True
                Else
                    For y As Integer = 0 To blankChannelCount
                        sendString("UP")
                    Next
                End If
                blankChannelCount = 0
                sendString("MR")
                sendString("PAUSE: ")

            End If

            ChannelListViewObj.Items(channelIndex).BackColor = Color.White
            ChannelListViewObj.Update()

            System.Windows.Forms.Application.DoEvents()
            If stopProgrammingRequested Then
                Exit For
            End If
        Next

        ProgressBarObj.Value = ChannelListViewObj.Items.Count - 2
        ChannelListViewObj.Items(ChannelListViewObj.Items.Count - 2).BackColor = Color.White
        Timer1.Enabled = False
        ToolStripStatusLabel.Text = "Programming complete."
        commandLabel.Text = ""
        Tab1UsbRcvdLabel.Text = ""
        Tab2UsbRcvdLabel.Text = ""
        Tab3UsbRcvdLabel.Text = ""

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim ToolStripStatusLabel As ToolStripStatusLabel
        Static Dim cntr As Integer = 0

        If TabControl.SelectedIndex = 0 Then
            ToolStripStatusLabel = Tab1ToolStripStatusLabel
        Else
            ToolStripStatusLabel = Tab2ToolStripStatusLabel
        End If

        If Not ToolStripStatusLabel.Text.Contains("Programming") Then
            cntr = 0
        End If

        If cntr Mod 3 = 0 Then
            ToolStripStatusLabel.Text = "Programming the radio."
        Else
            ToolStripStatusLabel.Text += " ."
        End If

        cntr += 1
    End Sub

    Private Sub KHzStepSizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab1KHzStepSizeToolStripMenuItem.Click, Tab2KHzStepSizeToolStripMenuItem.Click, Tab3KHzStepSizeToolStripMenuItem.Click
        Dim KhzToolStripComboBoxObj As ToolStripComboBox

        If TabControl.SelectedIndex = 0 Then
            KhzToolStripComboBoxObj = Tab1KHzToolStripComboBox
        ElseIf TabControl.SelectedIndex = 1 Then
            KhzToolStripComboBoxObj = Tab2KHzToolStripComboBox
        Else
            KhzToolStripComboBoxObj = Tab3KHzToolStripComboBox
        End If

        KhzToolStripComboBoxObj.DroppedDown = True
    End Sub


    Private Sub Tab1KHzToolStripComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tab1KHzToolStripComboBox.SelectedIndexChanged, Tab2KHzToolStripComboBox.SelectedIndexChanged, Tab3KHzToolStripComboBox.SelectedIndexChanged
        Dim MenuStripObj As MenuStrip
        Dim ToolStripComboBoxObj As ToolStripComboBox
        Dim ToolStripLabelObj As ToolStripLabel
        Dim KHzComboBoxObj As ComboBox

        If TabControl.SelectedIndex = 0 Then
            MenuStripObj = Tab1MenuStrip
            ToolStripComboBoxObj = Tab1KHzToolStripComboBox
            ToolStripLabelObj = Tab1ToolStripStepSize
            KHzComboBoxObj = Tab1KHzCombBox
        ElseIf TabControl.SelectedIndex = 1 Then
            MenuStripObj = Tab2MenuStrip
            ToolStripComboBoxObj = Tab2KHzToolStripComboBox
            ToolStripLabelObj = Tab2ToolStripStepSize
            KHzComboBoxObj = Tab2KHzCombBox
        Else
            MenuStripObj = Tab3MenuStrip
            ToolStripComboBoxObj = Tab3KHzToolStripComboBox
            ToolStripLabelObj = Tab3ToolStripStepSize
            KHzComboBoxObj = Tab3KHzCombBox
        End If

        MenuStripObj.Items(0).Select()
        ToolStripLabelObj.Text = "kHz Step Size: " + ToolStripComboBoxObj.Text

        KHzComboBoxObj.Items.Clear()
        Dim x As Double = 0.0
        Dim KhzStepSize As Double = Convert.ToDouble(fixDecimalSeparator(ToolStripComboBoxObj.Text))
        Do While x < 1000
            If (x < 10) Then
                KHzComboBoxObj.Items.Add(String.Concat("00", Convert.ToString(x)))
            ElseIf (x < 100) Then
                KHzComboBoxObj.Items.Add(String.Concat("0", Convert.ToString(x)))
            Else
                KHzComboBoxObj.Items.Add(Convert.ToString(x))
            End If
            x = x + KhzStepSize
        Loop

        Dim testXml As New XmlDocument
        testXml.Load(Form2.xmlFile)
        If TabControl.SelectedIndex = 0 Then
            If Not ToolStripComboBoxObj.Text.Equals(Form2.radioConfig.tab1StepSize) Then
                testXml.SelectSingleNode("TM742/tab1StepSize").InnerText = Convert.ToString(ToolStripComboBoxObj.Text)
            End If
        ElseIf TabControl.SelectedIndex = 1 Then
            If Not ToolStripComboBoxObj.Text.Equals(Form2.radioConfig.tab2StepSize) Then
                testXml.SelectSingleNode("TM742/tab2StepSize").InnerText = Convert.ToString(ToolStripComboBoxObj.Text)
            End If
        Else
            If Not ToolStripComboBoxObj.Text.Equals(Form2.radioConfig.tab3StepSize) Then
                testXml.SelectSingleNode("TM742/tab3StepSize").InnerText = Convert.ToString(ToolStripComboBoxObj.Text)
            End If
        End If
        testXml.Save(Form2.xmlFile)
    End Sub

    Private Sub Tab1BackToMainMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab1BackToMainMenuToolStripMenuItem.Click, Tab2BackToMainMenuToolStripMenuItem.Click, Tab3BackToMainMenuToolStripMenuItem.Click
        Dim MhzComboBoxObj As ComboBox
        Dim channelListObj As ListView

        If TabControl.SelectedIndex = 0 Then
            MhzComboBoxObj = Tab1MHzComboBox
            channelListObj = Tab1ChannelListView
        ElseIf TabControl.SelectedIndex = 1 Then
            MhzComboBoxObj = Tab2MHzComboBox
            channelListObj = Tab2ChannelListView
        Else
            MhzComboBoxObj = Tab3MHzComboBox
            channelListObj = Tab3ChannelListView
        End If

        If channelListObj.Items.Count > 1 And channelUpdateClicked(TabControl.SelectedIndex) = True Then
            displaySaveMessage()
        End If

        channelUpdateClicked(TabControl.SelectedIndex) = False

        MhzComboBoxObj.Text = "BLANK"
        Me.Visible = False
        '    Form2.Visible = True
        Form2.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab1ClearChannelList.Click, Tab2ClearChannelList.Click, Tab3ClearChannelList.Click
        Dim ChannelListViewObj As ListView
        'Dim KhzToolStripComboBoxObj As ToolStripComboBox
        Dim ToolStripStatusLabelObj As ToolStripLabel
        Dim CtssXmitToneObj As RadioButton
        Dim CtcssXmitRecToneObj As RadioButton


        If TabControl.SelectedIndex = 0 Then
            ChannelListViewObj = Tab1ChannelListView
            'KhzToolStripComboBoxObj = Tab1KHzToolStripComboBox
            ToolStripStatusLabelObj = Tab1ToolStripStatusLabel
            CtssXmitToneObj = Tab1CtcssXmit
            CtcssXmitRecToneObj = Tab1CtcssXmitRec
        ElseIf TabControl.SelectedIndex = 1 Then
            ChannelListViewObj = Tab2ChannelListView
            'KhzToolStripComboBoxObj = Tab2KHzToolStripComboBox
            ToolStripStatusLabelObj = Tab2ToolStripStatusLabel
            CtssXmitToneObj = Tab2CtcssXmit
            CtcssXmitRecToneObj = Tab2CtcssXmitRec
        Else
            ChannelListViewObj = Tab3ChannelListView
            'KhzToolStripComboBoxObj = Tab3KHzToolStripComboBox
            ToolStripStatusLabelObj = Tab3ToolStripStatusLabel
            CtssXmitToneObj = Tab3CtcssXmit
            CtcssXmitRecToneObj = Tab3CtcssXmitRec
        End If

        Dim response As Integer = MsgBox("Are you sure you want to clear the channel list?", MsgBoxStyle.YesNo, "Channel list clear verification")
        If response = vbYes Then
            ChannelListViewObj.Items.Clear()
            ChannelListViewObj.Items.Add(0)
            ChannelListViewObj.Items(0).SubItems.Add("")
            ChannelListViewObj.Items(0).Text = "1"
            ChannelListViewObj.Items(0).SubItems.Add("")
            ChannelListViewObj.Items(0).SubItems.Add("")
            ChannelListViewObj.Items(0).SubItems.Add("")
            ChannelListViewObj.Items(0).SubItems.Add("")
            ChannelListViewObj.Text = "BLANK"
            CtssXmitToneObj.Checked = False
            CtcssXmitRecToneObj.Checked = False
            ChannelListViewObj.Items(0).Selected = True
            ChannelListViewObj.HideSelection() = False
            UserSelectedChannel = False
            'KhzToolStripComboBoxObj.Text = KhzToolStripComboBoxObj.Items(0)
            ToolStripStatusLabelObj.Text = ""
        End If
    End Sub

    Private Sub Tab1CtcssXmit_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Tab1CtcssXmit.MouseDown, Tab1CtcssXmitRec.MouseDown, Tab2CtcssXmit.MouseDown, Tab2CtcssXmitRec.MouseDown, Tab3CtcssXmit.MouseDown, Tab3CtcssXmitRec.MouseDown
        Dim ToneObj As ComboBox
        Dim CtcssXmitObj As RadioButton
        Dim CtcssXmitRecObj As RadioButton

        If TabControl.SelectedIndex = 0 Then
            ToneObj = Tab1ToneComboBox
            CtcssXmitObj = Tab1CtcssXmit
            CtcssXmitRecObj = Tab1CtcssXmitRec
        ElseIf TabControl.SelectedIndex = 1 Then
            ToneObj = Tab2ToneComboBox
            CtcssXmitObj = Tab2CtcssXmit
            CtcssXmitRecObj = Tab2CtcssXmitRec
        Else
            ToneObj = Tab3ToneComboBox
            CtcssXmitObj = Tab3CtcssXmit
            CtcssXmitRecObj = Tab3CtcssXmitRec
        End If

        If CtcssXmitObj.Checked = False And CtcssXmitRecObj.Checked = False Then
            If CtcssXmitObj.Focused Then
                CtcssXmitObj.Checked = True
            ElseIf CtcssXmitRecObj.Focused Then
                CtcssXmitRecObj.Checked = True
            End If
            ToneObj.Enabled = True
            ToneObj.DroppedDown = True
        End If
    End Sub

    Private Sub Tab1ToneComboBox_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tab1ToneComboBox.DropDownClosed
        Dim ToneObj As ComboBox
        Dim CtcssXmitObj As RadioButton
        Dim CtcssXmitRecObj As RadioButton

        If TabControl.SelectedIndex = 0 Then
            ToneObj = Tab1ToneComboBox
            CtcssXmitObj = Tab1CtcssXmit
            CtcssXmitRecObj = Tab1CtcssXmitRec
        ElseIf TabControl.SelectedIndex = 1 Then
            ToneObj = Tab2ToneComboBox
            CtcssXmitObj = Tab2CtcssXmit
            CtcssXmitRecObj = Tab2CtcssXmitRec
        Else
            ToneObj = Tab3ToneComboBox
            CtcssXmitObj = Tab3CtcssXmit
            CtcssXmitRecObj = Tab3CtcssXmitRec
        End If

        If ToneObj.SelectedIndex = 0 Then
            CtcssXmitObj.Checked = False
            CtcssXmitRecObj.Checked = False
            ToneObj.Enabled = False
        End If
    End Sub

    Private Sub Tab1ToneComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab1ToneComboBox.SelectedIndexChanged, Tab2ToneComboBox.SelectedIndexChanged, Tab3ToneComboBox.SelectedIndexChanged
        Dim ToneObj As ComboBox
        Dim CtcssXmitObj As RadioButton
        Dim CtcssXmitRecObj As RadioButton
        Dim CtcssOffObj As RadioButton

        If TabControl.SelectedIndex = 0 Then
            ToneObj = Tab1ToneComboBox
            CtcssXmitObj = Tab1CtcssXmit
            CtcssXmitRecObj = Tab1CtcssXmitRec
            CtcssOffObj = Tab1CtcssOff
        ElseIf TabControl.SelectedIndex = 1 Then
            ToneObj = Tab2ToneComboBox
            CtcssXmitObj = Tab2CtcssXmit
            CtcssXmitRecObj = Tab2CtcssXmitRec
            CtcssOffObj = Tab2CtcssOff
        Else
            ToneObj = Tab3ToneComboBox
            CtcssXmitObj = Tab3CtcssXmit
            CtcssXmitRecObj = Tab3CtcssXmitRec
            CtcssOffObj = Tab3CtcssOff
        End If

        If ToneObj.Text = "OFF" Then
            CtcssXmitObj.Checked = False
            CtcssXmitRecObj.Checked = False
            CtcssOffObj.Checked = True
            ToneObj.Enabled = False
        End If
    End Sub

    Private Sub Tab1SaveChannelFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab1SaveChannelFileToolStripMenuItem.Click, Tab2SaveChannelFileToolStripMenuItem.Click, Tab3SaveChannelFileToolStripMenuItem.Click
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.DefaultExt = "csv"

        'If TabControl.SelectedIndex = 0 Then
        '    If Not tab1ChannelFileName.Equals("") Then
        '        SaveFileDialog1.FileName = tab1ChannelFileName.Text
        '    End If
        'ElseIf TabControl.SelectedIndex = 1 Then
        '    If Not tab2ChannelFileName.Equals("") Then
        '        SaveFileDialog1.FileName = tab2ChannelFileName.Text
        '    End If
        'ElseIf TabControl.SelectedIndex = 2 Then
        '    If Not tab3ChannelFileName.Equals("") Then
        '        SaveFileDialog1.FileName = tab3ChannelFileName.Text
        '    End If
        'End If

        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim myWriter As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(SaveFileDialog1.FileName, False)
        Dim newLine As String = ""

        Dim index As Integer
        Dim channelListView As ListView

        If TabControl.SelectedIndex = 0 Then
            channelListView = Tab1ChannelListView
        ElseIf TabControl.SelectedIndex = 1 Then
            channelListView = Tab2ChannelListView
        Else
            channelListView = Tab3ChannelListView
        End If

        For index = 0 To channelListView.Items.Count - 2
            newLine = ""
            newLine += channelListView.Items(index).SubItems(0).Text + ","
            Dim mhzLcl As String = channelListView.Items(index).SubItems(1).Text
            If (decimalSeparator = ",") Then
                mhzLcl = mhzLcl.Replace(",", ".")
            End If
            newLine += mhzLcl + ","
            newLine += channelListView.Items(index).SubItems(2).Text + ","
            newLine += channelListView.Items(index).SubItems(3).Text + ","
            newLine += channelListView.Items(index).SubItems(4).Text + ","
            newLine += channelListView.Items(index).SubItems(5).Text

            myWriter.WriteLine(newLine)
        Next

        'Dim testXml As New XmlDocument
        'testXml.Load("Tm742Configuration.xml")
        'If TabControl.SelectedIndex = 0 Then
        '    tab1ChannelFileName.Text = SaveFileDialog1.FileName
        '    testXml.SelectSingleNode("TM742/tab1Filename").InnerText = tab1ChannelFileName.Text
        'ElseIf TabControl.SelectedIndex = 1 Then
        '    tab2ChannelFileName.Text = SaveFileDialog1.FileName
        '    testXml.SelectSingleNode("TM742/tab2Filename").InnerText = tab2ChannelFileName.Text
        'Else
        '    tab3ChannelFileName.Text = SaveFileDialog1.FileName
        '    testXml.SelectSingleNode("TM742/tab3Filename").InnerText = tab3ChannelFileName.Text
        'End If
        'testXml.Save("Tm742Configuration.xml")
        myWriter.Close()

        channelUpdateClicked(TabControl.SelectedIndex) = False

    End Sub

    Private Sub Tab1OpenChannelFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab1OpenChannelFileToolStripMenuItem.Click, Tab2OpenChannelFileToolStripMenuItem.Click, Tab3OpenChannelFileToolStripMenuItem.Click

        'If TabControl.SelectedIndex = 0 Then
        '    If Not tab1ChannelFileName.Equals("") Then
        '        OpenFileDialog1.FileName = tab1ChannelFileName.Text
        '    End If
        'ElseIf TabControl.SelectedIndex = 1 Then
        '    If Not tab2ChannelFileName.Equals("") Then
        '        OpenFileDialog1.FileName = tab2ChannelFileName.Text
        '    End If
        'ElseIf TabControl.SelectedIndex = 2 Then
        '    If Not tab3ChannelFileName.Equals("") Then
        '        OpenFileDialog1.FileName = tab3ChannelFileName.Text
        '    End If
        'End If
        'OpenFileDialog1.ShowHelp = True
        OpenFileDialog1.ShowDialog()
    End Sub


    Private Sub OpenFileDialog1_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim myParser As Microsoft.VisualBasic.FileIO.TextFieldParser = My.Computer.FileSystem.OpenTextFieldParser(OpenFileDialog1.FileName)
        myParser.SetDelimiters(",")

        Dim testAry(5) As String
        Dim indexLcl As Integer = 0
        Dim channelListView As ListView
        Dim mhzComboBox As ComboBox
        Dim khzComboBox As ComboBox
        Dim repeaterComboBox As ComboBox
        Dim toneComboBox As ComboBox
        Dim notesTextObj As TextBox

        If TabControl.SelectedIndex = 0 Then
            channelListView = Tab1ChannelListView
            mhzComboBox = Tab1MHzComboBox
            khzComboBox = Tab1KHzCombBox
            repeaterComboBox = Tab1RepeaterComboBox
            toneComboBox = Tab1ToneComboBox
            notesTextObj = Tab1ChannelNotes
        ElseIf TabControl.SelectedIndex = 1 Then
            channelListView = Tab2ChannelListView
            mhzComboBox = Tab2MHzComboBox
            khzComboBox = Tab2KHzCombBox
            repeaterComboBox = Tab2RepeaterComboBox
            toneComboBox = Tab2ToneComboBox
            notesTextObj = Tab2ChannelNotes
        Else
            channelListView = Tab3ChannelListView
            mhzComboBox = Tab3MHzComboBox
            khzComboBox = Tab3KHzCombBox
            repeaterComboBox = Tab3RepeaterComboBox
            toneComboBox = Tab3ToneComboBox
            notesTextObj = Tab3ChannelNotes
        End If

        channelListView.Items.Clear()

        While Not myParser.EndOfData
            testAry = myParser.ReadFields
            channelListView.Items.Add(indexLcl)
            channelListView.Items(indexLcl).Text = indexLcl + 1
            If (testAry(1) = "BLANK") Then
                channelListView.Items(indexLcl).SubItems.Add("BLANK")
                channelListView.Items(indexLcl).SubItems.Add("")
                channelListView.Items(indexLcl).SubItems.Add("")
                channelListView.Items(indexLcl).SubItems.Add("")
                channelListView.Items(indexLcl).SubItems.Add("")
                If testAry.Length = 6 Then
                    channelListView.Items(indexLcl).SubItems.Item(5).Text = testAry(5)
                End If
            Else
                Dim testVal As Double = Convert.ToDouble(fixDecimalSeparator(testAry(1)))
                'Dim freqStr As String = testAry(1)
                'Dim decimalPointLocation = freqStr.IndexOf(".")
                'If decimalPointLocation = -1 Then
                '    decimalPointLocation = freqStr.IndexOf(",")
                'End If
                'Dim mhzVal As String = Convert.ToString(Mid(freqStr, 1, decimalPointLocation))
                'Dim kHzVal As String = Convert.ToString(Mid(freqStr, decimalPointLocation + 2))
                'Dim testVal As Double = Convert.ToDouble(mhzVal) + (Convert.ToDouble(kHzVal) * 0.001)
                If mhzComboBox.Items.Contains(Convert.ToString(Math.Truncate(testVal))) And ((Math.Round(testVal * 10000, 0) Mod 12.5 = 0) Or (Math.Round(testVal * 1000, 0) Mod 5) = 0) Then
                    channelListView.Items(indexLcl).SubItems.Add(testAry(1))
                Else
                    MsgBox("Channel frequency in file is not valid for this module selection !", MsgBoxStyle.Critical, "Programming setup message")
                    clearList()
                    Exit Sub
                End If

                If repeaterComboBox.Items.Contains(testAry(2)) Then
                    channelListView.Items(indexLcl).SubItems.Add(testAry(2))
                Else
                    MsgBox("Repeater value in file is not valid for this module selection !", MsgBoxStyle.Critical, "Programming setup message")
                    clearList()
                    Exit Sub
                End If

                If toneComboBox.Items.Contains(testAry(3)) Then
                    channelListView.Items(indexLcl).SubItems.Add(testAry(3))
                Else
                    MsgBox("Tone value in file is not valid for this module selection !", MsgBoxStyle.Critical, "Programming setup message")
                    clearList()
                    Exit Sub
                End If

                If Not (Form2.Tsu7CheckBox.Checked = False And testAry(4) = "Xmit/Rec") Then
                    channelListView.Items(indexLcl).SubItems.Add(testAry(4))
                Else
                    MsgBox("CTCSS value in file is not valid for this module selection - defaulting to Xmit only  !", MsgBoxStyle.Critical, "Programming setup message")
                    channelListView.Items(indexLcl).SubItems.Add("Xmit")
                End If

                If testAry.Length = 6 Then
                    channelListView.Items(indexLcl).SubItems.Add(testAry(5))
                Else
                    channelListView.Items(indexLcl).SubItems.Add("")
                End If
            End If
            channelListView.Items(indexLcl).EnsureVisible()
            indexLcl += 1
        End While

        channelListView.Items.Add(indexLcl)
        channelListView.Items(indexLcl).Text = indexLcl + 1
        channelListView.Items(indexLcl).SubItems.Add("BLANK")
        channelListView.Items(indexLcl).SubItems.Add("")
        channelListView.Items(indexLcl).SubItems.Add("")
        channelListView.Items(indexLcl).SubItems.Add("")
        channelListView.Items(indexLcl).SubItems.Add("")
        channelListView.Items(indexLcl).Selected = True

        myParser.Close()

        channelUpdateClicked(TabControl.SelectedIndex) = False

    End Sub

    Private Sub clearList()
        Dim ChannelListViewObj As ListView
        Dim KhzToolStripComboBoxObj As ToolStripComboBox
        Dim ToolStripStatusLabelObj As ToolStripLabel
        Dim CtssToneObj As RadioButton

        If TabControl.SelectedIndex = 0 Then
            ChannelListViewObj = Tab1ChannelListView
            KhzToolStripComboBoxObj = Tab1KHzToolStripComboBox
            ToolStripStatusLabelObj = Tab1ToolStripStatusLabel
            CtssToneObj = Tab1CtcssXmit
        ElseIf TabControl.SelectedIndex = 1 Then
            ChannelListViewObj = Tab2ChannelListView
            KhzToolStripComboBoxObj = Tab2KHzToolStripComboBox
            ToolStripStatusLabelObj = Tab2ToolStripStatusLabel
            CtssToneObj = Tab2CtcssXmit
        Else
            ChannelListViewObj = Tab3ChannelListView
            KhzToolStripComboBoxObj = Tab3KHzToolStripComboBox
            ToolStripStatusLabelObj = Tab3ToolStripStatusLabel
            CtssToneObj = Tab3CtcssXmit
        End If

        ChannelListViewObj.Items.Clear()
        ChannelListViewObj.Items.Add(0)
        ChannelListViewObj.Items(0).Text = "1"
        ChannelListViewObj.Items(0).SubItems.Add("")
        ChannelListViewObj.Items(0).SubItems.Add("")
        ChannelListViewObj.Items(0).SubItems.Add("")
        ChannelListViewObj.Items(0).SubItems.Add("")
        ChannelListViewObj.Items(0).SubItems.Add("")
        ChannelListViewObj.Text = 0
        ChannelListViewObj.Text = "BLANK"
        CtssToneObj.Checked = True
        ChannelListViewObj.Items(0).Selected = True
        ChannelListViewObj.HideSelection() = False
        UserSelectedChannel = False
        'KhzToolStripComboBoxObj.Text = KhzToolStripComboBoxObj.Items(0)
        ToolStripStatusLabelObj.Text = ""

    End Sub

    Function sendString(ByVal strLcl As String) As Boolean
        Dim commandLabel As Label
        'Dim cmdRcvdObj As Label

        If TabControl.SelectedIndex = 0 Then
            commandLabel = Tab1UsbCmdLabel
            'cmdRcvdObj = Tab1UsbRcvdLabel
        ElseIf TabControl.SelectedIndex = 1 Then
            commandLabel = Tab2UsbCmdLabel
            'cmdRcvdObj = Tab2UsbRcvdLabel
        Else
            commandLabel = Tab3UsbCmdLabel
            'cmdRcvdObj = Tab3UsbRcvdLabel
        End If

        'cmdRcvdObj.Text = ""
        'cmdRcvdObj.Update()
        commandLabel.Text = strLcl
        commandLabel.Update()

        If Not DEBUG Then
            SerialPort1.WriteLine(strLcl + Chr(13))
            sendString = waitForReady()
        Else
            Sleep(200)
            sendString = True

        End If
    End Function

    Dim newDataAvailable As Boolean = False

    Function waitForReady() As Boolean
        Dim cntrLcl As Integer = 0

        Dim cmdRcvdObj As Label

        If TabControl.SelectedIndex = 0 Then
            cmdRcvdObj = Tab1UsbRcvdLabel
        ElseIf TabControl.SelectedIndex = 1 Then
            cmdRcvdObj = Tab2UsbRcvdLabel
        Else
            cmdRcvdObj = Tab3UsbRcvdLabel
        End If

        Do
            Sleep(200)
            System.Windows.Forms.Application.DoEvents()
            If newDataAvailable Then
                cmdRcvdObj.Text = recvdData
                cmdRcvdObj.Update()
            End If
            If newDataAvailable And recvdData.Contains("READY") Then
                newDataAvailable = False
                waitForReady = True
                Exit Function
            Else
                cntrLcl = cntrLcl + 1
            End If
        Loop Until cntrLcl = 10
        newDataAvailable = False
        waitForReady = False
    End Function

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

        recvdData = SerialPort1.ReadLine()
        newDataAvailable = True
    End Sub


    Private Sub Tab1KHzCombBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab1KHzCombBox.SelectedIndexChanged, Tab2KHzCombBox.SelectedIndexChanged, Tab3KHzCombBox.SelectedIndexChanged

        Dim MhzComboBox As Object
        Dim KhzComboBox As Object
        Dim RepeaterComboBox As Object

        If TabControl.SelectedIndex = 0 Then
            MhzComboBox = Tab1MHzComboBox
            KhzComboBox = Tab1KHzCombBox
            RepeaterComboBox = Tab1RepeaterComboBox
        ElseIf TabControl.SelectedIndex = 1 Then
            MhzComboBox = Tab2MHzComboBox
            KhzComboBox = Tab2KHzCombBox
            RepeaterComboBox = Tab2RepeaterComboBox
        Else
            MhzComboBox = Tab3MHzComboBox
            KhzComboBox = Tab3KHzCombBox
            RepeaterComboBox = Tab3RepeaterComboBox
        End If

        RepeaterComboBox.Text = getRepeaterVal(MhzComboBox.text, KhzComboBox.text, TabControl.SelectedIndex)

    End Sub

    Function getRepeaterVal(ByVal mHz As String, ByVal kHz As String, ByVal tabIndex As Integer) As String

        If mHz = "" Or kHz = "" Or mHz = "BLANK" Then
            getRepeaterVal = "SIMPLEX"
            Exit Function
        End If

        Dim frequency As Double
        frequency = Convert.ToDouble(fixDecimalSeparator(mHz)) + (Convert.ToDouble(fixDecimalSeparator(kHz)) / 1000.0)

        If (tabIndex = 0 And Form2.Mod1UT144.Checked) Or _
           (tabIndex = 1 And Form2.Mod2UT144.Checked) Or _
           (tabIndex = 2 And Form2.Mod3UT144.Checked) Then
            If (Not Form2.eTypeRadioCheckBox.Checked) Then
                If frequency < 145.1 Then
                    getRepeaterVal = "SIMPLEX"
                ElseIf frequency < 145.5 Then
                    getRepeaterVal = "MINUS"
                ElseIf frequency < 146.0 Then
                    getRepeaterVal = "SIMPLEX"
                ElseIf frequency < 146.4 Then
                    getRepeaterVal = "PLUS"
                ElseIf frequency < 146.6 Then
                    getRepeaterVal = "SIMPLEX"
                ElseIf frequency < 147.0 Then
                    getRepeaterVal = "MINUS"
                ElseIf frequency < 147.4 Then
                    getRepeaterVal = "PLUS"
                ElseIf frequency < 147.6 Then
                    getRepeaterVal = "SIMPLEX"
                ElseIf frequency < 148.0 Then
                    getRepeaterVal = "MINUS"
                Else
                    getRepeaterVal = "SIMPLEX"
                End If
            Else
                If frequency < 145.6 Then
                    getRepeaterVal = "SIMPLEX"
                ElseIf frequency < 145.8 Then
                    getRepeaterVal = "MINUS"
                Else
                    getRepeaterVal = "SIMPLEX"
                End If
            End If
        ElseIf (tabIndex = 0 And Form2.Mod1UT220.Checked And Not Form2.eTypeRadioCheckBox.Checked) Or _
               (tabIndex = 1 And Form2.Mod2UT220.Checked And Not Form2.eTypeRadioCheckBox.Checked) Or _
               (tabIndex = 2 And Form2.Mod3UT220.Checked And Not Form2.eTypeRadioCheckBox.Checked) Then
            If frequency < 223.92 Then
                getRepeaterVal = "SIMPLEX"
            ElseIf frequency < 225.0 Then
                getRepeaterVal = "MINUS"
            Else
                getRepeaterVal = "SIMPLEX"
            End If
        Else
            getRepeaterVal = "SIMPLEX"
        End If
    End Function

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing

        Dim channelListObj As ListView

        If TabControl.SelectedIndex = 0 Then
            channelListObj = Tab1ChannelListView
        ElseIf TabControl.SelectedIndex = 1 Then
            channelListObj = Tab2ChannelListView
        Else
            channelListObj = Tab3ChannelListView
        End If

        Static test As Boolean = False
        SerialPort1.Close()

        If (test = False) Then
            If channelListObj.Items.Count > 1 And channelUpdateClicked(TabControl.SelectedIndex) = True Then
                displaySaveMessage()
            End If

            channelUpdateClicked(TabControl.SelectedIndex) = False

            test = True
            Form2.Close()
            Me.Close()
        End If

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab1InsertRowButton.Click, Tab2InsertRowButton.Click, Tab3InsertRowButton.Click
        Dim ChannelListViewObj As ListView

        If TabControl.SelectedIndex = 0 Then
            ChannelListViewObj = Tab1ChannelListView
        ElseIf TabControl.SelectedIndex = 1 Then
            ChannelListViewObj = Tab2ChannelListView
        Else
            ChannelListViewObj = Tab3ChannelListView
        End If

        Dim numOfChannels As Integer = ChannelListViewObj.Items.Count

        Try

            Dim channelIndex As Int32 = Convert.ToInt32(ChannelListViewObj.SelectedItems.Item(0).Text)

            If channelIndex < numOfChannels Then
                ChannelListViewObj.Items.Insert(channelIndex, "")
                ChannelListViewObj.Items(channelIndex).SubItems.Add("BLANK")
                ChannelListViewObj.Items(channelIndex).SubItems.Add("")
                ChannelListViewObj.Items(channelIndex).SubItems.Add("")
                ChannelListViewObj.Items(channelIndex).SubItems.Add("")
                ChannelListViewObj.Items(channelIndex).SubItems.Add("")

                For x As Integer = 0 To numOfChannels
                    ChannelListViewObj.Items(x).SubItems(0).Text = x + 1
                Next

                ChannelListViewObj.Items(channelIndex).Selected = True
                ChannelListViewObj.Select()

                If ChannelListViewObj.Items.Count > 101 Then
                    MsgBox("The number of channels in the list has exceeded 100.  Unexpected results may occur if the radio does not support this feature", MsgBoxStyle.Information, "Channel count warning message")
                End If

                channelUpdateClicked(TabControl.SelectedIndex) = True
            End If
        Catch
        End Try

    End Sub

    Private Sub stopProgramButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab1StopProgramButton.Click, Tab2StopProgramButton.Click, Tab3StopProgramButton.Click
        stopProgrammingRequested = True
    End Sub

    Function displaySaveMessage() As Boolean
        displaySaveMessage = True

        Dim saveFile As ToolStripMenuItem

        If TabControl.SelectedIndex = 0 Then
            saveFile = Tab1SaveChannelFileToolStripMenuItem
        ElseIf TabControl.SelectedIndex = 1 Then
            saveFile = Tab2SaveChannelFileToolStripMenuItem
        Else
            saveFile = Tab3SaveChannelFileToolStripMenuItem
        End If

        Dim msgResult As MsgBoxResult = MsgBox("Would you like to save changes to your Channel List file before continuing?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton2, "Save query message")
        If msgResult = Microsoft.VisualBasic.MsgBoxResult.Yes Then
            saveFile.PerformClick()
            'displaySaveMessage = False
        End If

        'Tab1SaveChannelFileToolStripMenuItem.PerformClick()

    End Function

    Private Sub TabControl_Deselecting(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles TabControl.Deselecting
        Dim channelListObj As ListView


        If TabControl.SelectedIndex = 0 Then
            channelListObj = Tab1ChannelListView
        ElseIf TabControl.SelectedIndex = 1 Then
            channelListObj = Tab2ChannelListView
        Else
            channelListObj = Tab3ChannelListView
        End If

        If channelListObj.Items.Count > 1 And Not Form2.initializing And channelUpdateClicked(TabControl.SelectedIndex) = True Then
            If (displaySaveMessage() = False) Then
                e.Cancel = True
                Exit Sub
            End If
        End If

        channelUpdateClicked(TabControl.SelectedIndex) = False
    End Sub

    Private Sub Tab1DeleteRowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab1DeleteRowButton.Click, Tab2DeleteRowButton.Click, Tab3DeleteRowButton.Click
        Dim ChannelListViewObj As ListView

        If TabControl.SelectedIndex = 0 Then
            ChannelListViewObj = Tab1ChannelListView
        ElseIf TabControl.SelectedIndex = 1 Then
            ChannelListViewObj = Tab2ChannelListView
        Else
            ChannelListViewObj = Tab3ChannelListView
        End If

        Dim numOfChannels As Integer = ChannelListViewObj.Items.Count

        Try
            Dim channelIndex As Int32 = Convert.ToInt32(ChannelListViewObj.SelectedItems.Item(0).Text)

            If channelIndex > 1 And channelIndex < numOfChannels Then
                ChannelListViewObj.Items.RemoveAt(channelIndex - 1)

                For x As Integer = 0 To numOfChannels - 2
                    ChannelListViewObj.Items(x).SubItems(0).Text = x + 1
                Next

                ChannelListViewObj.Items(channelIndex - 1).Selected = True
                ChannelListViewObj.Select()

                channelUpdateClicked(TabControl.SelectedIndex) = True

            End If
        Catch
        End Try
    End Sub

    Function fixDecimalSeparator(ByVal inputStr As String) As String
        fixDecimalSeparator = inputStr
        If (decimalSeparator = ",") Then
            fixDecimalSeparator = inputStr.Replace(".", ",")
        End If
    End Function


    Private Sub Tab2CtcssOff_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab1CtcssOff.CheckedChanged, Tab2CtcssOff.CheckedChanged, Tab3CtcssOff.CheckedChanged
        Dim ToneObj As ComboBox
        Dim CtcssXmitObj As RadioButton
        Dim CtcssXmitRecObj As RadioButton
        Dim CtcssOffObj As RadioButton

        If TabControl.SelectedIndex = 0 Then
            ToneObj = Tab1ToneComboBox
            CtcssXmitObj = Tab1CtcssXmit
            CtcssXmitRecObj = Tab1CtcssXmitRec
            CtcssOffObj = Tab1CtcssOff
        ElseIf TabControl.SelectedIndex = 1 Then
            ToneObj = Tab2ToneComboBox
            CtcssXmitObj = Tab2CtcssXmit
            CtcssXmitRecObj = Tab2CtcssXmitRec
            CtcssOffObj = Tab2CtcssOff
        Else
            ToneObj = Tab3ToneComboBox
            CtcssXmitObj = Tab3CtcssXmit
            CtcssXmitRecObj = Tab3CtcssXmitRec
            CtcssOffObj = Tab3CtcssOff
        End If

        If CtcssOffObj.Checked Then
            CtcssXmitObj.Checked = False
            CtcssXmitRecObj.Checked = False
            CtcssOffObj.Checked = True
            ToneObj.Text = ToneObj.Items(0)
            ToneObj.Enabled = False
        End If
    End Sub
End Class

