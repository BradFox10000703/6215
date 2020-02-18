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
// What does this mean (using). Imports types defined in other namespaces
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FeaturesExerciseSolution
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Output.Text = "This is my first application, watch this space I will become a programming Guru.Today C# tomorrow the world.";
        }


        /// <summary>
        /// Testbed for Region and Refraction examples 
        /// </summary>
        public void Refractor()
        {

            #region First Change

            // What does this mean (int): The int keyword denotes an integer type (a whole number). 
            int aNumber;

            aNumber = 20;
            aNumber = aNumber + 20;
            aNumber = aNumber + aNumber + 20;

            #endregion

            #region Second Change

            // What does this mean (double): The double keyword denotes an simple type that stores 64-bit floating-point values (a number with a decimal point).
            double aDecimalNumber;

            aDecimalNumber = 20.22;
            aDecimalNumber = aDecimalNumber + 20.22;
            aDecimalNumber = aDecimalNumber + aDecimalNumber + +20.22;

            #endregion

            #region Third Change

            // Let's add some numbers
            double addSomeNumbers;

            addSomeNumbers = 20.22;
            addSomeNumbers = aNumber + aDecimalNumber;
            addSomeNumbers = addSomeNumbers + aNumber + aDecimalNumber;

            #endregion
        }
    }
}
