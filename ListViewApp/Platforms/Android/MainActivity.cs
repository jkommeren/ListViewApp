using Android.App;
using Android.Content.PM;
using Android.OS;
using Microsoft.Extensions.Logging;

namespace ListViewApp
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        private ILogger<MainActivity>? _logger;

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            _logger = IPlatformApplication.Current.Services.GetService<ILogger<MainActivity>>();
        }

        protected override void OnStop()
        {
            base.OnStop();
            _logger.LogInformation(nameof(OnStop));
            
            // This triggers OnDestroy
            _logger.LogInformation("Finishing");
            Finish();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();

            _logger.LogInformation(nameof(OnDestroy));
        }
    }
}
