using Android.App;
using Android.Widget;
using Android.OS;

namespace Boodschappie
{
    [Activity(Label = "Boodschappie", MainLauncher = true)]
    public class MainActivity : Activity
    {

        Button button;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            button = FindViewById<Button>(Resource.Id.btnMaaltijd);

            button.Click += Button_Click;
            //private void configureNextButton() {
            //        Button nextButton = (Button)FindViewById(Resource.Id.btnMaaltijd);
            //        nextButton.SetOnClickListener(new View.OnClickListener()
            //            @Override
            //            public void onClick(View view());   
            //                StartActivity (new int)
            //}


        }


void Button_Click(object sender, System.EventArgs e)
        {
            SetContentView(Resource.Layout.layout1);
        }

    }
}
