using Android.App;
using Android.OS;
using Android.Media;
using WAHtton.Droid;
using Xamarin.Forms;
using Android.Util;

[assembly: Dependency(typeof(AudioService))]
namespace WAHtton.Droid
{
    [Activity(MainLauncher = true)]
    public class AudioService : Activity, IButtonClick
    {
        private MediaPlayer _mediaPlayer;

        public AudioService()
        {
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public void PlaySound()
        {
            if (_mediaPlayer != null)
                _mediaPlayer.Start();
        }

        public void StopSound()
        {
            if (_mediaPlayer != null)
                _mediaPlayer.Stop();
        }

        public void ButtonClicked()
        {
            _mediaPlayer = MediaPlayer.Create(Android.App.Application.Context,
                                              Resource.Raw.Fall2);
            PlaySound();

            Log.WriteLine(LogPriority.Debug, "WAH", "Pressed from Andoid device, WAH!");
        }
    }
}
