using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using eShopOnContainers.Core.Interfaces;
using eShopOnContainers.Droid.Interfaces;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroAuth))]
namespace eShopOnContainers.Droid.Interfaces
{
    public class AndroAuth : IFirebase
    {
        public async Task<string> Login(string email, string password)
        {
            try
            {
                var user = await FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(email, password);
                var token = await user.User.GetTokenAsync(false);
                return token.Token;
            }
            catch (FirebaseAuthInvalidCredentialsException notFound)
            {
                return notFound.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public async Task<string> Register(string email, string password)
        {
            try
            {
                var user = await FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(email, password);
                var token = await user.User.GetTokenAsync(false);
                return token.Token;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}