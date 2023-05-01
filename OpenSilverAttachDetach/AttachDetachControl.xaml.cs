using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace OpenSilverAttachDetach
{
    public partial class AttachDetachControl : UserControl
    {
        public AttachDetachControl()
        {
            this.InitializeComponent();
        }

        public override void INTERNAL_AttachToDomEvents()
        {
            base.INTERNAL_AttachToDomEvents();
            Console.WriteLine("INTERNAL_AttachToDomEvents");
        }

        public override void INTERNAL_DetachFromDomEvents()
        {
            base.INTERNAL_DetachFromDomEvents();
            Console.WriteLine("INTERNAL_DetachFromDomEvents");
        }
    }
}
