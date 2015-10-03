using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace DQuote
{
	partial class DQLoginViewController : UIViewController
	{
		public DQLoginViewController (IntPtr handle) : base (handle)
		{
		}
        public override void ViewDidLoad ()
        {
            this.Title = "Log In";
        }
	}
}
