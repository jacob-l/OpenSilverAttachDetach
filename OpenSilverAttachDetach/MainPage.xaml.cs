using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace OpenSilverAttachDetach
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Enter construction logic here...
        }

        public void OnAddClick(object sender, EventArgs args)
        {
            SP2.Children.Add(new TemplatedButton());
        }

        public void OnRemoveClick(object sender, EventArgs args)
        {
            SP2.Children.Remove(SP2.Children.Last());
        }
    }
}
