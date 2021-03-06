﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.App;

using Android.OS;
using Toolbar = Android.Support.V7.Widget.Toolbar;
namespace Ejer6_AndroidRelations
{
    class ContentActivity : AppCompatActivity
    {
        ViewPager viewpager;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //Set our view from the "main" layout resource
            SetContentView(Resource.Layout.lista);


            SupportActionBar.SetDisplayShowTitleEnabled(false);

            SetupViewPager(viewpager);

        }
        void SetupViewPager(ViewPager viewPager)
        {
            var adapter = new FragmentAdapter(SupportFragmentManager);
            adapter.AddFragment(new TabFragment1(), "Nombre");
            adapter.AddFragment(new TabFragment2(), "Listado");

            viewPager.Adapter = adapter;

            viewpager.Adapter.NotifyDataSetChanged();

            //viewpager.OffscreenPageLimit(4);
        }
    }
}