using System;
using MonoTouch.UIKit;
using System.Drawing;

namespace FlatUI
{
	public class FlatProgressView:UIProgressView
	{
		public FlatProgressView (IntPtr handle):base(handle)
		{
			ConfigureProgressView ();	
		}

		public FlatProgressView (RectangleF frame) : base(frame)
		{
			ConfigureProgressView ();
		}

		UIColor progressColor = FlatColors.WisteriaColor;

		UIColor ProgressColor {
			get {
				return progressColor;
			}
			set {
				progressColor = value;
				ConfigureProgressView ();
			}
		}

		UIColor trackColor = FlatColors.SilverColor;

		UIColor TrackColor {
			get {
				return trackColor;
			}
			set {
				trackColor = value;
				ConfigureProgressView ();
			}
		}

		void ConfigureProgressView ()
		{
			UIImage progressImage = ImageHelper.ImageWithColor (ProgressColor, 4f);
			UIImage trackImage = ImageHelper.ImageWithColor (TrackColor, 4f);

			TrackImage = trackImage.WithMinimumSize (
				10, 10);
			ProgressImage = progressImage;
		}
	}
}

