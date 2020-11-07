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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DbUwp2.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AllProblemsView : Page
    {

       
        public AllProblemsView()
        {
            this.InitializeComponent();
        }

        private void btnAll_Click(object sender, RoutedEventArgs e)
        {
            lvAllProblems.ItemsSource = DataAccess.GetAllNew();
        }

        private void btnActiveProblems_Click(object sender, RoutedEventArgs e)
        {
            lvActiveProblems.ItemsSource = DataAccess.GetAllActive();
        }

        private async void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

            
            await DataAccess.UpdateAsync(Convert.ToInt32(tbProblemId.Text), tbStatus.Text);
            lvActiveProblems.ItemsSource = DataAccess.GetAllActive();
            

        }
    }
}
