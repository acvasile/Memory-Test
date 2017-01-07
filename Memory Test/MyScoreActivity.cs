using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Text;
using Android.Text.Style;
using Android.Graphics;

namespace Memory_Test
{
    [Activity(Label = "MyScoreActivity", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait, Icon = "@drawable/ic_launcher")]
    public class MyScoreActivity : Activity
    {
        private int maxScore = 0;
        private int mediumScore = 0;
        private TextView txtBestScore;
        private TextView txtMediumScore;
        private TextView txtMemoryDescription;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            this.RequestWindowFeature(WindowFeatures.NoTitle);
            
            SetContentView(Resource.Layout.MyScores);

            txtBestScore = (TextView) FindViewById<TextView>(Resource.Id.txtBestScore);
            txtMediumScore = FindViewById<TextView>(Resource.Id.txtMediumScore);
            txtMemoryDescription = FindViewById<TextView>(Resource.Id.txtMemoryDescription);

            //String bestScoreText = "<![CDATA[<p><font color='#CBCBCB'>BEST SCORE</font> <font color='#FFFFFF'>3211</font></p> ]]>";
            //txtBestScore.SetText((Html.FromHtml((bestScoreText))));

            var bestScoreString = "BEST SCORE " + 0;
            var spanBestScore = new SpannableString(bestScoreString);

            spanBestScore.SetSpan(new ForegroundColorSpan(Color.Rgb(203,203,203)), 0, 10, 0);
            spanBestScore.SetSpan(new ForegroundColorSpan(Color.Rgb(255,255,255)), 11, bestScoreString.Length, 0);
            spanBestScore.SetSpan(new StyleSpan(TypefaceStyle.Normal), 0, 10, 0);
            spanBestScore.SetSpan(new StyleSpan(TypefaceStyle.Bold), 11, bestScoreString.Length, 0);
            txtBestScore.SetText(spanBestScore, TextView.BufferType.Spannable);

            var mediumScoreString = "MEDIUM SCORE " + 0;
            var spanMediumScore = new SpannableString(mediumScoreString);

            spanMediumScore.SetSpan(new ForegroundColorSpan(Color.Rgb(203, 203, 203)), 0, 12, 0);
            spanMediumScore.SetSpan(new ForegroundColorSpan(Color.Rgb(255, 255, 255)), 13, mediumScoreString.Length, 0);
            spanMediumScore.SetSpan(new StyleSpan(TypefaceStyle.Normal), 0, 12, 0);
            spanMediumScore.SetSpan(new StyleSpan(TypefaceStyle.Bold), 13, mediumScoreString.Length, 0);
            txtMediumScore.SetText(spanMediumScore, TextView.BufferType.Spannable);

            txtMemoryDescription.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc sit amet purus pellentesque, vulputate tellus vitae, posuere nisl. Vivamus volutpat facilisis feugiat. Aliquam id dignissim purus. Cras ut iaculis tortor, ac dignissim diam. Aliquam varius, eros mattis placerat consequat, elit ligula lacinia mi, quis tincidunt orci enim quis risus. Cras pharetra diam felis, nec semper ipsum placerat nec. Phasellus feugiat at neque ac aliquet. Sed hendrerit, tellus a ultricies iaculis, orci odio ornare arcu, molestie lacinia risus orci non magna. Mauris auctor ut ante eu porttitor. Ut nunc elit, vehicula a tempus quis, commodo vel quam. Sed scelerisque, dolor ut tempus auctor, lorem massa suscipit dolor, accumsan tincidunt lectus metus nec massa.";
        }
    }
}