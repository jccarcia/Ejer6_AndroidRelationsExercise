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
    [Activity(Label = "datosPersona")]
    class DatosPersonaActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.content_main);

            AddBindForLayout();
        }

        private void AddBindForLayout()
        {

        }
    }
}