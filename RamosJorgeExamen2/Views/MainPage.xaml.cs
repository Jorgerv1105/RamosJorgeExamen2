using RamosJorgeExamen2.Views;

namespace RamosJorgeExamen2
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }


        private void Chistes_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Chistes());

        }

        private void About_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new About());

        }
    }

}
