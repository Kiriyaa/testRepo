using Class_2_Demo.Models;
using CommunityToolkit.Mvvm.Input;

namespace Class_2_Demo.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}