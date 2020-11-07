using DbUwp2.Views;
using System;
using System.Collections.Generic;
using System.IO;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DbUwp2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnNewProblem_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(typeof(NewProblemView));
            
        }

        private void btnOpenProblems_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(typeof(AllProblemsView));
            
           
        }

        private void btnClosedProblems_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(typeof(ClosedProblems));
        }
    }
}
