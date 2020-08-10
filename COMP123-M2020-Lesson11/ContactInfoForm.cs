using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_Lesson11
{
    public partial class ContactInfoForm : Form
    {
        public List<Contact> Contacts { get; set; }


        public ContactInfoForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contacts = new List<Contact>(); // instantiates the List container


            // configure the open file dialog
            ContactListOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            // open the file dialog
            var openFileDialogResult = ContactListOpenFileDialog.ShowDialog();

            if(openFileDialogResult != DialogResult.Cancel)
            {
                // create a new stream reader
                StreamReader streamReader = new StreamReader(ContactListOpenFileDialog.FileName);

                // read in the list

                while (!streamReader.EndOfStream)
                {
                    var contact = new Contact();

                    contact.FirstName = streamReader.ReadLine();
                    contact.LastName = streamReader.ReadLine();
                    contact.EmailAddress = streamReader.ReadLine();
                    contact.ContactNumber = streamReader.ReadLine();

                    ContactComboBox.Items.Add(contact.LastName);

                    Contacts.Add(contact); // add our new contact to the Contacts List
                }

                // cleanup
                streamReader.Close();

                ContactComboBox.SelectedIndex = 0;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ContactInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ContactComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = Contacts[ContactComboBox.SelectedIndex].FirstName;
            LastNameTextBox.Text = Contacts[ContactComboBox.SelectedIndex].LastName;
            EmailAddressTextBox.Text = Contacts[ContactComboBox.SelectedIndex].EmailAddress;
            ContactNumberTextBox.Text = Contacts[ContactComboBox.SelectedIndex].ContactNumber;
        }
    }
}
