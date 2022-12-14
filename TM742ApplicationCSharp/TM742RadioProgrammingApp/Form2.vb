Imports System.IO
Imports System.Xml

Public Class Form2

    Public Structure radioConfigStruct
        Public usbPort As Integer
        Public eType As Boolean
        Public tsu7Installed As Boolean
        Public wideBand As Boolean
        Public ARO As Boolean
        Public timingMode As Integer
        Public tab1Mod As String
        Public tab1Filename As String
        Public tab1StepSize As String
        Public tab2Mod As String
        Public tab2StepSize As String
        Public tab2Filename As String
        Public tab3Mod As String
        Public tab3StepSize As String
        Public tab3Filename As String
    End Structure

    Public initializing As Boolean = False
    Public tabHasChanged(0 To 2) As Boolean
    Public tabFilename(0 To 2) As String
    Public radioConfig As radioConfigStruct
    Public applicationPath As String
    Public xmlFile As String

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        applicationPath = Application.StartupPath
        xmlFile = applicationPath
        xmlFile = String.Concat(xmlFile, "\Tm742Configuration.xml")

        ToolTip1.AutoPopDelay = 32000
        ToolTip1.InitialDelay = 1000
        ToolTip1.ReshowDelay = 500
        ToolTip1.SetToolTip(GroupBox5, "These radio buttons control the DTMF tone and button press duration for programming" & vbCrLf & _
        Chr(149) & "The normal selection uses an 80 millisecond duration" & vbCrLf & _
        Chr(149) & "The slow selection uses a 250 millisecond duration" & vbCrLf & _
        Chr(149) & "The debug selection uses a 1 second duration (this is slow enough that one can follow the actual commands being sent to the radio" & vbCrLf & _
        "These selections are useful for different radio models/firmware.  If the normal (default) duration does not work properly, try the slow setting")

        Mod1None.Checked() = True
        Mod2None.Checked() = True
        Mod3None.Checked() = True

        For x As Integer = 0 To tabHasChanged.Length - 1
            tabHasChanged(x) = False
            tabFilename(x) = ""
        Next

        Dim testXml As New XmlDocument
        testXml.Load(xmlFile)
        radioConfig.usbPort = Convert.ToInt32(testXml.SelectSingleNode("TM742/usbPort").InnerText)
        radioConfig.eType = Convert.ToBoolean(testXml.SelectSingleNode("TM742/eType").InnerText)
        radioConfig.tsu7Installed = Convert.ToBoolean(testXml.SelectSingleNode("TM742/tsu7Installed").InnerText)
        radioConfig.wideBand = Convert.ToBoolean(testXml.SelectSingleNode("TM742/wideBand").InnerText)
        radioConfig.ARO = Convert.ToBoolean(testXml.SelectSingleNode("TM742/ARO").InnerText)
        'radioConfig.timingMode = Convert.ToBoolean(testXml.SelectSingleNode("TM742/timingMode").InnerText)
        radioConfig.tab1Mod = Convert.ToString(testXml.SelectSingleNode("TM742/tab1Mod").InnerText)
        radioConfig.tab1StepSize = Convert.ToString(testXml.SelectSingleNode("TM742/tab1StepSize").InnerText)
        radioConfig.tab1Filename = Convert.ToString(testXml.SelectSingleNode("TM742/tab1Filename").InnerText)
        radioConfig.tab2Mod = Convert.ToString(testXml.SelectSingleNode("TM742/tab2Mod").InnerText)
        radioConfig.tab2StepSize = Convert.ToString(testXml.SelectSingleNode("TM742/tab2StepSize").InnerText)
        radioConfig.tab2Filename = Convert.ToString(testXml.SelectSingleNode("TM742/tab2Filename").InnerText)
        radioConfig.tab3Mod = Convert.ToString(testXml.SelectSingleNode("TM742/tab3Mod").InnerText)
        radioConfig.tab3StepSize = Convert.ToString(testXml.SelectSingleNode("TM742/tab3StepSize").InnerText)
        radioConfig.tab3Filename = Convert.ToString(testXml.SelectSingleNode("TM742/tab3Filename").InnerText)

        If radioConfig.eType = True Then
            eTypeRadioCheckBox.Checked = True
        End If
        If radioConfig.tsu7Installed = True Then
            Tsu7CheckBox.Checked = True
        End If
        If radioConfig.wideBand = True Then
            wideBandCheckBox.Checked = True
        End If
        If radioConfig.ARO = True Then
            AROcheckBox.Checked = True
        End If
        If radioConfig.timingMode = 0 Then
            normalRadioTimingButton.Checked = True
        ElseIf radioConfig.timingMode = 1 Then
            slowRadioTimingButton.Checked = True
        Else
            debugRadioTimingButton.Checked = True
        End If

        Select Case radioConfig.tab1Mod
            Case "Mod1UT30"
                Mod1UT30.Checked = True
            Case "Mod1UT50"
                Mod1UT50.Checked = True
            Case "Mod1UT144", "Mod1UT144e"
                Mod1UT144.Checked = True
            Case "Mod1UT220"
                Mod1UT220.Checked = True
            Case "Mod1UT440", "Mod1UT440e"
                Mod1UT440.Checked = True
            Case "Mod1UT1200", "Mod1UT1200e"
                Mod1UT1200.Checked = True
            Case Else
                'do nothing
        End Select

        Select Case radioConfig.tab2Mod
            Case "Mod2UT30"
                Mod2UT30.Checked = True
            Case "Mod2UT50"
                Mod2UT50.Checked = True
            Case "Mod2UT144", "Mod2UT144e"
                Mod2UT144.Checked = True
            Case "Mod2UT220"
                Mod2UT220.Checked = True
            Case "Mod2UT440", "Mod2UT440e"
                Mod2UT440.Checked = True
            Case "Mod2UT1200", "Mod2UT1200e"
                Mod2UT1200.Checked = True
            Case Else
                'do nothing
        End Select

        Select Case radioConfig.tab3Mod
            Case "Mod3UT30"
                Mod3UT30.Checked = True
            Case "Mod3UT50"
                Mod3UT50.Checked = True
            Case "Mod3UT144", "Mod3UT144e"
                Mod3UT144.Checked = True
            Case "Mod3UT220"
                Mod3UT220.Checked = True
            Case "Mod3UT440", "Mod3UT440e"
                Mod3UT440.Checked = True
            Case "Mod3UT1200", "Mod3UT1200e"
                Mod3UT1200.Checked = True
            Case Else
                'do nothing
        End Select

        'If Not radioConfig.tab1Filename.Equals("NULL") Then
        '    Form1.tab1ChannelFileName.Text = radioConfig.tab1Filename
        'Else
        '    Form1.tab1ChannelFileName.Text = ""
        'End If
        'If Not radioConfig.tab2Filename.Equals("NULL") Then
        '    Form1.tab2ChannelFileName.Text = radioConfig.tab2Filename
        'Else
        '    Form1.tab2ChannelFileName.Text = ""
        'End If
        'If Not radioConfig.tab3Filename.Equals("NULL") Then
        '    Form1.tab3ChannelFileName.Text = radioConfig.tab3Filename
        'Else
        '    Form1.tab3ChannelFileName.Text = ""
        'End If

    End Sub

    Private Sub ChannelLists_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChannelLists.Click
        If Mod1None.Checked = True And Mod2None.Checked = True And Mod3None.Checked = True Then
            MsgBox("At least one module must be selected to continue.", MsgBoxStyle.Critical, "Module selection check")
            Return
        End If

        '        Me.Visible = False
        Dim y As Integer

        initializing = True

        y = 2
        Form1.TabControl.SelectedIndex = y
        If Mod3UT30.Checked = True Then
            Form1.TabControl.SelectedTab.Text = Mod3UT30.Text
        ElseIf Mod3UT50.Checked = True Then
            Form1.TabControl.SelectedTab.Text = Mod3UT50.Text
        ElseIf Mod3UT144.Checked And eTypeRadioCheckBox.Checked Then
            Form1.TabControl.SelectedTab.Text = Mod1UT144.Text + "e"
        ElseIf Mod3UT144.Checked = True Then
            Form1.TabControl.SelectedTab.Text = Mod3UT144.Text
        ElseIf Mod3UT220.Checked = True Then
            Form1.TabControl.SelectedTab.Text = Mod3UT220.Text
        ElseIf Mod3UT440.Checked And eTypeRadioCheckBox.Checked Then
            Form1.TabControl.SelectedTab.Text = Mod3UT440.Text + "e"
        ElseIf Mod3UT440.Checked Then
            Form1.TabControl.SelectedTab.Text = Mod3UT440.Text
        ElseIf Mod3UT1200.Checked And eTypeRadioCheckBox.Checked Then
            Form1.TabControl.SelectedTab.Text = Mod3UT1200.Text + "e"
        ElseIf Mod3UT1200.Checked = True Then
            Form1.TabControl.SelectedTab.Text = Mod3UT1200.Text
        End If
        If Mod3None.Checked = True Then
            Form1.TabControl.SelectedTab.Text = "Mod3 Not Installed"
            Form1.Panel20.Enabled = False
            Form1.Panel22.Enabled = False
            Form1.Panel23.Enabled = False
        Else
            Form1.Panel20.Enabled = True
            Form1.Panel22.Enabled = True
            Form1.Panel23.Enabled = True
        End If

        If Not radioConfig.tab3Filename.Contains(Form1.TabControl.SelectedTab.Text) Then
            tabHasChanged(2) = True
        End If

        y = 1
        Form1.TabControl.SelectedIndex = y
        If Mod2UT30.Checked = True Then
            Form1.TabControl.SelectedTab.Text = Mod2UT30.Text
        ElseIf Mod2UT50.Checked = True Then
            Form1.TabControl.SelectedTab.Text = Mod2UT50.Text
        ElseIf Mod2UT144.Checked And eTypeRadioCheckBox.Checked Then
            Form1.TabControl.SelectedTab.Text = Mod1UT144.Text + "e"
        ElseIf Mod2UT144.Checked = True Then
            Form1.TabControl.SelectedTab.Text = Mod2UT144.Text
        ElseIf Mod2UT220.Checked = True Then
            Form1.TabControl.SelectedTab.Text = Mod2UT220.Text
        ElseIf Mod2UT440.Checked And eTypeRadioCheckBox.Checked Then
            Form1.TabControl.SelectedTab.Text = Mod2UT440.Text + "e"
        ElseIf Mod2UT440.Checked = True Then
            Form1.TabControl.SelectedTab.Text = Mod2UT440.Text
        ElseIf Mod2UT1200.Checked And eTypeRadioCheckBox.Checked Then
            Form1.TabControl.SelectedTab.Text = Mod2UT1200.Text + "e"
        ElseIf Mod2UT1200.Checked = True Then
            Form1.TabControl.SelectedTab.Text = Mod2UT1200.Text
        End If
        If Mod2None.Checked = True Then
            Form1.TabControl.SelectedTab.Text = "Mod2 Not Installed"
            Form1.Panel11.Enabled = False
            Form1.Panel12.Enabled = False
            Form1.Panel15.Enabled = False
        Else
            Form1.Panel11.Enabled = True
            Form1.Panel12.Enabled = True
            Form1.Panel15.Enabled = True
        End If

        If Not radioConfig.tab2Filename.Contains(Form1.TabControl.SelectedTab.Text) Then
            tabHasChanged(1) = True
        End If

        y = 0
        Form1.TabControl.SelectedIndex = y
        If Mod1UT30.Checked = True Then
            Form1.TabControl.SelectedTab.Text = Mod1UT30.Text
        ElseIf Mod1UT50.Checked = True Then
            Form1.TabControl.SelectedTab.Text = Mod1UT50.Text
        ElseIf Mod1UT144.Checked And eTypeRadioCheckBox.Checked Then
            Form1.TabControl.SelectedTab.Text = Mod1UT144.Text + "e"
        ElseIf Mod1UT144.Checked = True Then
            Form1.TabControl.SelectedTab.Text = Mod1UT144.Text
        ElseIf Mod1UT220.Checked = True Then
            Form1.TabControl.SelectedTab.Text = Mod1UT220.Text
        ElseIf Mod1UT440.Checked And eTypeRadioCheckBox.Checked Then
            Form1.TabControl.SelectedTab.Text = Mod1UT440.Text + "e"
        ElseIf Mod1UT440.Checked = True Then
            Form1.TabControl.SelectedTab.Text = Mod1UT440.Text
        ElseIf Mod1UT1200.Checked And eTypeRadioCheckBox.Checked Then
            Form1.TabControl.SelectedTab.Text = Mod1UT1200.Text + "e"
        ElseIf Mod1UT1200.Checked = True Then
            Form1.TabControl.SelectedTab.Text = Mod1UT1200.Text
        End If
        If Mod1None.Checked = True Then
            Form1.TabControl.SelectedTab.Text = "Mod1 Not Installed"
            Form1.Panel1.Enabled = False
            Form1.Panel2.Enabled = False
            Form1.Panel3.Enabled = False
        Else
            Form1.Panel1.Enabled = True
            Form1.Panel2.Enabled = True
            Form1.Panel3.Enabled = True
        End If

        If Not radioConfig.tab1Filename.Contains(Form1.TabControl.SelectedTab.Text) Then
            tabHasChanged(0) = True
        End If

        'Dim test As String
        'Dim MhzComboBoxObj As Object
        Dim startVal As Integer
        Dim stopVal As Integer
        Dim addDoubleMinus As Boolean = False
        Dim repeaterComboBoxObj As ComboBox
        Dim tabString As String
        Dim mhzComboBoxObj As ComboBox
        Dim listViewObj As ListView
        Dim ctcssXmitRecObj As RadioButton
        Dim channelListViewObj As ListView

        For x As Integer = 0 To 2

            If x = 0 Then
                channelListViewObj = Form1.Tab1ChannelListView
                ctcssXmitRecObj = Form1.Tab1CtcssXmitRec
                listViewObj = Form1.Tab1ChannelListView
                mhzComboBoxObj = Form1.Tab1MHzComboBox
                repeaterComboBoxObj = Form1.Tab1RepeaterComboBox
                Form1.TabControl.SelectedIndex = x
                tabString = Form1.TabControl.SelectedTab.Text
            ElseIf x = 1 Then
                channelListViewObj = Form1.Tab2ChannelListView
                ctcssXmitRecObj = Form1.Tab2CtcssXmitRec
                listViewObj = Form1.Tab2ChannelListView
                mhzComboBoxObj = Form1.Tab2MHzComboBox
                repeaterComboBoxObj = Form1.Tab2RepeaterComboBox
                Form1.TabControl.SelectedIndex = x
                tabString = Form1.TabControl.SelectedTab.Text
            Else
                channelListViewObj = Form1.Tab3ChannelListView
                ctcssXmitRecObj = Form1.Tab3CtcssXmitRec
                listViewObj = Form1.Tab3ChannelListView
                mhzComboBoxObj = Form1.Tab3MHzComboBox
                repeaterComboBoxObj = Form1.Tab3RepeaterComboBox
                Form1.TabControl.SelectedIndex = x
                tabString = Form1.TabControl.SelectedTab.Text
            End If

            channelListViewObj.Items.Clear()

            repeaterComboBoxObj.Items.Clear()
            repeaterComboBoxObj.Items.Add("SIMPLEX")
            repeaterComboBoxObj.Items.Add("PLUS")
            repeaterComboBoxObj.Items.Add("MINUS")

            If ((x = 0 And ((Mod1UT440.Checked And eTypeRadioCheckBox.Checked) Or (Mod1UT1200.Checked And Not (eTypeRadioCheckBox.Checked)))) Or (x = 1 And ((Mod2UT440.Checked And eTypeRadioCheckBox.Checked) Or (Mod2UT1200.Checked And Not (eTypeRadioCheckBox.Checked)))) Or (x = 2 And ((Mod3UT440.Checked And eTypeRadioCheckBox.Checked) Or (Mod3UT1200.Checked And Not (eTypeRadioCheckBox.Checked))))) Then
                repeaterComboBoxObj.Items.Add("DBL MINUS")
            End If

            Form1.TabControl.SelectedIndex = x
            If Form1.TabControl.SelectedTab.Text = Mod1UT30.Text Or Form1.TabControl.SelectedTab.Text = Mod2UT30.Text Or Form1.TabControl.SelectedTab.Text = Mod3UT30.Text Then
                startVal = 28
                stopVal = 29
            ElseIf Form1.TabControl.SelectedTab.Text = Mod1UT50.Text Or Form1.TabControl.SelectedTab.Text = Mod2UT50.Text Or Form1.TabControl.SelectedTab.Text = Mod3UT50.Text Then
                startVal = 50
                stopVal = 53
            ElseIf Form1.TabControl.SelectedTab.Text = Mod1UT144.Text Or Form1.TabControl.SelectedTab.Text = (Mod1UT144.Text + "e") Or Form1.TabControl.SelectedTab.Text = Mod2UT144.Text Or Form1.TabControl.SelectedTab.Text = (Mod2UT144.Text + "e") Or Form1.TabControl.SelectedTab.Text = Mod3UT144.Text Or Form1.TabControl.SelectedTab.Text = (Mod3UT144.Text + "e") Then
                startVal = 118
                stopVal = 174
            ElseIf Form1.TabControl.SelectedTab.Text = Mod1UT220.Text Or Form1.TabControl.SelectedTab.Text = Mod2UT220.Text Or Form1.TabControl.SelectedTab.Text = Mod3UT220.Text Then
                startVal = 220
                stopVal = 224
            ElseIf Form1.TabControl.SelectedTab.Text = Mod1UT440.Text Or Form1.TabControl.SelectedTab.Text = (Mod1UT440.Text + "e") Or Form1.TabControl.SelectedTab.Text = Mod2UT440.Text Or Form1.TabControl.SelectedTab.Text = (Mod2UT440.Text + "e") Or Form1.TabControl.SelectedTab.Text = Mod3UT440.Text Or Form1.TabControl.SelectedTab.Text = (Mod3UT440.Text + "e") Then
                startVal = 410
                stopVal = 470
            ElseIf Form1.TabControl.SelectedTab.Text = Mod1UT1200.Text Or Form1.TabControl.SelectedTab.Text = (Mod1UT1200.Text + "e") Or Form1.TabControl.SelectedTab.Text = Mod2UT1200.Text Or Form1.TabControl.SelectedTab.Text = (Mod2UT1200.Text + "e") Or Form1.TabControl.SelectedTab.Text = Mod3UT1200.Text Or Form1.TabControl.SelectedTab.Text = (Mod3UT1200.Text + "e") Then
                startVal = 1240
                stopVal = 1299
                If wideBandCheckBox.Checked Then
                    startVal = 1100
                    stopVal = 1399
                End If
            End If

            mhzComboBoxObj.Items.Clear()
            mhzComboBoxObj.Items.Add("BLANK")
            While startVal <= stopVal
                mhzComboBoxObj.Items.Add(Convert.ToString(startVal))
                startVal += 1
            End While

            listViewObj.Text = "BLANK"
            If Tsu7CheckBox.Checked Then
                ctcssXmitRecObj.Visible = True
                ctcssXmitRecObj.Update()
            Else
                ctcssXmitRecObj.Visible = False
                ctcssXmitRecObj.Update()
            End If
        Next

        Form1.initializeForm()
        Form1.Visible = True

        initializing = False

        Dim testXml As New XmlDocument
        testXml.Load(xmlFile)
        testXml.SelectSingleNode("TM742/eType").InnerText = Convert.ToString(eTypeRadioCheckBox.Checked)
        testXml.SelectSingleNode("TM742/tsu7Installed").InnerText = Convert.ToString(Tsu7CheckBox.Checked)
        testXml.SelectSingleNode("TM742/wideBand").InnerText = Convert.ToString(wideBandCheckBox.Checked)
        testXml.SelectSingleNode("TM742/ARO").InnerText = Convert.ToString(AROcheckBox.Checked)
        If normalRadioTimingButton.Checked Then
            testXml.SelectSingleNode("TM742/timingMode").InnerText = Convert.ToString("0")
        ElseIf slowRadioTimingButton.Checked Then
            testXml.SelectSingleNode("TM742/timingMode").InnerText = Convert.ToString("1")
        Else
            testXml.SelectSingleNode("TM742/timingMode").InnerText = Convert.ToString("2")
        End If

        Form1.TabControl.SelectedIndex = 0
        If Not Form1.TabControl.SelectedTab.Text.Contains("Installed") Then
            Dim tmpStr As String = Mid(Form1.TabControl.SelectedTab.Text, 4, Form1.TabControl.SelectedTab.Text.Length)
            testXml.SelectSingleNode("TM742/tab1Mod").InnerText = "Mod1UT" + tmpStr
        Else
            testXml.SelectSingleNode("TM742/tab1Mod").InnerText = "NULL"
        End If
        Form1.TabControl.SelectedIndex = 1
        If Not Form1.TabControl.SelectedTab.Text.StartsWith("Installed") Then
            Dim tmpStr As String = Mid(Form1.TabControl.SelectedTab.Text, 4, Form1.TabControl.SelectedTab.Text.Length)
            testXml.SelectSingleNode("TM742/tab2Mod").InnerText = "Mod2UT" + tmpStr
        Else
            testXml.SelectSingleNode("TM742/tab2Mod").InnerText = "NULL"
        End If
        Form1.TabControl.SelectedIndex = 2
        If Not Form1.TabControl.SelectedTab.Text.StartsWith("Installed") Then
            Dim tmpStr As String = Mid(Form1.TabControl.SelectedTab.Text, 4, Form1.TabControl.SelectedTab.Text.Length)
            testXml.SelectSingleNode("TM742/tab3Mod").InnerText = "Mod3UT" + tmpStr
        Else
            testXml.SelectSingleNode("TM742/tab3Mod").InnerText = "NULL"
        End If

        'If Not Form1.tab1ChannelFileName.Text.Equals("") Then
        '    testXml.SelectSingleNode("TM742/tab1Filename").InnerText = Form1.tab1ChannelFileName.Text
        'Else
        '    testXml.SelectSingleNode("TM742/tab1Filename").InnerText = "NULL"
        'End If
        'If Not Form1.tab2ChannelFileName.Text.Equals("") Then
        '    testXml.SelectSingleNode("TM742/tab2Filename").InnerText = Form1.tab2ChannelFileName.Text
        'Else
        '    testXml.SelectSingleNode("TM742/tab2Filename").InnerText = "NULL"
        'End If
        'If Not Form1.tab3ChannelFileName.Text.Equals("") Then
        '    testXml.SelectSingleNode("TM742/tab3Filename").InnerText = Form1.tab3ChannelFileName.Text
        'Else
        '    testXml.SelectSingleNode("TM742/tab3Filename").InnerText = "NULL"
        'End If
        testXml.Save(xmlFile)

        Form1.TabControl.SelectedIndex = 0
        Me.Enabled = False

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing

        Static test As Boolean = False
        If (test = False) Then
            test = True
            Form1.Close()
            Me.Close()
        End If

    End Sub

    Private Sub eTypeRadioCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eTypeRadioCheckBox.CheckedChanged
        Dim ut220Checked As Boolean = False
        If eTypeRadioCheckBox.Checked Then
            If Mod1UT220.Checked Then
                Mod1UT220.Checked = False
                Mod1None.Checked = True
                ut220Checked = True
            End If
            If Mod2UT220.Checked Then
                Mod2UT220.Checked = False
                Mod2None.Checked = True
                ut220Checked = True
            End If
            If Mod3UT220.Checked Then
                Mod3UT220.Checked = False
                Mod3None.Checked = True
                ut220Checked = True
            End If

            Mod1UT220.Enabled = False
            Mod2UT220.Enabled = False
            Mod3UT220.Enabled = False

            If ut220Checked = True Then
                Dim msgResult As MsgBoxResult = MsgBox("UT220 module is not a valid selection with an 'E' type radio.")
            End If
        Else
            Mod1UT220.Enabled = True
            Mod2UT220.Enabled = True
            Mod3UT220.Enabled = True
        End If
    End Sub
End Class