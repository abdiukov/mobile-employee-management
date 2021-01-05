using System;
using Xamarin.Forms;

namespace TodoASMX
{
    public partial class TodoItemPage : ContentPage
    {
        bool isNewItem;
        public TodoItemPage(string bckgroundcolor, bool isNew = false)
        {
            InitializeComponent();
            isNewItem = isNew;
            BackgroundColor = Color.FromHex(bckgroundcolor);
            //if the item getting added is new, the delete button will not be loaded.
            //delete button is not needed 
            delete_button.IsVisible = !isNew;

        }

        public TodoItemPage(string bckgroundcolor)
        {
            InitializeComponent();
            BackgroundColor = Color.FromHex(bckgroundcolor);
        }
        
       async void OnSaveActivated(object sender, EventArgs e)
        {
            //error_msg contains the error message
            string error_msg = "";


            //defining variables that are going to be used to check input
            //these variables extract their values from text boxes (entries)
            string Name = nameEntry.Text;
            string Phone = PhoneEntry.Text;
            string Department = DepartmentEntry.Text;
            string Street = StreetEntry.Text;
            string City = CityEntry.Text;
            string State = StateEntry.Text;
            string Country = CountryEntry.Text;
            string ZipCode = ZipCodeEntry.Text;

            //checking whether the input inside text boxes is correct.
            //displaying an appropriate message for each text box.
            // switch statement could be potentially used here

            if (Name == null || Name=="") 
            {
                error_msg = "Name field is empty. Please fill it in.";
            }
            else if (Phone == null || Phone=="" || Phone.Length > 20 || Phone.Length < 8)
            {
                error_msg = "Please enter a valid phone number. For example 0400-000-000";
            }
            else if (Street == null|| Street=="")
            {
                error_msg = "Street field is empty. Please fill it in.";
            }
            else if (City == null || City=="")
            {
                error_msg = "City field is empty. Please fill it in.";
            }
            else if (State == null)
            {
                error_msg = "State field is empty. Please fill it in.";
            }
            else if (ZipCode == null || ZipCode =="" || ZipCode.Length != 4 || !int.TryParse(ZipCode, out int unused_int2))
            {
                error_msg = "Zip Code has to contain 4 numbers. For example 2200";
            }
            else if (Department == null|| Department=="" || !int.TryParse(Department, out int unused_int))
            {
                error_msg = "Department field has to be a number. For example 1";
            }
            else if (Country == null || Country=="")
            {
                error_msg = "Country field is empty. Please fill it in.";
            }

            //if no errors were made, the changes are saved
            //the code checks whether the errors were made by checking that the error message is empty

            switch (error_msg.Length)
            {
                case 0:
                    bool confirm = await DisplayAlert("Confirmation", "You are about to save the changes. Do you wish to proceed?", "Yes", "No");
                    switch (confirm)
                    {
                        case true:
                            var todoItem = (TodoItem)BindingContext;
                            await App.TodoManager.SaveTodoItemAsync(todoItem, isNewItem);
                            await Navigation.PopAsync();
                            break;
                    }
                    break;
                default:
                    await DisplayAlert("Error.", error_msg, "OK");
                    break;
            }

        }

        async void OnDeleteActivated(object sender, EventArgs e)
        {
            //delete button does not display, unless an existing record was selected
            //therefore there is no need to check whether an item can be deleted (no need to use if statements)

            bool confirm = await DisplayAlert("Confirmation", "You are about to delete information about this employee. Do you wish to proceed?", "Yes", "No");
            switch (confirm)
            {
                case true:
                    var todoItem = (TodoItem)BindingContext;
                    await App.TodoManager.DeleteTodoItemAsync(todoItem);
                    await Navigation.PopAsync();
                    break;
            }
        }

        //navigates back to main menu
        async void OnCancelActivated(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}