using Android.App;
using Android.OS;
using Com.Airbnb.Lottie;

namespace demo
{
	[Activity (Label = "demo", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		private LottieAnimationView animationView;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.Main);
			this.animationView = FindViewById<LottieAnimationView> (Resource.Id.animation_view);
		}
		protected override void OnStop ()
		{
			base.OnStop ();
			this.animationView.CancelAnimation ();
		}

		protected override void OnStart ()
		{
			base.OnStart ();
			this.animationView.Progress = 0f;
			this.animationView.PlayAnimation ();
		}
	}
}

