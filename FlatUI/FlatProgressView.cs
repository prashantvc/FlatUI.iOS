using System;
using MonoTouch.UIKit;
using System.Drawing;

namespace FlatUI
{
	public static class FlatProgressView
	{
		public static void Flatten(this UIProgressView progressView, UIColor trackColor, UIColor progressColor)
		{
			UIImage progressImage = ImageHelper.ImageWithColor (progressColor, 4f);
			UIImage trackImage = ImageHelper.ImageWithColor (trackColor, 4f);

			progressView.TrackImage = trackImage.WithMinimumSize(new SizeF(10,10));
			progressView.ProgressImage = progressImage;
		}
	}
}

