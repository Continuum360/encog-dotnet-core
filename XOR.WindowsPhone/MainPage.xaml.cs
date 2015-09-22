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
using Encog.Neural.Networks;
using Encog.Neural.Networks.Layers;
using Encog.Engine.Network.Activation;
using Encog.ML.Data;
using Encog.Neural.Networks.Training.Propagation.Resilient;
using Encog.ML.Train;
using Encog.ML.Data.Basic;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace XOR
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static double[][] XORInput = {
            new[] {0.0,0.0},
            new[] {1.0, 0.0},
            new[] {0.0, 1.0},
            new[] {1.0, 1.0}};
        public static double[][] XORIdeal = {
            new[] {0.0},
            new[] {1.0},
            new[] {1.0},
            new[] {0.0}
                                            };
        public static BasicNetwork network = new BasicNetwork();

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
//            var InputLayer = new BasicLayer(null, true, 2);
//            network.AddLayer(InputLayer);
//            network.AddLayer(new BasicLayer(new ActivationSigmoid(), true, 3));
//            network.AddLayer(new BasicLayer(new ActivationSigmoid(), false, 1));
//            network.Structure.FinalizeStructure();
//            network.Reset();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void Train_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Build_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
