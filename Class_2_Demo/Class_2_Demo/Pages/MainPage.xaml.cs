using Class_2_Demo.Models;
using Class_2_Demo.PageModels;

namespace Class_2_Demo.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}