/*
 * John Hopson
 * 
 * This program takes the user inputs of origination and destination zip codes, as well as the packages length,
 * width, height, and weight and uses this data to pass to the the GroundPackage class. The form tracks the
 * packages added to the list and enables the user to view the details of each package as well as change
 * the origination and destination zip codes to UofL's zip code.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog4
{
    public partial class PackageCalculator : Form
    {
        const int uoflZip = 40292;          //Stores UofL zip code, would need to be changed to local zip

        //List holds GroundPackage objects
        List<GroundPackage> packageList = new List<GroundPackage>();

        public PackageCalculator()
        {
            InitializeComponent();
        }

        // Precondition:  0 <= originZip <= 99999
        //                0 <= desinationZip <= 99999
        //                0 < length
        //                0 < width
        //                0 < height
        //                0 < weight
        // Postcondition: The package's properties are changed to the specified origination zip code,
        //                destination zip code, length, width, height, and weight
        private void addPackageButton_Click(object sender, EventArgs e)
        {
            int originZip =-1,     //holds the origination zip code
                desinationZip=-1; //holds the destination zip code
            double length=-1,     //holds the package length
                   width=-1,      //holds the package width
                   height=-1,     //holds the package height
                   weight=-1;     //holds the package weight

            //Validate origination zip code input
            if (int.TryParse(originZipTB.Text, out originZip) && originZip >= 0 && originZip <= 99999)
            {
                //Validate destination zip code input
                if (int.TryParse(destinationZipTB.Text, out desinationZip) && desinationZip >= 0 && originZip <= 99999)
                {
                    //Validate length input
                    if (double.TryParse(lengthTB.Text, out length) && length > 0)
                    {
                        //Validate width input
                        if (double.TryParse(widthTB.Text, out width) && width > 0)
                        {
                            //Validate height input
                            if (double.TryParse(heightTB.Text, out height) && height > 0)
                            {
                                //Validate weight input
                                if (double.TryParse(weightTB.Text, out weight) && weight > 0)
                                {
                                    //Create a GroundPackage object
                                    GroundPackage newPackage = new GroundPackage(originZip, desinationZip, length, width, height, weight);
                                    //Sets package's origination zip code to input zip code
                                    newPackage.OriginZip = originZip;
                                    //Sets package's destination zip code to input zip code
                                    newPackage.DestinationZip = desinationZip;
                                    //Sets package's length to input zip code
                                    newPackage.Length = length;
                                    //Sets package's width to input zip code
                                    newPackage.Width = width;
                                    //Sets package's height to input zip code
                                    newPackage.Height = height;
                                    //Sets package's weight to input zip code
                                    newPackage.Weight = weight;

                                    //Adds package to the list
                                    packageList.Add(newPackage);

                                    //Calculates package cost and adds to list box
                                    shippingLB.Items.Add(newPackage.CalcCost().ToString("C"));

                                    //Clear text boxes
                                    originZipTB.Clear();
                                    destinationZipTB.Clear();
                                    lengthTB.Clear();
                                    widthTB.Clear();
                                    heightTB.Clear();
                                    weightTB.Clear();

                                    //Reset the focus
                                    originZipTB.Focus();
                                }
                                else
                                {
                                    //Weight not a double and or not greater than 0
                                    MessageBox.Show("The weight you entered is invalid. Your entry must be a positive number greater than zero. Please try again.",
                                        "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                //Height not a double and or not greater than 0
                                MessageBox.Show("The height you entered is invalid. Your entry must be a positive number greater than zero. Please try again.",
                                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            //Width not a double and or not greater than 0
                            MessageBox.Show("The width you entered is invalid. Your entry must be a positive number greater than zero. Please try again.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //Length not a double and or not greater than 0
                        MessageBox.Show("The length you entered is invalid. Your entry must be a positive number greater than zero. Please try again.",
                            "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Destination zip code not an integer and or not greater than 0
                    MessageBox.Show("The destination zip code you entered is invalid. Your entry must be a 5-digit positive number. Please try again.",
                        "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Origination zip code not an integer and or not greater than 0
                MessageBox.Show("The origination zip code you entered is invalid. Your entry must be a 5-digit positive number. Please try again.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Precondition: None
        //Postcondition: Displays the details of the package object selected in list box
        private void detailsButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = shippingLB.SelectedIndex;   //Stores the package index location based on index location in list
            //Checks to see if a package is selected in the list box
            if (shippingLB.SelectedIndex != -1)
            {
                //Displays the details of the selected package
                MessageBox.Show(packageList[selectedIndex].ToString());
            }
            else  //No package selected in list box
            {
                MessageBox.Show("You need to select a package from the lest. Please try again.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Precondition: None
        //Postcondition: Changes the destination zip code, recalculate, and redisplays the shipping cost,
        //               then lets the user know the zip code has been changed
        private void toUofLButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = shippingLB.SelectedIndex;   //Stores the package index location based on index location in list
            //Checks to see if a package is selected in the list box
            if (shippingLB.SelectedIndex != -1)
            {
                //Sets destination zip code of selected package to UofL's zip code
                packageList[selectedIndex].DestinationZip = uoflZip;

                //Recalculates and redisplays the package's shipping cost in the listbox
                shippingLB.Items[selectedIndex] = (packageList[selectedIndex].CalcCost().ToString("C"));

                //Message lets user know the zip code has been reset to UofL's zip code
                MessageBox.Show("The package's destination has been reset to 40292.");
            }
            else  //No package selected in list box
            {
                MessageBox.Show("You need to select a package from the list. Please try again.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Precondition: None
        //Postcondition: Changes the origination zip code, recalculates and redisplays the shipping cost,
        //               then lets the user know the zip code has been changed
        private void fromUofLButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = shippingLB.SelectedIndex;   //Stores the package index location based on index location in list
            if (shippingLB.SelectedIndex != -1)
            {
                //Sets origination zip code of selected package to UofL's zip code
                packageList[selectedIndex].OriginZip = uoflZip;

                //Recalculates and redisplays the package's shipping cost in the listbox
                shippingLB.Items[selectedIndex] = (packageList[selectedIndex].CalcCost().ToString("C"));

                //Message lets user know the zip code has been reset to UofL's zip code
                MessageBox.Show("The package's origin has been reset to 40292.");
            }
            else  //No package selected in list box
            {
                MessageBox.Show("You need to select a package from the list. Please try again.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
