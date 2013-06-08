using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using FlatUI;

namespace FlatUIExample
{
	public partial class FlatUIExampleViewController : UIViewController
	{
		public FlatUIExampleViewController () : base ("FlatUIExampleViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			View.BackgroundColor = UIColor.White;

			// Perform any additional setup after loading the view, typically from a nib.
			var button = new FlatButton (new RectangleF (50, 50, 250, 44));
			button.SetTitle ("SHOW ALERT");
			View.AddSubview (button);

			var progressView = new UIProgressView(new Rectangle(50, 150, 250, 20));
			progressView.Flatten (FlatColors.SilverColor, FlatColors.TurquoiseColor);
			progressView.Progress = .5f;
			View.AddSubview (progressView);
		}

	

	}
}

