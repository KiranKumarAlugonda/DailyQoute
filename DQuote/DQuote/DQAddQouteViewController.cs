using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace DQuote
{
	partial class DQAddQouteViewController : UIViewController
	{
		public DQAddQouteViewController (IntPtr handle) : base (handle)
		{
		}
        public override void ViewDidLoad ()
        {
            this.Title = "Add Qoute";
        }
	}
}
