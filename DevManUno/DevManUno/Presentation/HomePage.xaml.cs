using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DevManUno.Presentation
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class ProList : Page
	{
		public ProList()
		{
			this.InitializeComponent();
		}

        private async void OperateBtn_Click(object sender, RoutedEventArgs e)
        {
            // if the users leaves one or both inputboxes as empty spaces or white space (" ")
            if (string.IsNullOrWhiteSpace(NumBox1.Text) || string.IsNullOrWhiteSpace(NumBox2.Text))
            {
                // Set the Numberboxes and the Textblock to 0
                NumBox1.Text = "0"; 
                NumBox2.Text = "0";
                ResultTxt.Text = "0";

                // Declare a ContentDialog box 
                ContentDialog WhiteSpaceDialog = new ContentDialog();

                WhiteSpaceDialog.XamlRoot = this.XamlRoot;
                WhiteSpaceDialog.Title = "Please provide values to calculate"; // Set the title of the dialogbox
                WhiteSpaceDialog.Content = "One or both number fields are empty."; // The description of the dialogbox
                WhiteSpaceDialog.PrimaryButtonText = "OK"; // Set the primary text to OK
                WhiteSpaceDialog.DefaultButton = ContentDialogButton.Primary; // Set the primary button to an accent colour

                await WhiteSpaceDialog.ShowAsync(); // show the dialog once finished creating

                return;
            }
            else // or else run the AddOperation() function
            {
                AddOperations(Int32.Parse(NumBox1.Text), Int32.Parse(NumBox2.Text));
            }
        }

        private void AddOperations(double FirstNum, double SecNum)
        {
            // Add numbers from NumBox1 and NumBox2 and display it
            // on ResultTxt
            double result = FirstNum + SecNum; // Declare a result vraiable which will add FirstNum and SecNum

            ResultTxt.Text = result.ToString(); // display the result on ResultTxt with ToString() used to convert
                                                // the Double variable to a String
        }
    }
}
