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

namespace HowToDebugExercise
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.nitializeComponent();
        }
        private void SomeCode(
        {
            int aNum;
            int bNum

            aNum = 20;
            bNum = 20

            aNum = aNum + bNum + anum;
        }



        #region Stepping Through Code
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddSomething();
            AddSomethingMore();
            GoInto();
        }

        private void AddSomething()
        {
            int countA;

            for (int a = 0; a < 10; a++)
            {
                countA = a * 2;
            }
        }

        private void AddSomethingMore()
        {
            int countB;

            for (int b = 0; b < 10; b = b + 3)
            {
                countB = b * 3;
            }
        }

        private void GoInto()
        {
            // we are here
            NexLayerInto();
        }

        private void NexLayerInto()
        {
            // We are now in here
            AnotherLayerInto();
        }

        private void AnotherLayerInto()
        {
            // We are now in here
            int countC = 1;
            countC = countC + 2;
        }

        #endregion
    }
}

