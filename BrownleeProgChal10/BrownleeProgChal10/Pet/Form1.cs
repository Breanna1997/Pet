using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(ValidatePetName(txtBox_Name.Text) &&
            ValidatePetType(txtBox_Pet.Text) &&
            ValidateAge(txtBox_Age.Text))
            {
                Pet userPet = new Pet(txtBox_Name.Text, txtBox_Pet.Text, int.Parse(txtBox_Age.Text));

                MessageBox.Show("Information saved! Pet Name: " + userPet.Name + "\n Pet Type: " + userPet.Type + "\n Pet Age: " + userPet.Age);
            }
        }

        private bool ValidateAge(string text)
        {
            bool res;
            int age;
            res = int.TryParse(text, out age);
            if (res == false || age < 1)
            {
                MessageBox.Show("Age must be a numeric value and greater than 0");
                return false;
            }
            else
                return true;
        }

        private bool ValidatePetType(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                MessageBox.Show("Pet must have a type");
                return false;
            }
            else
                return true;
        }

        private bool ValidatePetName(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                MessageBox.Show("Pet must have a name");
                return false;
            }
            else
                return true;
        }
    }
}
