using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace DQuote
{
	partial class DQLikesViewController : UIViewController
	{
		public DQLikesViewController (IntPtr handle) : base (handle)
		{
		}
        public override void ViewDidLoad ()
        {
            this.Title = "Your Likes";
        }
	}
}
