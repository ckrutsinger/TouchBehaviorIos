using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TouchBehaviorIos.PageModels
{
    public partial class MainPageModel : ObservableObject
    {
    

        public MainPageModel()
        {
        }

   


        [RelayCommand]
        private async Task LongPress()
        {
            await Shell.Current.DisplayAlert("Long Press", "Image was long pressed", "Close");
        }
  
    }
}