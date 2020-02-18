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
// What does this mean (using)
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FeaturesExercise
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


// What does this mean (int) 
int ABC;

ABC = 20;
ABC = ABC + 20;
ABC = ABC + ABC + 20;





// What does this mean (double)
double XYZ;

XYZ = 20.22;
XYZ = XYZ + 20.22;
XYZ = XYZ + XYZ + +20.22;





// Let's add some numbers
double addsomething;

addsomething = 20.22;
addsomething = ABC + XYZ;
addsomething = addsomething + ABC + XYZ;



}
}
}
