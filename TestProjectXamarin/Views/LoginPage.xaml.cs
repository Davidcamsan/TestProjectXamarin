using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectXamarin.Models;

using Xamarin.Forms;

namespace TestProjectXamarin.Views
{
    public partial class LoginPage : ContentPage
    {
        public async void SignInProcedure(object sender, System.EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
           
            if(user.CheckInformation())
            {
                await DisplayAlert("Login", "Log In Successful", "Ok");
                App.UserDatabase.SaveUser(user);
            }
            else
            {
                await DisplayAlert("Login", "Log Not Succesful, empty Username or Password", "Ok");
            }
        }


        void Init(){
            BackgroundColor = Constants.BackgroundColor;
            Lb1_Username.TextColor = Constants.MainTextColor;
            Lb1_Password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
           // LogInIcon.HeightRequest = Constants.LogInIconHeight;

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedure(s, e);
                            
        }

        public LoginPage()
        {
            InitializeComponent();
            Init();
        }
    }
}
