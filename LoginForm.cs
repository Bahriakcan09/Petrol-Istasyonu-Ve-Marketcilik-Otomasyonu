using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;

namespace Petrol_Istasyonu_Ve_Marketcilik_Otomasyonu
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            if (!internetCheckClass.internetCheck())
            {
                MessageBox.Show("Internet Baglantısı Yok.");
                return;
            };
            bool login = await loginAsync();
            if (login)
            {
                MessageBox.Show("Giris Basarili");
            }
            else
            {
                MessageBox.Show("Giris Basarisiz");
            }
        }
        private async Task<bool> loginAsync()
        {
            object userCredential;
            var config = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyBPP5gvm8JvBT43dAsqUYlOXxy_GUcMyAU",
                AuthDomain = "petrol-ve-marketcilik.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                    new GoogleProvider().AddScopes("email"),
                    new EmailProvider()

                },
            };

            var client = new FirebaseAuthClient(config);
            try
            {
                 userCredential = await client.SignInWithEmailAndPasswordAsync(usernameTxt.Text, passwordTxt.Text);
            }
            catch (Exception)
            {
                return false;
            }
            return userCredential != null;

        }
    }
    
}
