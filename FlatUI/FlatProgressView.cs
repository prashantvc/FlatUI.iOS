using System;
using MonoTouch.UIKit;
using System.Drawing;

namespace FlatUI
{
	public class FlatProgressView:UIProgressView
	{
		public FlatProgressView (IntPtr handle):base(handle)
		{
			Flatten ();	
		}

		public FlatProgressView (RectangleF frame) : base(frame)
		{
			Flatten ();
		}

		UIColor progressColor = FlatColors.WisteriaColor;
		UIColor ProgressColor {
			get {
				return progressColor;
			}
			set {
				progressColor = value;
				Flatten ();
			}
		}

		UIColor trackColor = FlatColors.SilverColor;
		UIColor TrackColor {
			get {
				return trackColor;
			}
			set {
				trackColor = value;
				Flatten ();
			}
		}

		void Flatten()
		{
			UIImage progressImage = ImageHelper.ImageWithColor (ProgressColor, 4f);
			UIImage trackImage = ImageHelper.ImageWithColor (TrackColor, 4f);

			TrackImage = trackImage.WithMinimumSize(new SizeF(10,10));
			ProgressImage = progressImage;
		}
	}
}

