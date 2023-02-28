using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Radio
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable IDE1006
    public class ChannelListManager {
        private readonly ListView ChannelListView;
        private readonly RadioConfig RadioConfig;
        private readonly UTModule UTModule;

        public ChannelListManager (UTModule utModule, ListView channelListView, RadioConfig radioConfig)
        {
            UTModule = utModule;
            ChannelListView = channelListView;
            RadioConfig = radioConfig;
        }
        
        public void setBlankRow(int rowIndex, string text)
        {
            ChannelListView.Items[rowIndex].Text = (rowIndex + 1).ToString();
            ChannelListView.Items[rowIndex].SubItems.Clear();
            ChannelListView.Items[rowIndex].SubItems[0].Text = (rowIndex + 1).ToString();
            ChannelListView.Items[rowIndex].SubItems.Add("BLANK");
            ChannelListView.Items[rowIndex].SubItems.Add("");
            ChannelListView.Items[rowIndex].SubItems.Add("");
            ChannelListView.Items[rowIndex].SubItems.Add("");
            ChannelListView.Items[rowIndex].SubItems.Add("");
            ChannelListView.Items[rowIndex].SubItems.Add("");
            ChannelListView.Text = text;
        }

        public void clearList()
        {
            ChannelListView.Items.Clear();
            ChannelListView.Items.Add(0.ToString());

            setBlankRow(0, "BLANK");

            ChannelListView.Items[0].Selected = true;
            ChannelListView.HideSelection = false;
        }

        /*        private void SaveChannelList(string fileName)
                {
                    ListView channelListView = Tab1ChannelListView;
                    var myWriter = My.MyProject.Computer.FileSystem.OpenTextFileWriter(fileName, false);

                    int index;
                    var loopTo = channelListView.Items.Count - 1;
                    for (index = 0; index < loopTo; index++)
                    {
                        // initialize a string list, and give it its first entry on this line
                        List<string> newLine = new() { channelListView.Items[index].SubItems[0].Text };

                        newLine.Add(channelListView.Items[index].SubItems[1].Text);
                        newLine.Add(channelListView.Items[index].SubItems[2].Text);
                        newLine.Add(channelListView.Items[index].SubItems[3].Text);
                        newLine.Add(channelListView.Items[index].SubItems[4].Text);
                        newLine.Add(channelListView.Items[index].SubItems[5].Text);

                        // all values on the line are emitted, with a comma as a separator
                        string line = string.Join(",", newLine.ToArray());
                        myWriter.WriteLine(line);
                    }

                    myWriter.Close();
                }
        */

        public void SaveChannelListXml(string fileName)
        {
            var xws = new XmlWriterSettings
            {
                OmitXmlDeclaration = true,
                Indent = true
            };

            using var xw = XmlWriter.Create(fileName, xws);
            xw.WriteStartElement("Root");
            xw.WriteStartElement("Channels");

            for (int index = 0; index < ChannelListView.Items.Count - 1; index++)
            {
                xw.WriteStartElement("Channel");
                xw.WriteElementString("ChannelNumber", ChannelListView.Items[index].SubItems[0].Text);
                xw.WriteElementString("Frequency", ChannelListView.Items[index].SubItems[1].Text);
                xw.WriteElementString("Repeater", ChannelListView.Items[index].SubItems[2].Text);
                xw.WriteElementString("Tone", ChannelListView.Items[index].SubItems[3].Text);
                xw.WriteElementString("CTCSS", ChannelListView.Items[index].SubItems[4].Text);
                xw.WriteElementString("CustomOffset", ChannelListView.Items[index].SubItems[5].Text);
                xw.WriteElementString("Notes", ChannelListView.Items[index].SubItems[6].Text);
                xw.WriteEndElement();
            }

            xw.WriteEndElement();   // end 'Channels'
            xw.WriteEndElement();   // end 'Root'

            xw.Close();
        }


        public bool DeleteRow()
        {
            int numOfChannels = ChannelListView.Items.Count;

            try
            {
                int channelIndex = Convert.ToInt32(ChannelListView.SelectedItems[0].Text);

                if (channelIndex > 1 && channelIndex < numOfChannels)
                {
                    ChannelListView.Items.RemoveAt(channelIndex - 1);

                    for (int x = 0, loopTo = numOfChannels - 2; x <= loopTo; x++)
                        ChannelListView.Items[x].SubItems[0].Text = (x + 1).ToString();

                    ChannelListView.Items[channelIndex - 1].Selected = true;
                    ChannelListView.Select();

                    return true;
                }
            }
            catch
            {
            }
            return false;
        }

        public bool InsertBlankRow()
        {
            int numOfChannels = ChannelListView.Items.Count;

            try
            {
                int channelIndex = Convert.ToInt32(ChannelListView.SelectedItems[0].Text);

                if (channelIndex < numOfChannels)
                {
                    ChannelListView.Items.Insert(channelIndex, "");
                    setBlankRow(channelIndex, channelIndex.ToString());

                    for (int x = 0, loopTo = numOfChannels; x <= loopTo; x++)
                        ChannelListView.Items[x].SubItems[0].Text = (x + 1).ToString();

                    ChannelListView.Items[channelIndex].Selected = true;
                    ChannelListView.Select();

                    if (ChannelListView.Items.Count > 101)
                    {
                        Interaction.MsgBox("The number of channels in the list has exceeded 100.  Unexpected results may occur if the radio does not support this feature", MsgBoxStyle.Information, "Channel count warning message");
                    }

                    return true;
                }
            }
            catch
            {
            }
            return false;
        }

        public void LoadChannelList(string fileName)
        {
            var myParser = My.MyProject.Computer.FileSystem.OpenTextFieldParser(fileName);
            myParser.SetDelimiters(",");

            int indexLcl = 0;

            ChannelListView.Items.Clear();

            while (!myParser.EndOfData)
            {
                var testAry = myParser.ReadFields();
                ChannelListView.Items.Add(indexLcl.ToString());
                ChannelListView.Items[indexLcl].Text = (indexLcl + 1).ToString();
                if (testAry[1] == "BLANK")
                {
                    setBlankRow(indexLcl, indexLcl.ToString());
                }
                else
                {
                    // InvariantCulture uses a period as a decimal separator.  CurrentCulture MAY use a comma or other symbol.
                    decimal testVal = Convert.ToDecimal(testAry[1], System.Globalization.CultureInfo.InvariantCulture);
                    var startVal = Convert.ToInt32(UTModule.txMinFrequencyMHz);
                    var stopVal = Convert.ToInt32(Math.Truncate(UTModule.txMaxFrequencyMHz));
                    var testMHz = Convert.ToInt32(Math.Truncate(testVal));

                    if ((startVal <= testMHz) && (testMHz <= stopVal)
                        && ((Math.Round(testVal * 10000m, 0) % 12.5m == 0m) || (Math.Round(testVal * 1000m, 0) % 5m == 0m)))
                    {
                        ChannelListView.Items[indexLcl].SubItems.Add(testAry[1]);   //1
                    }
                    else
                    {
                        Interaction.MsgBox("Channel frequency in file is not valid for this module selection !", MsgBoxStyle.Critical, "Programming setup message");
                        clearList();
                        return;
                    }

                    if (ChannelListForm.repeaterModes.Contains(testAry[2]) || ((testAry[2] == "CUSTOM") && RadioConfig.AllowCustomOffset))
                    {
                        // it's a valid word.
                        if ((testAry[2] != "DBL MINUS") || (UTModule.offsetMHzOptions.Length > 2))
                            ChannelListView.Items[indexLcl].SubItems.Add(testAry[2]);   //2
                    }
                    else
                    {
                        Interaction.MsgBox("Repeater value in file is not valid for this module selection !", MsgBoxStyle.Critical, "Programming setup message");
                        clearList();
                        return;
                    }

                    if ((testAry[3] == "OFF")
                        || ChannelListForm.CTCSSToneFrequencyList.Contains(Convert.ToDecimal(testAry[3], System.Globalization.CultureInfo.InvariantCulture)))
                    {
                        ChannelListView.Items[indexLcl].SubItems.Add(testAry[3]);   //3
                    }
                    else
                    {
                        Interaction.MsgBox("Tone value in file is not valid for this module selection !", MsgBoxStyle.Critical, "Programming setup message");
                        clearList();
                        return;
                    }

                    if (!(RadioConfig.Tsu7Installed == false && testAry[4] == "Xmit/Rec"))
                    {
                        ChannelListView.Items[indexLcl].SubItems.Add(testAry[4]);   //4
                    }
                    else
                    {
                        Interaction.MsgBox("CTCSS value in file is not valid for this module selection - defaulting to Xmit only  !",
                            MsgBoxStyle.Critical, "Programming setup message");
                        ChannelListView.Items[indexLcl].SubItems.Add("Xmit");   //4
                    }

                    // add empty CustomOffset column
                    ChannelListView.Items[indexLcl].SubItems.Add("");

                    // if notes are present...
                    if (testAry.Length == 6)
                    {
                        ChannelListView.Items[indexLcl].SubItems.Add(testAry[5]);
                    }
                    else
                    {
                        ChannelListView.Items[indexLcl].SubItems.Add("");
                    }
                }

                ChannelListView.Items[indexLcl].EnsureVisible();
                indexLcl += 1;
            }

            myParser.Close();

            ChannelListView.Items.Add(indexLcl.ToString());
            setBlankRow(indexLcl, indexLcl.ToString());
            ChannelListView.Items[indexLcl].Selected = true;
        }

        public void LoadChannelListXml(string fileName)
        {
            var testXml = new XmlDocument();
            testXml.Load(fileName);

            XmlNode channels = testXml.SelectSingleNode("Root/Channels");

            int indexLcl = 0;

            ChannelListView.Items.Clear();

            var channelList = channels.ChildNodes;
            foreach (XmlNode channel in channelList)
            {
                var channelIndex = channel.SelectSingleNode("ChannelNumber").InnerText;
                var frequency = channel.SelectSingleNode("Frequency").InnerText;
                var repeater = channel.SelectSingleNode("Repeater").InnerText;
                var tone = channel.SelectSingleNode("Tone").InnerText;
                var ctcss = channel.SelectSingleNode("CTCSS").InnerText;
                var customOffset = channel.SelectSingleNode("CustomOffset");

                var noteOrNotes = channel.SelectSingleNode("Notes");
                if (noteOrNotes == null)
                {
                    noteOrNotes = channel.SelectSingleNode("Note");
                }
                var notes = "";
                if (noteOrNotes != null)
                {
                    notes = noteOrNotes.InnerText;
                }

                ChannelListView.Items.Add(indexLcl.ToString());
                ChannelListView.Items[indexLcl].Text = (indexLcl + 1).ToString();
                if (frequency == "BLANK")
                {
                    setBlankRow(indexLcl, indexLcl.ToString());
                }
                else
                {
                    // InvariantCulture uses a period as a decimal separator.  CurrentCulture MAY use a comma or other symbol.
                    decimal testVal = Convert.ToDecimal(frequency, System.Globalization.CultureInfo.InvariantCulture);

                    // index 1
                    var startVal = Convert.ToInt32(UTModule.txMinFrequencyMHz);
                    var stopVal = Convert.ToInt32(Math.Truncate(UTModule.txMaxFrequencyMHz));
                    var testMHz = Convert.ToInt32(Math.Truncate(testVal));

                    if ((startVal <= testMHz) && (testMHz <= stopVal)
                        && ((Math.Round(testVal * 10000m, 0) % 12.5m == 0m) || (Math.Round(testVal * 1000m, 0) % 5m == 0m)))
                    {
                        ChannelListView.Items[indexLcl].SubItems.Add(frequency);
                    }
                    else
                    {
                        Interaction.MsgBox("Channel frequency in file is not valid for this module selection !", MsgBoxStyle.Critical, "Programming setup message");
                        clearList();
                        return;
                    }

                    // index 2
                    if (ChannelListForm.repeaterModes.Contains(repeater) || ((repeater == "CUSTOM") && RadioConfig.AllowCustomOffset))
                    {
                        // it's a valid word.
                        if ((repeater != "DBL MINUS") || (UTModule.offsetMHzOptions.Length > 2))
                            ChannelListView.Items[indexLcl].SubItems.Add(repeater);   //2
                    }
                    else
                    {
                        Interaction.MsgBox("Repeater value in file is not valid for this module selection !", MsgBoxStyle.Critical, "Programming setup message");
                        clearList();
                        return;
                    }

                    // index 3
                    if ((tone == "OFF")
                        || ChannelListForm.CTCSSToneFrequencyList.Contains(Convert.ToDecimal(tone, System.Globalization.CultureInfo.InvariantCulture)))
                    {
                        ChannelListView.Items[indexLcl].SubItems.Add(tone);
                    }
                    else
                    {
                        Interaction.MsgBox("Tone value in file is not valid for this module selection !", MsgBoxStyle.Critical, "Programming setup message");
                        clearList();
                        return;
                    }

                    // index 4
                    if (!((RadioConfig.Tsu7Installed == false) && (ctcss == "Xmit/Rec")))
                    {
                        ChannelListView.Items[indexLcl].SubItems.Add(ctcss);
                    }
                    else
                    {
                        Interaction.MsgBox("CTCSS value in file is not valid for this module selection - defaulting to Xmit only  !", MsgBoxStyle.Critical, "Programming setup message");
                        ChannelListView.Items[indexLcl].SubItems.Add("Xmit");
                    }

                    // index 5
                    ChannelListView.Items[indexLcl].SubItems.Add(customOffset != null ? customOffset.InnerText : "");

                    // index 6
                    ChannelListView.Items[indexLcl].SubItems.Add(notes ?? "");
                }

                ChannelListView.Items[indexLcl].EnsureVisible();
                indexLcl += 1;
            }

            ChannelListView.Items.Add(indexLcl.ToString());

            setBlankRow(indexLcl, indexLcl.ToString());
        }
    }
}
