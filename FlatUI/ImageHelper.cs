using System;
using MonoTouch.UIKit;
using System.Drawing;

namespace FlatUI
{
	public sealed class ImageHelper
	{
		private ImageHelper ()
		{
		}

		public static UIImage ButtonImage (UIColor color, float cornerRadius, UIColor shadowColor, UIEdgeInsets shadowInsets)
		{

			UIImage topImage = ImageWithColor (color, cornerRadius);
			UIImage bottomImage = ImageWithColor (shadowColor, cornerRadius);

			float totalHeight = EdgeSizeFromCornerRadius (cornerRadius) + shadowInsets.Top + shadowInsets.Bottom;
			float totalWidth = EdgeSizeFromCornerRadius (cornerRadius) + shadowInsets.Left + shadowInsets.Right;
			float topWidth = EdgeSizeFromCornerRadius (cornerRadius);
			float topHeight = EdgeSizeFromCornerRadius (cornerRadius);
			RectangleF topRect = new RectangleF (shadowInsets.Left, shadowInsets.Top, topWidth, topHeight);
			RectangleF bottomRect = new RectangleF (0, 0, totalWidth, totalHeight);

			UIGraphics.BeginImageContextWithOptions (new SizeF (totalWidth, totalHeight), false, 0.0f);
			if (!RectangleF.Equals (bottomRect, topRect)) {
				bottomImage.Draw (bottomRect);
			}
			topImage.Draw (topRect);

			UIImage buttonImage = UIGraphics.GetImageFromCurrentImageContext ();

			UIEdgeInsets resizeableInsets = new UIEdgeInsets (cornerRadius + shadowInsets.Top,
			                                                  cornerRadius + shadowInsets.Left,
			                                                  cornerRadius + shadowInsets.Bottom,
			                                                  cornerRadius + shadowInsets.Right);
			return buttonImage.CreateResizableImage (resizeableInsets);
		}

		public static UIImage ImageWithColor (UIColor imageColor, float cornerRadius)
		{
			float minEdgeSize = EdgeSizeFromCornerRadius (cornerRadius);
			RectangleF rect = new RectangleF (0, 0, minEdgeSize, minEdgeSize);
			UIBezierPath roundedRect = UIBezierPath.FromRoundedRect (rect, cornerRadius);
			roundedRect.LineWidth = 0;
			UIGraphics.BeginImageContextWithOptions (rect.Size, false, 0.0f);
			imageColor.SetFill ();
			roundedRect.Fill ();
			roundedRect.Stroke ();
			roundedRect.AddClip ();
			UIImage image = UIGraphics.GetImageFromCurrentImageContext ();

			UIGraphics.EndImageContext ();

			return image.CreateResizableImage (new UIEdgeInsets (cornerRadius, cornerRadius, cornerRadius, cornerRadius));
		}

		public static float EdgeSizeFromCornerRadius (float cornerRadius)
		{
			return cornerRadius * 2 + 1;
		}
	}

	public static class UIImageExtensions
	{
		public static UIImage WithMinimumSize (this UIImage image, SizeF size)
		{
			var rect = new RectangleF (0, 0, size.Width, size.Height);
			UIGraphics.BeginImageContextWithOptions (size, false, 0.0f);
			image.Draw (rect);
			UIImage resizedImage = UIGraphics.GetImageFromCurrentImageContext ();

			return resizedImage.CreateResizableImage (new UIEdgeInsets (size.Height / 2, size.Width / 2, size.Height / 2, size.Width / 2));

		}
	}
}

