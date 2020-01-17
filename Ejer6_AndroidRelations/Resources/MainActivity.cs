using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Ejer6_AndroidRelations.Resources
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    class MainActivity : AppCompatActivity
    {
        private Button _buttonChangeName;
        private EditText _textChangeName;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.content_main);

            AddBindForLayout();
        }

        private void AddBindForLayout() 
        {
            _buttonChangeName = FindViewById<Button>(Resource.Id.buttonChangeName);
            _textChangeName = FindViewById<EditText>(Resource.Id.textChangeName);


            _buttonChangeName.Click += ChangeNameClick;
        }

        async void ChangeNameClick(object sender, EventArgs e)
        {
            //await DisplayAlert("Ha Escrito...", _textChangeName, "OK");
            Toast.MakeText(this, "Ha Escrito..." + _textChangeName.Text, ToastLength.Long).Show();
        }
    }
}