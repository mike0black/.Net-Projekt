﻿

#pragma checksum "D:\Antoni\Studia\.NET programowanie\FeedReader\FeedReader\SplitPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "902E259F3ED2BB949FD7D9411760E6F2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FeedReader
{
    partial class SplitPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 96 "..\..\SplitPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.ItemListView_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 143 "..\..\SplitPage.xaml"
                ((global::Windows.UI.Xaml.Controls.WebView)(target)).NavigationFailed += this.ContentView_NavigationFailed;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 78 "..\..\SplitPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Button_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


