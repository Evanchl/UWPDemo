using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Diagnostics;
using Windows.Storage;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace FileOperation
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StorageFolder appFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            FileAttributes folderAttributes = appFolder.Attributes;
            if ((folderAttributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                Debug.WriteLine("The item is read-only.");
            }
            if ((folderAttributes & FileAttributes.Directory) == FileAttributes.Directory)
            {
                Debug.WriteLine("The item is folder.");
            }
            if ((folderAttributes & FileAttributes.Archive) == FileAttributes.Archive)
            {
                Debug.WriteLine("The item is archived.");
            }
            if ((folderAttributes & FileAttributes.Temporary) == FileAttributes.Temporary)
            {
                Debug.WriteLine("The item is temporary.");
            }

        }
    }
}
