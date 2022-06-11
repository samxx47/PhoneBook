using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBook.Models;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhoneBook
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddNewContact : ContentPage
    {
        public AddNewContact()
        {
            InitializeComponent();
        }

        private void createButton_Clicked(object sender, EventArgs e)
        {
            bool isNameEmpty = string.IsNullOrEmpty(nameEntry.Text);
            bool isNumberEmpty = string.IsNullOrEmpty(phonenumberEntry.Text);
            if (isNameEmpty || isNumberEmpty)
            {
                DisplayAlert("Error", "Please Enter Details", "OK");


            }
            else
            {
                Post post = new Post()
                {
                    Name = nameEntry.Text,
                    PhoneNumber = phonenumberEntry.Text
                };

                using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
                {
                    conn.CreateTable<Post>();
                    int rows = conn.Insert(post);
                    if (rows > 0)
                    {
                        DisplayAlert("Created", "Contact succesfullt created", "OK");
                    }
                    else
                    {
                        DisplayAlert("Failure", "Contact failed to create", "OK");
                    }
                }
                nameEntry.Text = string.Empty;
                phonenumberEntry.Text= string.Empty;
            }

        }
    }
}