using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace DQuote
{
	partial class DQTabViewController : UITabBarController
	{
		public DQTabViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad ()
        {
            this.Title ="Categories";
        }
	}
}
