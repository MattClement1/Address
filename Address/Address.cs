/*
*Created by: Matthew Clement
*Created on: 26-Nov-2015
*Created for: Unit #6-04
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
        public enum PROVINCES
        {
            NL,
            PE,
            NS,
            NB,
            QC,
            ON,
            MB,
            SK,
            AB,
            BC,
            YT,
            NT,
            NU
        }
        public enum STREET_TYPE
        {
            Dr,
            Cres,
            Ave,
            St,
            Blvd
        }

        public struct Address
        {
            public string aptNumber;
            public string streetAddress;
            public string city;
            public PROVINCES province;
            public STREET_TYPE streetType;
            public string postalCode;
        }

        private void ShowAddress(string aptNumber, string streetAddress, Enum streetType, string city, Enum province, string postalCode)
        {
            MessageBox.Show("Apartment " + aptNumber + ", " + streetAddress + " " + streetType + ", " + city + ", " + province + ", " + postalCode);
        }

        private void ShowAddress(string streetAddress, Enum streetType, string city, Enum province, string postalCode)
        {
            MessageBox.Show(streetAddress  + " " + streetType + ", " + city + ", " + province + ", " + postalCode);
        }

        public frmAddress()
        {
            InitializeComponent();
        }

        private void btnShowAddress_Click(object sender, EventArgs e)
        {
            Address address = new Address();
            address.aptNumber = this.txtAptNumber.Text;
            address.streetAddress = this.txtStreetAddress.Text;
            address.city = this.txtCity.Text;
            string selectedProvince = this.cboProvinces.Text;
            address.province = (PROVINCES)Enum.Parse(typeof(PROVINCES), selectedProvince, true);
            string selectedType = this.cboStreetType.Text;
            address.streetType = (STREET_TYPE)Enum.Parse(typeof(STREET_TYPE), selectedType, true);

            address.postalCode = this.txtPostalCode.Text;

            if (address.aptNumber == "")
            {
                ShowAddress(address.streetAddress, address.streetType, address.city, address.province, address.postalCode);
            }
            else
            {
                ShowAddress(address.aptNumber, address.streetAddress, address.streetType, address.city, address.province, address.postalCode);
            }
            
        }
    }
}
