﻿#pragma checksum "C:\Users\bgursahani\source\repos\PackageSampleHostedApp\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E914B575CA9FBD98625CE716FD5C9AA3EB9BDF7F527C696297C9296C9C735C4F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PackageSampleHostedApp
{
    partial class MainPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(global::Microsoft.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj16_Bindings :
            global::Microsoft.UI.Xaml.IDataTemplateExtension,
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::PackageSampleHostedApp.Scenario dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj16;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj16TextDisabled = false;

            public MainPage_obj16_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 37 && columnNumber == 44)
                {
                    isobj16TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 16: // MainPage.xaml line 37
                        this.obj16 = new global::System.WeakReference(global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target));
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
                        }

            public void DataContextChangedHandler(global::Microsoft.UI.Xaml.FrameworkElement sender, global::Microsoft.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Microsoft.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj16.Target as global::Microsoft.UI.Xaml.Controls.TextBlock).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_(global::WinRT.CastExtensions.As<global::PackageSampleHostedApp.Scenario>(item), 1 << phase);
            }

            public void Recycle()
            {
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = global::WinRT.CastExtensions.As<global::PackageSampleHostedApp.Scenario>(newDataRoot);
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::PackageSampleHostedApp.Scenario obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Title(obj.Title, phase);
                    }
                }
            }
            private void Update_Title(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 37
                    if (!isobj16TextDisabled)
                    {
                        if ((this.obj16.Target as global::Microsoft.UI.Xaml.Controls.TextBlock) != null)
                        {
                            XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text((this.obj16.Target as global::Microsoft.UI.Xaml.Controls.TextBlock), obj, null);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 27
                {
                    this.Splitter = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.SplitView>(target);
                }
                break;
            case 3: // MainPage.xaml line 69
                {
                    this.HeaderPanel = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target);
                }
                break;
            case 4: // MainPage.xaml line 80
                {
                    this.WindowsLogo = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Image>(target);
                }
                break;
            case 5: // MainPage.xaml line 81
                {
                    this.Header = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 6: // MainPage.xaml line 71
                {
                    global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton element6 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element6).Click += this.Button_Click;
                }
                break;
            case 7: // MainPage.xaml line 73
                {
                    this.Hamburger = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.FontIcon>(target);
                }
                break;
            case 8: // MainPage.xaml line 30
                {
                    this.SampleTitle = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 9: // MainPage.xaml line 32
                {
                    this.ScenarioControl = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ListBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.ListBox)this.ScenarioControl).SelectionChanged += this.ScenarioControl_SelectionChanged;
                }
                break;
            case 10: // MainPage.xaml line 41
                {
                    this.FooterPanel = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target);
                }
                break;
            case 11: // MainPage.xaml line 43
                {
                    this.Copyright = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 12: // MainPage.xaml line 46
                {
                    this.LinksPanel = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target);
                }
                break;
            case 13: // MainPage.xaml line 47
                {
                    global::Microsoft.UI.Xaml.Controls.HyperlinkButton element13 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.HyperlinkButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.HyperlinkButton)element13).Click += this.Footer_Click;
                }
                break;
            case 14: // MainPage.xaml line 50
                {
                    this.PrivacyLink = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.HyperlinkButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.HyperlinkButton)this.PrivacyLink).Click += this.Footer_Click;
                }
                break;
            case 17: // MainPage.xaml line 56
                {
                    this.ScenarioFrame = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Frame>(target);
                }
                break;
            case 18: // MainPage.xaml line 57
                {
                    this.StatusPanel = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target);
                }
                break;
            case 19: // MainPage.xaml line 58
                {
                    this.StatusLabel = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 20: // MainPage.xaml line 59
                {
                    this.StatusBorder = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Border>(target);
                }
                break;
            case 21: // MainPage.xaml line 62
                {
                    this.StatusBlock = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 16: // MainPage.xaml line 37
                {                    
                    global::Microsoft.UI.Xaml.Controls.TextBlock element16 = (global::Microsoft.UI.Xaml.Controls.TextBlock)target;
                    MainPage_obj16_Bindings bindings = new MainPage_obj16_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element16.DataContext);
                    element16.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Microsoft.UI.Xaml.DataTemplate.SetExtensionInstance(element16, bindings);
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element16, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

