/*
*Created by: Matthew Clement
*Created on: 02-Nov-2015
*Created for: Unit #4-03
*This program displays the inputted address
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

namespace Address
{
    public partial class frmAddress : Form
    {
        private void ShowAddress(string aptNumber, string streetAddress, string city, string province, string postalCode)
        {
            MessageBox.Show("Apartment " + aptNumber + ", " + streetAddress + ", " + city + ", " + province + ", " + postalCode);
        }

        private void ShowAddress(string streetAddress, string city, string province, string postalCode)
        {
            MessageBox.Show(streetAddress + ", " + city + ", " + province + ", " + postalCode);
        }

        public frmAddress()
        {
            InitializeComponent();
        }

        private void btnShowAddress_Click(object sender, EventArgs e)
        {
            string aptNumberInput = this.txtAptNumber.Text;
            string streetAddressInput = this.txtStreetAddress.Text;
            string cityInput = this.txtCity.Text;
            string provinceInput = this.txtProvince.Text;
            string postalCodeInput = this.txtPostalCode.Text;

            if (aptNumberInput == "")
            {
                ShowAddress(streetAddressInput, cityInput, provinceInput, postalCodeInput);
            }
            else
            {
                ShowAddress(aptNumberInput, streetAddressInput, cityInput, provinceInput, postalCodeInput);
            }
            
        }
    }
}
