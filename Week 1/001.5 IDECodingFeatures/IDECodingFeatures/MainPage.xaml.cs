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

namespace IDECodingFeatures
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        #region Fields

        // Add Fields here

        #endregion

        #region Constructors

        public MainPage()
        {
            this.InitializeComponent();
        }
        #endregion

        #region Methods

        // Add Methods here

        #endregion


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // A single line comment

            /* 
            * A block of comments
            * A block of comments
            */

            /* 
                A block of comments
                A block of comments
            */

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name = "inputA" ></ param >
        /// < param name="inputB"></param>
        /// <returns></returns>
        //public int test(int inputA, int inputB)
        //{
        //    return inputA + inputB;
        //}


        public void test()
        {
            int creditRate;

            creditRate = 20;
            creditRate = 30;
            creditRate = 40;
            creditRate = creditRate + 50;
        }

    }
}
