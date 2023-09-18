namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnImageButton1Clicked(object sender, EventArgs e)
        {
            imgBtn1.Source = "reality1.jfif";
        }
        private void OnImageButton2Clicked(object sender, EventArgs e)
        {
            imgBtn2.Source = "reality2.png";
        }
    }
}