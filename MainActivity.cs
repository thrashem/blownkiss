using Android.App;
using Android.OS;
using Android.Widget;

namespace blownkiss;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.activity_main);

        // 参照
        var welcomeMessage = FindViewById<TextView>(Resource.Id.welcome_message);
        var completeButton = FindViewById<Button>(Resource.Id.complete_button);
        var sampleImage = FindViewById<ImageView>(Resource.Id.sample_image);

        // ボタンクリックで画像を表示、メッセージとボタンを非表示
        completeButton!.Click += (sender, args) =>
        {
            sampleImage!.SetImageResource(Resource.Drawable.sample_image);
            sampleImage!.Visibility = Android.Views.ViewStates.Visible;
            welcomeMessage!.Visibility = Android.Views.ViewStates.Gone;
            completeButton!.Visibility = Android.Views.ViewStates.Gone;
        };

        // 画像タップでアプリ終了
        sampleImage!.Click += (sender, args) =>
        {
            Finish();
        };
    }
}