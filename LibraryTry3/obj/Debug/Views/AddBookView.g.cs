﻿#pragma checksum "..\..\..\Views\AddBookView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "75E491340AD78C281E24110D646816D19C32E89A45116C582AD1C67F68CE117E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
using LibraryTry3.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace LibraryTry3.Views {
    
    
    /// <summary>
    /// AddBookView
    /// </summary>
    public partial class AddBookView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LibraryTry3.Views.AddBookView bookView;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid bookGrid;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl BookTab;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem AddTab;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBookName;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAuthor;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPublisher;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtISBN;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCallNum;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCopies;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSummary;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrice;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboLanguage;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboCollection;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboCategory;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker publishDatePicer;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker shelfDatePicker;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCover;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock coverTxt;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image coverImg;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_AddBook;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClear;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem EditTab;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRefresh;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_EditBook;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_delete;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboxField;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchField;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateFieldPicker;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboxSearchTxt;
        
        #line default
        #line hidden
        
        
        #line 182 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch_Book;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClear_Search;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid BookDataGrid;
        
        #line default
        #line hidden
        
        
        #line 249 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbBookName;
        
        #line default
        #line hidden
        
        
        #line 257 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image selectedBookCover;
        
        #line default
        #line hidden
        
        
        #line 270 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label authorTitle;
        
        #line default
        #line hidden
        
        
        #line 271 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pubTitle;
        
        #line default
        #line hidden
        
        
        #line 272 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ISBNTitle;
        
        #line default
        #line hidden
        
        
        #line 273 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label callTitle;
        
        #line default
        #line hidden
        
        
        #line 274 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label languageTitle;
        
        #line default
        #line hidden
        
        
        #line 275 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label sumTitle;
        
        #line default
        #line hidden
        
        
        #line 278 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbAuthor;
        
        #line default
        #line hidden
        
        
        #line 279 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbPublisher;
        
        #line default
        #line hidden
        
        
        #line 280 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbISBN;
        
        #line default
        #line hidden
        
        
        #line 281 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbCallNum;
        
        #line default
        #line hidden
        
        
        #line 282 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbLanguage;
        
        #line default
        #line hidden
        
        
        #line 284 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lbSummary;
        
        #line default
        #line hidden
        
        
        #line 296 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker issueDate;
        
        #line default
        #line hidden
        
        
        #line 300 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboReaderID;
        
        #line default
        #line hidden
        
        
        #line 308 "..\..\..\Views\AddBookView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIssueBook;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LibraryTry3;component/views/addbookview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AddBookView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.bookView = ((LibraryTry3.Views.AddBookView)(target));
            return;
            case 2:
            this.bookGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 11 "..\..\..\Views\AddBookView.xaml"
            this.bookGrid.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BookGrid_OnMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BookTab = ((System.Windows.Controls.TabControl)(target));
            
            #line 12 "..\..\..\Views\AddBookView.xaml"
            this.BookTab.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.BookTab_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AddTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 5:
            this.txtBookName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtAuthor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtPublisher = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtISBN = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtCallNum = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.txtCopies = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.txtSummary = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.txtPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.comboLanguage = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 14:
            this.comboCollection = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 15:
            this.comboCategory = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 16:
            this.publishDatePicer = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 17:
            this.shelfDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 18:
            this.btnCover = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\Views\AddBookView.xaml"
            this.btnCover.Click += new System.Windows.RoutedEventHandler(this.btnCover_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.coverTxt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 20:
            this.coverImg = ((System.Windows.Controls.Image)(target));
            return;
            case 21:
            this.btn_AddBook = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\Views\AddBookView.xaml"
            this.btn_AddBook.Click += new System.Windows.RoutedEventHandler(this.btnAddBook_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            this.btnClear = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\Views\AddBookView.xaml"
            this.btnClear.Click += new System.Windows.RoutedEventHandler(this.BtnClear_OnClick);
            
            #line default
            #line hidden
            return;
            case 23:
            this.EditTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 24:
            this.btnRefresh = ((System.Windows.Controls.Button)(target));
            
            #line 119 "..\..\..\Views\AddBookView.xaml"
            this.btnRefresh.Click += new System.Windows.RoutedEventHandler(this.BtnRefresh_OnClick);
            
            #line default
            #line hidden
            return;
            case 25:
            this.btn_EditBook = ((System.Windows.Controls.Button)(target));
            
            #line 129 "..\..\..\Views\AddBookView.xaml"
            this.btn_EditBook.Click += new System.Windows.RoutedEventHandler(this.Btn_EditBook_OnClick);
            
            #line default
            #line hidden
            return;
            case 26:
            this.btn_delete = ((System.Windows.Controls.Button)(target));
            
            #line 141 "..\..\..\Views\AddBookView.xaml"
            this.btn_delete.Click += new System.Windows.RoutedEventHandler(this.Btn_delete_OnClick);
            
            #line default
            #line hidden
            return;
            case 27:
            this.comboxField = ((System.Windows.Controls.ComboBox)(target));
            
            #line 162 "..\..\..\Views\AddBookView.xaml"
            this.comboxField.DropDownClosed += new System.EventHandler(this.ComboxField_OnDropDownClosed);
            
            #line default
            #line hidden
            return;
            case 28:
            this.txtSearchField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 29:
            this.dateFieldPicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 30:
            this.comboxSearchTxt = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 31:
            this.btnSearch_Book = ((System.Windows.Controls.Button)(target));
            
            #line 183 "..\..\..\Views\AddBookView.xaml"
            this.btnSearch_Book.Click += new System.Windows.RoutedEventHandler(this.BtnSearch_Book_OnClick);
            
            #line default
            #line hidden
            return;
            case 32:
            this.btnClear_Search = ((System.Windows.Controls.Button)(target));
            
            #line 192 "..\..\..\Views\AddBookView.xaml"
            this.btnClear_Search.Click += new System.Windows.RoutedEventHandler(this.BtnClear_Search_OnClick);
            
            #line default
            #line hidden
            return;
            case 33:
            this.BookDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 199 "..\..\..\Views\AddBookView.xaml"
            this.BookDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.BookDataGrid_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 34:
            this.tbBookName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 35:
            this.selectedBookCover = ((System.Windows.Controls.Image)(target));
            return;
            case 36:
            this.authorTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 37:
            this.pubTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 38:
            this.ISBNTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 39:
            this.callTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 40:
            this.languageTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 41:
            this.sumTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 42:
            this.lbAuthor = ((System.Windows.Controls.Label)(target));
            return;
            case 43:
            this.lbPublisher = ((System.Windows.Controls.Label)(target));
            return;
            case 44:
            this.lbISBN = ((System.Windows.Controls.Label)(target));
            return;
            case 45:
            this.lbCallNum = ((System.Windows.Controls.Label)(target));
            return;
            case 46:
            this.lbLanguage = ((System.Windows.Controls.Label)(target));
            return;
            case 47:
            this.lbSummary = ((System.Windows.Controls.TextBox)(target));
            return;
            case 48:
            this.issueDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 49:
            this.comboReaderID = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 50:
            this.btnIssueBook = ((System.Windows.Controls.Button)(target));
            
            #line 308 "..\..\..\Views\AddBookView.xaml"
            this.btnIssueBook.Click += new System.Windows.RoutedEventHandler(this.BtnIssueBook_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

