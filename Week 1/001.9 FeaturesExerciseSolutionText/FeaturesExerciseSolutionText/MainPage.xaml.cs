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
using Windows.Media.SpeechSynthesis;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FeaturesExerciseSolutionText
{
   
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    { 
        // What does this mean (SpeechSynthesizer). Provides access to the speech synthesis engine (voice) for Text-to-speech 
        SpeechSynthesizer reader;

        public MainPage()
        {
            this.InitializeComponent();
            // Configure the audio output.
            reader = new SpeechSynthesizer();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Talk the text
            Talk(TextBox1.Text);
        }

        /// <summary>
        /// Plays a text to talk
        /// </summary>
        /// <param name="message">Our message to talk</param>
        private async void Talk(string message)
        {
            // Get the text
            var stream = await reader.SynthesizeTextToStreamAsync(message);
            // Setup the stream for the player
            media.SetSource(stream, stream.ContentType);
            // Play the message
            media.Play();
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
            double adSomeNumbers;

            adSomeNumbers = 20.22;
            adSomeNumbers = aNumber + aDecimalNumber;
            adSomeNumbers = adSomeNumbers + aNumber + aDecimalNumber;

            #endregion
        }

        /// <summary>
        /// Loads a quote on a button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_Quote(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "In rode the Lord of the Nazgûl. A great black shape against the fires beyond he loomed up, " +
                            "grown to a vast menace of despair. In rode the Lord of the Nazgûl, under the archway that no " +
                            "enemy ever yet had passed, and all fled before his face. All save one. There waiting, silent " +
                            "and still in the space before the Gate, sat Gandalf upon Shadowfax: Shadowfax who alone among " +
                            "the free horses of the earth endured the terror, unmoving, steadfast as a graven image in " +
                            "Rath Dínen. You cannot enter here, said Gandalf, and the huge shadow halted. Go back to the " +
                            "abyss prepared for you! Go back! Fall into the nothingness that awaits you and your Master. " +
                            "Go! The Black Rider flung back his hood, and behold! he had a kingly crown; and yet upon no head " +
                            "visible was it set. The red fires shone between it and the mantled shoulders vast and dark. " +
                            "From a mouth unseen there came a deadly laughter. Old fool! he said. Old fool! This is my hour. " +
                            "Do you not know Death when you see it? Die now and curse in vain! And with that he lifted high his " +
                            "sword and flames ran down the blade. And in that very moment, away behind in some courtyard of the " +
                            "city, a cock crowed. Shrill and clear he crowed, recking nothing of war nor of wizardry, welcoming " +
                            "only the morning that in the sky far above the shadows of death was coming with the dawn. And as if " +
                            "in answer there came from far away another note. Horns, horns, horns, in dark Mindolluin’s sides they " +
                            "dimly echoed. Great horns of the north wildly blowing. Rohan had come at last. – Quote from - J. R. Tolken.";
        }
    }
}

