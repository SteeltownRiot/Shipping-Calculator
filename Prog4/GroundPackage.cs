/*
 * John Hopson
 * Program 4 (class)
 * 24 April 2016
 * CIS 199-75
 * This class is used to create GroundPackage objects, setting and passing the properties of packages
 * There is also a method used to calculate the cost of shipping the package and a method to format
 * all the package's data as a string.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    public class GroundPackage
    {
        private int _originZip,         //temporarily stores origniation zip code
                    _destinationZip;    //temporarily stores destination zip code
        private double _length,         //temporarily stores package length
                       _width,          //temporarily stores package width
                       _height,         //temporarily stores package height
                       _weight;         //temporarily stores package weight

        // Precondition: 00000 <= oZip <= 99999
        //               00000 <= dZip <= 99999
        //               0 < length
        //               0 < width
        //               0 < height
        //               0 < weight
        // Postcondition: The GroundPackage object has been initialized with the specified origination zip code, destination zip code,
        //                length, width, height, and weight
        public GroundPackage(int oZip, int dZip, double length, double width, double height, double weight)
        {
            OriginZip = oZip;       //set the OriginZip property
            DestinationZip = dZip;  //set the DestinationZip property
            Length = length;        //set the Length property
            Width = width;          //set the Width property
            Height = height;        //set the Height property
            Weight = weight;        //set the Weight property
        }

        public int OriginZip
        {
            //Precondition: None
            //Postcondition: The origination zip code is returned
            get { return _originZip; }

            //Precondition: 0 <= value <= 99999
            //Postcondition: origination zip code set to the specified value
            set
            {
                if (value >= 00000 && value <= 99999)
                {
                    _originZip = value;
                }
                else  //When invalid, set to 0 instead
                {
                    _originZip = 0;
                }
            }
        }

        public int DestinationZip
        {
            //Precondition: None
            //Postcondition: The destination zip code is returned
            get { return _destinationZip; }

            //Precondition: 0 <= value <= 99999
            //Postcondition: destination zip code set to the specified value
            set
            {
                if (value >= 0 && value <= 99999)
                {
                    _destinationZip = value;
                }
                else  //When invalid, set to 0 instead
                {
                    _destinationZip = 0;
                }
            }
        }

        public double Length
        {
            //Precondition: None
            //Postcondition: The package length is returned
            get { return _length; }

            //Precondition: value > 0
            //Postcondition: package length set to the specified value
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
                else  //When invalid, set to 0 instead
                {
                    _length = 0;
                }
            }
        }

        public double Width
        {
            //Precondition: None
            //Postcondition: The package width is returned
            get { return _width; }

            //Precondition: value > 0
            //Postcondition: package width set to the specified value
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else  //When invalid, set to 0 instead
                {
                    _width = 0;
                }
            }
        }

        public double Height
        {
            //Precondition: None
            //Postcondition: The package height is returned
            get { return _height; }

            //Precondition: value > 0
            //Postcondition: package height set to the specified value
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else  //When invalid, set to 0 instead
                {
                    _height = 0;
                }
            }
        }

        public double Weight
        {
            //Precondition: None
            //Postcondition: The package weight is returned
            get { return _weight; }

            //Precondition: value > 0
            //Postcondition: package weight set to the specified value
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
                else  //When invalid, set to 0 instead
                {
                    _weight = 0;
                }
            }
        }

        public int ZoneDistance
        {
            //Precondition: OriginZip must be a 5-digit positive number
            //              DestinationZip must be a 5-digit positive number
            //Postcondition: Calculates the number of zones package traveles based on the zip codes
            get { return Math.Abs(OriginZip / 10000 - DestinationZip / 10000); }
        }

        //Precondition:  0 < Length
        //               0 < Width
        //               0 < Height
        //               0 < Weight 
        //               0 <= ZoneDistance
        //Postcondition: Calculates the cost of shipping a package
        public double CalcCost()
        {
            double cost;
            const double volumeFactor = 0.2,  //
                         weightFactor = 0.5;  //
            cost = volumeFactor * (Length + Width + Height) + weightFactor * (ZoneDistance + 1) * Weight;
            return cost;
        }

        //Precondition: None
        //Postcondition: Returns a formatted string of details about the package
        public override string ToString()
        {
            return string.Format("Package details{6}   From: {0:d5}{6}   To: {1:d5}{6}   Length: {2:n1} in{6}   Width: {3:n1} in{6}   Height: {4:n1} in{6}   Weight: {5:n1} lb{6}",
                OriginZip, DestinationZip, Length, Width, Height, Weight, System.Environment.NewLine);
        }
    }
}
