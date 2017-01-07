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
    [Activity(Label = "TestActivity", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait, Icon = "@drawable/ic_launcher")]
    public class TestActivity : Activity
    {
        private int level;
        private int combo;
        private int lives;
        private int score;

        private TextView txtTestLevel;
        private TextView txtYourLives;
        private TextView txtYourCombo;
        private TextView txtTestScore;
        private LinearLayout linearLayoutTest;

        private Button[] testButtons = new Button[16];
        private int[] pressedIndexes = new int[16];

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            this.RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.Test);

            lives = 3;
            combo = 1;
            level = 1;
            score = 0;
            txtTestLevel = FindViewById<TextView>(Resource.Id.txtTestLevel);
            txtYourLives = FindViewById<TextView>(Resource.Id.txtYourLives);
            txtYourCombo = FindViewById<TextView>(Resource.Id.txtYourCombo);
            txtTestScore = FindViewById<TextView>(Resource.Id.txtTestScore);

            for (int i = 0; i < 16; i++)
            {
                testButtons[i] = new Button(this.ApplicationContext);
            }

            setAllInfo();
            setTestThree();

        }

        private void setAllInfo()
        {
            this.setCurrentLevel();
            this.setCurrentLives();
            this.setCurrentCombo();
            this.setCurrentScore();
        }

        private void setCurrentLevel()
        {
            var currentString = "LEVEL " + level;
            var spanCurrentString = new SpannableString(currentString);

            spanCurrentString.SetSpan(new ForegroundColorSpan(Color.Rgb(203, 203, 203)), 0, 5, 0);
            spanCurrentString.SetSpan(new ForegroundColorSpan(Color.Rgb(255, 255, 255)), 6, currentString.Length, 0);
            spanCurrentString.SetSpan(new StyleSpan(TypefaceStyle.Normal), 0, 5, 0);
            spanCurrentString.SetSpan(new StyleSpan(TypefaceStyle.Bold), 6, currentString.Length, 0);
            txtTestLevel.SetText(spanCurrentString, TextView.BufferType.Spannable);
        }

        private void setCurrentLives()
        {
            var currentString = "LIVES " + lives;
            var spanCurrentString = new SpannableString(currentString);

            spanCurrentString.SetSpan(new ForegroundColorSpan(Color.Rgb(203, 203, 203)), 0, 5, 0);
            spanCurrentString.SetSpan(new ForegroundColorSpan(Color.Rgb(255, 255, 255)), 6, currentString.Length, 0);
            spanCurrentString.SetSpan(new StyleSpan(TypefaceStyle.Normal), 0, 5, 0);
            spanCurrentString.SetSpan(new StyleSpan(TypefaceStyle.Bold), 6, currentString.Length, 0);
            txtYourLives.SetText(spanCurrentString, TextView.BufferType.Spannable);
        }

        private void setCurrentCombo()
        {
            var currentString = "COMBO X" + combo;
            var spanCurrentString = new SpannableString(currentString);

            spanCurrentString.SetSpan(new ForegroundColorSpan(Color.Rgb(203, 203, 203)), 0, 5, 0);
            spanCurrentString.SetSpan(new ForegroundColorSpan(Color.Rgb(255, 255, 255)), 6, currentString.Length, 0);
            spanCurrentString.SetSpan(new StyleSpan(TypefaceStyle.Normal), 0, 5, 0);
            spanCurrentString.SetSpan(new StyleSpan(TypefaceStyle.Bold), 6, currentString.Length, 0);
            txtYourCombo.SetText(spanCurrentString, TextView.BufferType.Spannable);
        }

        private void setCurrentScore()
        {
            var currentString = score + " POINTS";
            var spanCurrentString = new SpannableString(currentString);

            spanCurrentString.SetSpan(new ForegroundColorSpan(Color.Rgb(203, 203, 203)), currentString.Length - 6, currentString.Length, 0);
            spanCurrentString.SetSpan(new ForegroundColorSpan(Color.Rgb(255, 255, 255)), 0, currentString.Length - 7, 0);
            spanCurrentString.SetSpan(new StyleSpan(TypefaceStyle.Normal), currentString.Length - 6, currentString.Length, 0);
            spanCurrentString.SetSpan(new StyleSpan(TypefaceStyle.Bold), 0, currentString.Length - 7, 0);
            txtTestScore.SetText(spanCurrentString, TextView.BufferType.Spannable);
        }
        
        private void setTestThree()
        {
            
        }

        private void setTestFour()
        {
            
        }

        private void resetPressedIndexes()
        {
            for (int i = 0; i < 16; i++)
            {
                pressedIndexes[i] = -1;
            }
        }
    }
}