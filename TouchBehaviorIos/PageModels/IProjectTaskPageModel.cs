using CommunityToolkit.Mvvm.Input;
using TouchBehaviorIos.Models;

namespace TouchBehaviorIos.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}