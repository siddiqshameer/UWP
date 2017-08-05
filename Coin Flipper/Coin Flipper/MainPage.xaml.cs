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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Coin_Flipper
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public List<string> coinToss = new List<string>();
        int headCount = 0, tailCount = 0;

        public MainPage()
        {
            InitializeComponent();
            coinTosser();

        }

        public void coinTosser()
        {

            coinToss.Add("Head");
            coinToss.Add("Tail");
        }

        public void TossButton_Click(object sender, RoutedEventArgs e)
        {

            Random Toss = new Random();
            int which = Toss.Next(coinToss.Count);
            string tossDisplay = coinToss[which];
            TossResult.Text = tossDisplay;
            if (which == 0)
            {
                headCount++;
            }
            else if (which == 1)
            {
                tailCount++;
            }

        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            TossResult.Text = "Start again..";
            headCount = 0;
            tailCount = 0;
        }

        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            TossResult.Text = headCount + " Heads and " + tailCount + " Tails";
        }
    }
}
