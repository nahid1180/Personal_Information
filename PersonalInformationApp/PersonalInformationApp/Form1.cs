using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonalInformationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void nameButton_Click(object sender, EventArgs e)
        {
            string firstName = Convert.ToString(firstNameTextBox.Text);
            string lastName = Convert.ToString(lastNameTextBox.Text);
            string name = firstName + lastName;
            MessageBox.Show(name);
            
        }

        private void parrentButton_Click(object sender, EventArgs e)
        {
            string father = Convert.ToString(fathersNameTextBox.Text);
            string mother = Convert.ToString(mothersNameTextBox.Text);
            string parent = father + mother;
            MessageBox.Show(parent);
            
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            string address = Convert.ToString(addressTextBox.Text);
            MessageBox.Show(address);
           
        }

        private void showInfoButton_Click(object sender, EventArgs e)
        {
            string firstName = Convert.ToString(firstNameTextBox.Text);
            string lastName = Convert.ToString(lastNameTextBox.Text);
            string name = firstName + lastName;

            string father = Convert.ToString(fathersNameTextBox.Text);
            string mother = Convert.ToString(mothersNameTextBox.Text);
            string parent = father + mother;

            string address = Convert.ToString(addressTextBox.Text);

            string information = name + parent + address;
            MessageBox.Show(information);
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string firstName = Convert.ToString(firstNameTextBox.Text);
            string lastName = Convert.ToString(lastNameTextBox.Text);
            string name = firstName + lastName;

            string father = Convert.ToString(fathersNameTextBox.Text);
            string mother = Convert.ToString(mothersNameTextBox.Text);
            string parent = father + mother;

            string address = Convert.ToString(addressTextBox.Text);

            string information = name + parent + address;
        }
        
    }
}
