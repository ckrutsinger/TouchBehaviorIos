using TouchBehaviorIos.Models;
using TouchBehaviorIos.PageModels;

namespace TouchBehaviorIos.Pages
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