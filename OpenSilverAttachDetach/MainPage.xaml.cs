using CSHTML5.Internal;
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

            Experiment.Unloaded += Experiment_Unloaded;
            TextBlock1.Unloaded += TextBlock1_Unloaded;
        }

        public void OnAddClick(object sender, EventArgs args)
        {
            SP2.Children.Add(new TemplatedButton());
        }

        public void OnRemoveClick(object sender, EventArgs args)
        {
            SP2.Children.Remove(SP2.Children.Last());
        }

        private void TextBlock1_Unloaded(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("TextBlock1 UNLOADED!");
        }

        private void Experiment_Unloaded(object sender, RoutedEventArgs e)
        {
            SpInside.Children.Add(new TextBlock());
        }

        private void OnClick(object sender, EventArgs e)
        {
            SP.Children.Remove(Experiment);
        }
    }
}
