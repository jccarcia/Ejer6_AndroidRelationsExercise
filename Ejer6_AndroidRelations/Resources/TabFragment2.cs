﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Ejer6_AndroidRelations
{
    public class TabFragment2 : Android.Support.V4.App.Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            var v = inflater.Inflate(Resource.Layout.tab2, container, false);
            
            var milistview = v.FindViewById<ListView>(Resource.Id.listaTab2);
            
            ListViewAdapter adapter = new ListViewAdapter(this.Context, ServicioLista.Instance.MyList);
            milistview.Adapter = adapter;

            adapter.NotifyDataSetChanged();
            
            return v;

        }
    }
}