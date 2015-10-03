using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace DQuote
{
	partial class DQCategoryViewController : UIViewController
	{
		public DQCategoryViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad ()
        {
            this.Title = "Categories";
        }
	}
}
