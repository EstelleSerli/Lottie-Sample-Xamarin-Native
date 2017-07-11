using System;
using Airbnb.Lottie;
using UIKit;

namespace demoiOS
{
	public partial class ViewController : UIViewController
	{
		private LOTAnimationView lottieLogo;
		protected ViewController (IntPtr handle) : base (handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.lottieLogo = LOTAnimationView.AnimationNamed ("video_cam");
			this.lottieLogo.ContentMode = UIViewContentMode.ScaleAspectFill;
			this.lottieLogo.LoopAnimation = true;
			this.View.AddSubview (this.lottieLogo);
		}

		private void PlayLottieAnimation ()
		{
			this.lottieLogo.AnimationProgress = 0;
			this.lottieLogo.Play ();
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			this.lottieLogo.Play ();
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
			this.lottieLogo.Pause ();
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in us
		}
	}
}
