using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Radio
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable IDE1006

    public class RadioConfig
    {
        private int usbPort;
        private bool eType;
        private bool tsu7Installed;
        private bool wideBand;
        private bool aRO;
        private int timingMode;
        private bool allowCustomOffset;

        private string tab1Mod;
        private string tab1Filename;
        private string tab1StepSize;

        private string tab2Mod;
        private string tab2StepSize;
        private string tab2Filename;

        private string tab3Mod;
        private string tab3StepSize;
        private string tab3Filename;

        public RadioConfig(string fileName)
        {
            xmlFileName = fileName;
        }

        public string xmlFileName { get; set; }

        public int UsbPort { get => usbPort; set => usbPort = value; }
        public bool EType { get => eType; set => eType = value; }
        public bool Tsu7Installed { get => tsu7Installed; set => tsu7Installed = value; }
        public bool WideBand { get => wideBand; set => wideBand = value; }
        public bool ARO { get => aRO; set => aRO = value; }
        public int TimingMode { get => timingMode; set => timingMode = value; }
        public bool AllowCustomOffset { get => allowCustomOffset; set => allowCustomOffset = value; }
        public string Tab1Mod { get => tab1Mod; set => tab1Mod = value; }
        public string Tab1Filename { get => tab1Filename; set => tab1Filename = value; }
        public string Tab1StepSize { get => tab1StepSize; set => tab1StepSize = value; }
        public string Tab2Mod { get => tab2Mod; set => tab2Mod = value; }
        public string Tab2StepSize { get => tab2StepSize; set => tab2StepSize = value; }
        public string Tab2Filename { get => tab2Filename; set => tab2Filename = value; }
        public string Tab3Mod { get => tab3Mod; set => tab3Mod = value; }
        public string Tab3StepSize { get => tab3StepSize; set => tab3StepSize = value; }
        public string Tab3Filename { get => tab3Filename; set => tab3Filename = value; }


        public string getUsbPortName()
        {
            return String.Format("COM{0}", usbPort);
        }

        public int getUsbPortNumber()
        {
            return usbPort;
        }

        public string getTab1StepSize()
        {
            return tab1StepSize;
        }

        public string getTab2StepSize()
        {
            return tab2StepSize;
        }

        public string getTab3StepSize()
        {
            return tab3StepSize;
        }

        public void UpdateUSBComPort(int value)
        {
            updateSingleEntity("TM742/usbPort", Convert.ToString(value));
            usbPort = value;
        }

        public void UpdateModule1Type(string value)
        {
            updateSingleEntity("TM742/Module1/Type", value);
            tab1Mod = value;
        }

        public void UpdateModule2Type(string value)
        {
            updateSingleEntity("TM742/Module2/Type", value);
            tab2Mod = value;
        }

        public void UpdateModule3Type(string value)
        {
            updateSingleEntity("TM742/Module3/Type", value);
            tab3Mod = value;
        }

        public void UpdateModuleStepSize(int moduleNumber, string value)
        {
            // tabs are numbered by their index, so 0, 1, and 2.  The modules are numbered using sequence, so 1, 2, and 3.
            updateSingleEntity(String.Format("TM742/Module{0}/StepSize", moduleNumber + 1), value);
            tab1StepSize = value;
        }

        public void UpdateModule1StepSize(string value)
        {
            updateSingleEntity("TM742/Module1/StepSize", value);
            tab1StepSize = value;
        }

        public void UpdateModule2StepSize(string value)
        {
            updateSingleEntity("TM742/Module2/StepSize", value);
            tab2StepSize = value;
        }

        public void UpdateModule3StepSize(string value)
        {
            updateSingleEntity("TM742/Module3/StepSize", value);
            tab3StepSize = value;
        }

        public void updateSingleEntity(string nodeName, string value)
        {
            var testXml = new XmlDocument();
            testXml.Load(xmlFileName);
            testXml.SelectSingleNode(nodeName).InnerText = value;
            testXml.Save(xmlFileName);
        }

        public void saveConfigFile()
        {
            var testXml = new XmlDocument();
            testXml.Load(xmlFileName);
            testXml.SelectSingleNode("TM742/eType").InnerText = Convert.ToString(EType);
            testXml.SelectSingleNode("TM742/tsu7Installed").InnerText = Convert.ToString(Tsu7Installed);
            testXml.SelectSingleNode("TM742/wideBand").InnerText = Convert.ToString(WideBand);
            testXml.SelectSingleNode("TM742/ARO").InnerText = Convert.ToString(ARO);
            testXml.SelectSingleNode("TM742/allowCustomOffset").InnerText = Convert.ToString(AllowCustomOffset);

            testXml.SelectSingleNode("TM742/timingMode").InnerText = Convert.ToString(TimingMode);

            testXml.SelectSingleNode("TM742/Module1/Type").InnerText = Tab1Mod;
            testXml.SelectSingleNode("TM742/Module1/StepSize").InnerText = Tab1StepSize;
            testXml.SelectSingleNode("TM742/Module1/Filename").InnerText = Tab1Filename;

            testXml.SelectSingleNode("TM742/Module2/Type").InnerText = Tab2Mod;
            testXml.SelectSingleNode("TM742/Module2/StepSize").InnerText = Tab2StepSize;
            testXml.SelectSingleNode("TM742/Module2/Filename").InnerText = Tab2Filename;

            testXml.SelectSingleNode("TM742/Module3/Type").InnerText = Tab3Mod;
            testXml.SelectSingleNode("TM742/Module3/StepSize").InnerText = Tab3StepSize;
            testXml.SelectSingleNode("TM742/Module3/Filename").InnerText = Tab3Filename;

            testXml.Save(xmlFileName);
        }

        public void saveConfigFileNew()
        {
            var xws = new XmlWriterSettings
            {
                OmitXmlDeclaration = true,
                Indent = true
            };

            var xw = XmlWriter.Create(xmlFileName, xws);

            using (xw)
            {
                xw.WriteStartElement("TM742");
                xw.WriteElementString("eType", Convert.ToString(EType));
                xw.WriteElementString("tsu7Installed", Convert.ToString(Tsu7Installed));
                xw.WriteElementString("wideBand", Convert.ToString(WideBand));
                xw.WriteElementString("ARO", Convert.ToString(ARO));
                xw.WriteElementString("allowCustomOffset", Convert.ToString(AllowCustomOffset));
                xw.WriteElementString("timingMode", Convert.ToString(TimingMode));

                xw.WriteStartElement("Module1");
                xw.WriteElementString("Type", Tab1Mod);
                xw.WriteElementString("StepSize", Tab1StepSize);
                xw.WriteElementString("Filename", Tab1Filename);
                xw.WriteEndElement();

                xw.WriteStartElement("Module2");
                xw.WriteElementString("Type", Tab2Mod);
                xw.WriteElementString("StepSize", Tab2StepSize);
                xw.WriteElementString("Filename", Tab2Filename);
                xw.WriteEndElement();

                xw.WriteStartElement("Module3");
                xw.WriteElementString("Type", Tab3Mod);
                xw.WriteElementString("StepSize", Tab3StepSize);
                xw.WriteElementString("Filename", Tab3Filename);
                xw.WriteEndElement();

                xw.WriteEndElement();   // end 'TM742'

                xw.Close();
            }
        }


        public void loadConfigFile()
        {
            var testXml = new XmlDocument();
            testXml.Load(xmlFileName);
            UsbPort = Convert.ToInt32(testXml.SelectSingleNode("TM742/usbPort").InnerText);
            EType = Convert.ToBoolean(testXml.SelectSingleNode("TM742/eType").InnerText);
            Tsu7Installed = Convert.ToBoolean(testXml.SelectSingleNode("TM742/tsu7Installed").InnerText);
            WideBand = Convert.ToBoolean(testXml.SelectSingleNode("TM742/wideBand").InnerText);
            ARO = Convert.ToBoolean(testXml.SelectSingleNode("TM742/ARO").InnerText);
            var allowCustomOffset = testXml.SelectSingleNode("TM742/allowCustomOffset");

            AllowCustomOffset = (allowCustomOffset != null) && Convert.ToBoolean(allowCustomOffset.InnerText);

            Tab1Mod = testXml.SelectSingleNode("TM742/Module1/Type").InnerText;
            Tab1StepSize = testXml.SelectSingleNode("TM742/Module1/StepSize").InnerText;
            Tab1Filename = testXml.SelectSingleNode("TM742/Module1/Filename").InnerText;

            Tab2Mod = testXml.SelectSingleNode("TM742/Module2/Type").InnerText;
            Tab2StepSize = testXml.SelectSingleNode("TM742/Module2/StepSize").InnerText;
            Tab2Filename = testXml.SelectSingleNode("TM742/Module2/Filename").InnerText;

            Tab3Mod = testXml.SelectSingleNode("TM742/Module3/Type").InnerText;
            Tab3StepSize = testXml.SelectSingleNode("TM742/Module3/StepSize").InnerText;
            Tab3Filename = testXml.SelectSingleNode("TM742/Module3/Filename").InnerText;
        }
    }
}
