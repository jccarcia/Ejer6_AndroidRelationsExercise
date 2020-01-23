using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Ejer6_AndroidRelations.Resources
{
    [Activity(Label = "CodigoSeguridad")]
    class CodigoSeguridad : Activity
    {
        private Button _bt1;
        private Button _bt2;
        private Button _bt3;
        private Button _bt4;
        private Button _bt5;
        private Button _bt6;
        private Button _bt7;
        private Button _bt8;
        private Button _bt9;
        private Button _bt0;
        private Button _btComprobar;
        private TextView _textViewPass;
        private bool acceso = false;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.codigoSeguridad);

            AddBindForLayout();
        }

        private void AddBindForLayout()
        {
            _bt1 = FindViewById<Button>(Resource.Id.bt1);
            _bt2 = FindViewById<Button>(Resource.Id.bt2);
            _bt3 = FindViewById<Button>(Resource.Id.bt3);
            _bt4 = FindViewById<Button>(Resource.Id.bt4);
            _bt5 = FindViewById<Button>(Resource.Id.bt5);
            _bt6 = FindViewById<Button>(Resource.Id.bt6);
            _bt7 = FindViewById<Button>(Resource.Id.bt7);
            _bt8 = FindViewById<Button>(Resource.Id.bt8);
            _bt9 = FindViewById<Button>(Resource.Id.bt9);
            _bt0 = FindViewById<Button>(Resource.Id.bt0);
            _btComprobar = FindViewById<Button>(Resource.Id.btComprobar);
            _textViewPass = FindViewById<TextView>(Resource.Id.textViewPass);

            _bt1.Click += buttonNumber1;
            _bt2.Click += buttonNumber2;
            _bt3.Click += buttonNumber3;
            _bt4.Click += buttonNumber4;
            _bt5.Click += buttonNumber5;
            _bt6.Click += buttonNumber6;
            _bt7.Click += buttonNumber7;
            _bt8.Click += buttonNumber8;
            _bt9.Click += buttonNumber9;
            _bt0.Click += buttonNumber0;
            _btComprobar.Click += comprobarCodigo;
        }

        private void buttonNumber1(object sender, EventArgs e)
        {
            _textViewPass.Text += _bt1.Text;
        }

        private void buttonNumber2(object sender, EventArgs e)
        {
            _textViewPass.Text += _bt2.Text;
        }

        private void buttonNumber3(object sender, EventArgs e)
        {
            _textViewPass.Text += _bt3.Text;
        }

        private void buttonNumber4(object sender, EventArgs e)
        {
            _textViewPass.Text += _bt4.Text;
        }

        private void buttonNumber5(object sender, EventArgs e)
        {
            _textViewPass.Text += _bt5.Text;
        }

        private void buttonNumber6(object sender, EventArgs e)
        {
            _textViewPass.Text += _bt6.Text;
        }

        private void buttonNumber7(object sender, EventArgs e)
        {
            _textViewPass.Text += _bt7.Text;
        }

        private void buttonNumber8(object sender, EventArgs e)
        {
            _textViewPass.Text += _bt8.Text;
        }

        private void buttonNumber9(object sender, EventArgs e)
        {
            _textViewPass.Text += _bt9.Text;
        }

        private void buttonNumber0(object sender, EventArgs e)
        {
            _textViewPass.Text += _bt0.Text;
        }

        private void comprobarCodigo(object sender, EventArgs e)
        {
            if (acceso == false)
            {
                if (_textViewPass.Text == "1234")
                {
                    Intent navigateIntent = new Intent(this, typeof(DatosPersonaActivity));
                    StartActivity(navigateIntent);
                    acceso = true;
                }
                else
                {
                    Toast.MakeText(this, "Ha Escrito el codigo mal", ToastLength.Long).Show();
                }
            }
            else
            {
                Intent navigateIntent = new Intent(this, typeof(DatosPersonaActivity));
                StartActivity(navigateIntent);
            }
            
        }
    }
}