﻿// ------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// Runtime Version:4.0.30319.18034
// 
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Diagnostics;

namespace Radio.My
{

    // NOTE: This file is auto-generated; do not modify it directly.  To make changes,
    // or if you encounter build errors in this file, go to the Project Designer
    // (go to Project Properties or double-click the My Project node in
    // Solution Explorer), and make changes on the Application tab.
    // 
    internal partial class MyApplication
    {

        [DebuggerStepThrough()]
        public MyApplication() : base(Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
        {
            IsSingleInstance = false;
            EnableVisualStyles = true;
            SaveMySettingsOnExit = true;
            ShutdownStyle = Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses;
        }

        [DebuggerStepThrough()]
        protected override void OnCreateMainForm()
        {
            MainForm = new Radio.MainForm();
        }
    }
}