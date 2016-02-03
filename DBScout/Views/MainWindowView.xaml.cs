﻿using System.Windows;
using System.Windows.Controls.Primitives;
using DBScout.Contracts;
using DBScout.DatabaseSettings.Views;
using DBScout.StructurePreview.Views;
using Microsoft.Practices.Unity;
using Prism.Regions;

namespace DBScout.Views
{
    /// <summary>
    /// Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        public MainWindowView(IUnityContainer container)
        {
            InitializeComponent();
  }
    }
}
