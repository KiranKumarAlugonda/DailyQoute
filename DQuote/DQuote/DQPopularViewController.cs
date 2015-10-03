using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace DQuote
{
	partial class DQPopularViewController : UIViewController
	{
		public DQPopularViewController (IntPtr handle) : base (handle)
		{
		}
        public override void ViewDidLoad ()
        {
            this.Title = "Popular Quotes";
        }
	}
}
