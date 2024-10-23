//using Android.Animation;
//using Java.Util;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void sldRed_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var red = sldRed.Value;
            var green = sldGren.Value;
            var blue = sldBlue.Value;


            Color color = Color.FromRgb(red, green, blue);

            Setcolor(color);
        }
        private void Setcolor(Color color) 
        {
        btn.BackgroundColor = color;
        Container.BackgroundColor = color;
        lblHex.Text = color.ToHex();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            var random = new Random();
            var color = Color.FromRgb
                (random.Next(0, 256),
                random.Next(0, 256),
                random.Next(0, 256));
            Setcolor(color);
            sldRed.Value = color.Red;
            sldBlue.Value = color.Blue;
            sldRed.Value = color.Red;
        }
    }
}
