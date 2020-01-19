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
        private Button _btCodigoSeguridad;
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
            _btCodigoSeguridad = FindViewById<Button>(Resource.Id.btCodigoSeguridad);

            _buttonChangeName.Click += ChangeNameClick;
            _btCodigoSeguridad.Click += NavigateCodigoSeguridad;
        }

        private void ChangeNameClick(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Ha Escrito..." + _textChangeName.Text, ToastLength.Long).Show();
        }

        private void NavigateCodigoSeguridad(object sender, EventArgs e)
        {
            Intent navigateIntent = new Intent(this, typeof(CodigoSeguridad));
            StartActivity(navigateIntent);
        }
    }
}