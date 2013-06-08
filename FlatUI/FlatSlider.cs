using MonoTouch.UIKit;
using System.Drawing;

namespace FlatUI
{
	public class FlatSlider : UISlider
	{
		UIColor progressColor =FlatColors.Alizarin;
		UIColor trackColor  = FlatColors.Silver;
		UIColor highlightedThumbColor = FlatColors.Pomegranate;
		UIColor normalThumbColor = FlatColors.Pomegranate;

		public FlatSlider (RectangleF frame): base(frame)
		{
			ConfigureFlatSlider ();
		}

		UIColor HighlightedThumbColor {
			get {

				return highlightedThumbColor;
			}
			set {
				highlightedThumbColor = value;
				ConfigureFlatSlider ();
			}
		}

		UIColor NormalThumbColor {
			get {
				return normalThumbColor;
			}
			set {
				normalThumbColor = value;
				ConfigureFlatSlider ();
			}
		}

		UIColor TrackColor {
			get {
				return trackColor;
			}
			set {
				trackColor = value;
				ConfigureFlatSlider ();
			}
		}

		UIColor ProgressColor {
			get {
				return progressColor;
			}
			set {
				progressColor = value;
				ConfigureFlatSlider ();
			}
		}

		void ConfigureFlatSlider()
		{
			UIImage progressImage = ImageHelper.ImageWithColor (ProgressColor, 5f).WithMinimumSize (10, 10);
			UIImage trackImage = ImageHelper.ImageWithColor (TrackColor, 5f).WithMinimumSize (10, 10);

			SetMinTrackImage (progressImage, UIControlState.Normal);
			SetMaxTrackImage (trackImage, UIControlState.Normal);

			var thumbSize = new SizeF (24, 24);
			var normalSliderImage = ImageHelper.CircularImageWithColor (NormalThumbColor, thumbSize);
			SetThumbImage (normalSliderImage, UIControlState.Normal);

			var highlightedSliderImage = ImageHelper.CircularImageWithColor (HighlightedThumbColor, thumbSize);
			SetThumbImage (highlightedSliderImage, UIControlState.Highlighted);


		}
	}
}

