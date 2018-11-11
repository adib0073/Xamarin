using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using BigBangLibrary;

namespace BigBang
{
   
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button buttonPrev;
        Button buttonNext;
        TextView myTitle;
        ImageView myImage;
        TextView myContent;
        Character character;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            buttonPrev = FindViewById<Button>(Resource.Id.buttonPrev);
            buttonNext = FindViewById<Button>(Resource.Id.buttonNext);
            myTitle = FindViewById<TextView>(Resource.Id.myTitle);

            myImage = FindViewById<ImageView>(Resource.Id.myImage);
            myContent = FindViewById<TextView>(Resource.Id.myContent);

            buttonPrev.Click += ButtonPrev_Click;
            buttonNext.Click += ButtonNext_Click;

            character = new Character();
            character.MoveFirst();

        }

        private void ButtonNext_Click(object sender, System.EventArgs e)
        {
            character.MoveNext();
            updateUI();
            //myTitle.Text = "Next";
            //myContent.Text = "Leonard Hofstadter from the Big Bang Theory";
            //myImage.SetImageResource(Resource.Drawable.leonard);

        }

        private void ButtonPrev_Click(object sender, System.EventArgs e)
        {
            character.MovePrev();
            updateUI();
            //myTitle.Text = "Prev";
            //myContent.Text = "Sheldon Lee Cooper from TBBT";
            //myImage.SetImageResource(Resource.Drawable.sheldon);

        }
        private void updateUI()
        {
            myTitle.Text = character.Current.myTitle;
            myContent.Text = character.Current.myContent;
            myImage.SetImageResource(ImageHelper.ImageDrawable(character.Current.myImage));
            buttonPrev.Enabled = character.CanMovePrev;
            buttonNext.Enabled = character.CanMoveNext;
        }
    }
}