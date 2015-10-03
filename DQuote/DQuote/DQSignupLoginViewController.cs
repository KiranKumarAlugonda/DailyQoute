using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace DQuote
{
	partial class DQSignupLoginViewController : UIViewController
	{
		public DQSignupLoginViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad ()
        {
            this.Title = "Sign Up";
        }
	}
}
