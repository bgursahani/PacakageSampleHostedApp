using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.Windows.ApplicationModel.WindowsAppRuntime;
using System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Management.Deployment;

namespace PackageSampleHostedApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Scenario4 : Page
    {
        // A pointer back to the main page.  This is needed if you want to call methods in MainPage such
        // as NotifyUser()
        MainPage rootPage = MainPage.Current;

        public Scenario4()
        {
            this.InitializeComponent();
        }

        //[Windows.Foundation.Metadata.Overload("AddPackageByUriAsync")]
        //[Windows.Foundation.Metadata.RemoteAsync]
        //public IAsyncOperationWithProgress<Microsoft.Windows.ApplicationModel.WindowsAppRuntime.DeploymentResult, DeploymentProgress> AddPackageByUriAsync(System.Uri packageUri, AddPackageOptions options);


        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void GetHostInfo_Click(object sender, RoutedEventArgs e)
        {

            IReadOnlyList<Windows.ApplicationModel.Package> dependents = Package.Current.Find;

            String output = String.Format("Count: {0}", dependents.Count.ToString());
            for (int i = 0; i < dependents.Count; i++)
            {
                Package dependent = dependents[i];
                output += String.Format("\n[{0}]: {1}", i.ToString(), dependent.Id.FullName);
            }

            OutputTextBlock.Text = output;
        }
    }
}
