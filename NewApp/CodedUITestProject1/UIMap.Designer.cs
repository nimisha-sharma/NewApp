﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod1 - Use 'RecordedMethod1Params' to pass parameters into this method.
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WinControl uIMozillaFirefoxMenuButton = this.UIRunningapplicationsWindow.UIRunningapplicationsToolBar.UIMozillaFirefoxMenuButton;
            WinMenuItem uIMozillaFirefoxMenuItem = this.UIJumpListWindow.UIItemWindow.UIJumpListClient.UIMozillaFirefoxMenuItem;
            WinEdit uIItemEdit = this.UIMozillaFirefoxStartPWindow.UIMozillaFirefoxStartPDocument.UIItemEdit;
            WinEdit uISearchEdit = this.UIMozillaFirefoxStartPWindow.UISearchButton.UISearchEdit;
            WinEdit uIW3SchoolsOnlineWebTuEdit = this.UIMozillaFirefoxStartPWindow.UIW3SchoolsOnlineWebTuHyperlink.UIW3SchoolsOnlineWebTuEdit;
            WinControl uIItemPropertyPage = this.UIMozillaFirefoxStartPWindow.UIW3SchoolsOnlineWebTuApplication.UIItemPropertyPage;
            #endregion

            // Right-Click 'Mozilla Firefox' MenuButton
            Mouse.Click(uIMozillaFirefoxMenuButton, MouseButtons.Right, ModifierKeys.None, new Point(35, 21));

            // Click 'Mozilla Firefox' menu item
            Mouse.Click(uIMozillaFirefoxMenuItem, new Point(143, 9));

            // Type 'w3schools.com' in text box
            uIItemEdit.Text = this.RecordedMethod1Params.UIItemEditText;

            // Click 'Search' text box
            Mouse.Click(uISearchEdit, new Point(31, 12));

            // Click 'W3Schools Online Web Tutorials' text box
            Mouse.Click(uIW3SchoolsOnlineWebTuEdit, new Point(215, 12));

            // Click PropertyPage
            Mouse.Click(uIItemPropertyPage, new Point(1351, 15));
        }
        
        #region Properties
        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }
        
        public UIRunningapplicationsWindow UIRunningapplicationsWindow
        {
            get
            {
                if ((this.mUIRunningapplicationsWindow == null))
                {
                    this.mUIRunningapplicationsWindow = new UIRunningapplicationsWindow();
                }
                return this.mUIRunningapplicationsWindow;
            }
        }
        
        public UIJumpListWindow UIJumpListWindow
        {
            get
            {
                if ((this.mUIJumpListWindow == null))
                {
                    this.mUIJumpListWindow = new UIJumpListWindow();
                }
                return this.mUIJumpListWindow;
            }
        }
        
        public UIMozillaFirefoxStartPWindow UIMozillaFirefoxStartPWindow
        {
            get
            {
                if ((this.mUIMozillaFirefoxStartPWindow == null))
                {
                    this.mUIMozillaFirefoxStartPWindow = new UIMozillaFirefoxStartPWindow();
                }
                return this.mUIMozillaFirefoxStartPWindow;
            }
        }
        
        public UINewApp2Window UINewApp2Window
        {
            get
            {
                if ((this.mUINewApp2Window == null))
                {
                    this.mUINewApp2Window = new UINewApp2Window();
                }
                return this.mUINewApp2Window;
            }
        }
        #endregion
        
        #region Fields
        private RecordedMethod1Params mRecordedMethod1Params;
        
        private UIRunningapplicationsWindow mUIRunningapplicationsWindow;
        
        private UIJumpListWindow mUIJumpListWindow;
        
        private UIMozillaFirefoxStartPWindow mUIMozillaFirefoxStartPWindow;
        
        private UINewApp2Window mUINewApp2Window;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class RecordedMethod1Params
    {
        
        #region Fields
        /// <summary>
        /// Type 'w3schools.com' in text box
        /// </summary>
        public string UIItemEditText = "w3schools.com";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIRunningapplicationsWindow : WinWindow
    {
        
        public UIRunningapplicationsWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Running applications";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "MSTaskSwWClass";
            this.WindowTitles.Add("Running applications");
            #endregion
        }
        
        #region Properties
        public UIRunningapplicationsToolBar UIRunningapplicationsToolBar
        {
            get
            {
                if ((this.mUIRunningapplicationsToolBar == null))
                {
                    this.mUIRunningapplicationsToolBar = new UIRunningapplicationsToolBar(this);
                }
                return this.mUIRunningapplicationsToolBar;
            }
        }
        #endregion
        
        #region Fields
        private UIRunningapplicationsToolBar mUIRunningapplicationsToolBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIRunningapplicationsToolBar : WinToolBar
    {
        
        public UIRunningapplicationsToolBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinToolBar.PropertyNames.Name] = "Running applications";
            this.WindowTitles.Add("Running applications");
            #endregion
        }
        
        #region Properties
        public WinControl UIMozillaFirefoxMenuButton
        {
            get
            {
                if ((this.mUIMozillaFirefoxMenuButton == null))
                {
                    this.mUIMozillaFirefoxMenuButton = new WinControl(this);
                    #region Search Criteria
                    this.mUIMozillaFirefoxMenuButton.SearchProperties[UITestControl.PropertyNames.Name] = "Mozilla Firefox";
                    this.mUIMozillaFirefoxMenuButton.SearchProperties[UITestControl.PropertyNames.ControlType] = "MenuButton";
                    this.mUIMozillaFirefoxMenuButton.WindowTitles.Add("Running applications");
                    #endregion
                }
                return this.mUIMozillaFirefoxMenuButton;
            }
        }
        #endregion
        
        #region Fields
        private WinControl mUIMozillaFirefoxMenuButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIJumpListWindow : WinWindow
    {
        
        public UIJumpListWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Jump List";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "DV2ControlHost";
            this.WindowTitles.Add("Jump List");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "5";
            this.WindowTitles.Add("Jump List");
            #endregion
        }
        
        #region Properties
        public UIJumpListClient UIJumpListClient
        {
            get
            {
                if ((this.mUIJumpListClient == null))
                {
                    this.mUIJumpListClient = new UIJumpListClient(this);
                }
                return this.mUIJumpListClient;
            }
        }
        #endregion
        
        #region Fields
        private UIJumpListClient mUIJumpListClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIJumpListClient : WinClient
    {
        
        public UIJumpListClient(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("Jump List");
            #endregion
        }
        
        #region Properties
        public WinMenuItem UIMozillaFirefoxMenuItem
        {
            get
            {
                if ((this.mUIMozillaFirefoxMenuItem == null))
                {
                    this.mUIMozillaFirefoxMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUIMozillaFirefoxMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Mozilla Firefox";
                    this.mUIMozillaFirefoxMenuItem.WindowTitles.Add("Jump List");
                    #endregion
                }
                return this.mUIMozillaFirefoxMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mUIMozillaFirefoxMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIMozillaFirefoxStartPWindow : WinWindow
    {
        
        public UIMozillaFirefoxStartPWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Mozilla Firefox Start Page - Mozilla Firefox";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "MozillaWindowClass";
            this.WindowTitles.Add("Mozilla Firefox Start Page - Mozilla Firefox");
            this.WindowTitles.Add("w3schools.com - Google Search - Mozilla Firefox");
            this.WindowTitles.Add("W3Schools Online Web Tutorials - Mozilla Firefox");
            #endregion
        }
        
        #region Properties
        public UIMozillaFirefoxStartPDocument UIMozillaFirefoxStartPDocument
        {
            get
            {
                if ((this.mUIMozillaFirefoxStartPDocument == null))
                {
                    this.mUIMozillaFirefoxStartPDocument = new UIMozillaFirefoxStartPDocument(this);
                }
                return this.mUIMozillaFirefoxStartPDocument;
            }
        }
        
        public UISearchButton UISearchButton
        {
            get
            {
                if ((this.mUISearchButton == null))
                {
                    this.mUISearchButton = new UISearchButton(this);
                }
                return this.mUISearchButton;
            }
        }
        
        public UIW3SchoolsOnlineWebTuHyperlink UIW3SchoolsOnlineWebTuHyperlink
        {
            get
            {
                if ((this.mUIW3SchoolsOnlineWebTuHyperlink == null))
                {
                    this.mUIW3SchoolsOnlineWebTuHyperlink = new UIW3SchoolsOnlineWebTuHyperlink(this);
                }
                return this.mUIW3SchoolsOnlineWebTuHyperlink;
            }
        }
        
        public UIW3SchoolsOnlineWebTuApplication UIW3SchoolsOnlineWebTuApplication
        {
            get
            {
                if ((this.mUIW3SchoolsOnlineWebTuApplication == null))
                {
                    this.mUIW3SchoolsOnlineWebTuApplication = new UIW3SchoolsOnlineWebTuApplication(this);
                }
                return this.mUIW3SchoolsOnlineWebTuApplication;
            }
        }
        #endregion
        
        #region Fields
        private UIMozillaFirefoxStartPDocument mUIMozillaFirefoxStartPDocument;
        
        private UISearchButton mUISearchButton;
        
        private UIW3SchoolsOnlineWebTuHyperlink mUIW3SchoolsOnlineWebTuHyperlink;
        
        private UIW3SchoolsOnlineWebTuApplication mUIW3SchoolsOnlineWebTuApplication;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIMozillaFirefoxStartPDocument : WinControl
    {
        
        public UIMozillaFirefoxStartPDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Mozilla Firefox Start Page";
            this.SearchProperties[UITestControl.PropertyNames.ControlType] = "Document";
            this.WindowTitles.Add("Mozilla Firefox Start Page - Mozilla Firefox");
            #endregion
        }
        
        #region Properties
        public WinEdit UIItemEdit
        {
            get
            {
                if ((this.mUIItemEdit == null))
                {
                    this.mUIItemEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIItemEdit.WindowTitles.Add("Mozilla Firefox Start Page - Mozilla Firefox");
                    #endregion
                }
                return this.mUIItemEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIItemEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UISearchButton : WinButton
    {
        
        public UISearchButton(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinButton.PropertyNames.Name] = "Search";
            this.WindowTitles.Add("Mozilla Firefox Start Page - Mozilla Firefox");
            #endregion
        }
        
        #region Properties
        public WinEdit UISearchEdit
        {
            get
            {
                if ((this.mUISearchEdit == null))
                {
                    this.mUISearchEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUISearchEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Search";
                    this.mUISearchEdit.WindowTitles.Add("Mozilla Firefox Start Page - Mozilla Firefox");
                    #endregion
                }
                return this.mUISearchEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUISearchEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIW3SchoolsOnlineWebTuHyperlink : WinHyperlink
    {
        
        public UIW3SchoolsOnlineWebTuHyperlink(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinHyperlink.PropertyNames.Name] = "W3Schools Online Web Tutorials";
            this.WindowTitles.Add("w3schools.com - Google Search - Mozilla Firefox");
            #endregion
        }
        
        #region Properties
        public WinEdit UIW3SchoolsOnlineWebTuEdit
        {
            get
            {
                if ((this.mUIW3SchoolsOnlineWebTuEdit == null))
                {
                    this.mUIW3SchoolsOnlineWebTuEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIW3SchoolsOnlineWebTuEdit.SearchProperties[WinEdit.PropertyNames.Name] = "W3Schools Online Web Tutorials";
                    this.mUIW3SchoolsOnlineWebTuEdit.WindowTitles.Add("w3schools.com - Google Search - Mozilla Firefox");
                    #endregion
                }
                return this.mUIW3SchoolsOnlineWebTuEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIW3SchoolsOnlineWebTuEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIW3SchoolsOnlineWebTuApplication : WinControl
    {
        
        public UIW3SchoolsOnlineWebTuApplication(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "W3Schools Online Web Tutorials - Mozilla Firefox";
            this.SearchProperties[UITestControl.PropertyNames.ControlType] = "Application";
            this.WindowTitles.Add("W3Schools Online Web Tutorials - Mozilla Firefox");
            #endregion
        }
        
        #region Properties
        public WinControl UIItemPropertyPage
        {
            get
            {
                if ((this.mUIItemPropertyPage == null))
                {
                    this.mUIItemPropertyPage = new WinControl(this);
                    #region Search Criteria
                    this.mUIItemPropertyPage.SearchProperties[UITestControl.PropertyNames.ControlType] = "PropertyPage";
                    this.mUIItemPropertyPage.WindowTitles.Add("W3Schools Online Web Tutorials - Mozilla Firefox");
                    #endregion
                }
                return this.mUIItemPropertyPage;
            }
        }
        #endregion
        
        #region Fields
        private WinControl mUIItemPropertyPage;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UINewApp2Window : WinWindow
    {
        
        public UINewApp2Window()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "NewApp2";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "CabinetWClass";
            this.WindowTitles.Add("NewApp2");
            #endregion
        }
        
        #region Properties
        public UIShellViewWindow UIShellViewWindow
        {
            get
            {
                if ((this.mUIShellViewWindow == null))
                {
                    this.mUIShellViewWindow = new UIShellViewWindow(this);
                }
                return this.mUIShellViewWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIShellViewWindow mUIShellViewWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIShellViewWindow : WinWindow
    {
        
        public UIShellViewWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "ShellView";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "SHELLDLL_DefView";
            this.WindowTitles.Add("NewApp2");
            #endregion
        }
        
        #region Properties
        public UIShellViewClient UIShellViewClient
        {
            get
            {
                if ((this.mUIShellViewClient == null))
                {
                    this.mUIShellViewClient = new UIShellViewClient(this);
                }
                return this.mUIShellViewClient;
            }
        }
        #endregion
        
        #region Fields
        private UIShellViewClient mUIShellViewClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIShellViewClient : WinClient
    {
        
        public UIShellViewClient(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinControl.PropertyNames.Name] = "Shell Folder View";
            this.WindowTitles.Add("NewApp2");
            #endregion
        }
        
        #region Properties
        public WinList UIItemsViewList
        {
            get
            {
                if ((this.mUIItemsViewList == null))
                {
                    this.mUIItemsViewList = new WinList(this);
                    #region Search Criteria
                    this.mUIItemsViewList.SearchProperties[WinList.PropertyNames.Name] = "Items View";
                    this.mUIItemsViewList.WindowTitles.Add("NewApp2");
                    #endregion
                }
                return this.mUIItemsViewList;
            }
        }
        #endregion
        
        #region Fields
        private WinList mUIItemsViewList;
        #endregion
    }
}
