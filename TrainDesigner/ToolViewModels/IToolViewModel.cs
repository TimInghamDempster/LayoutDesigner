using System.Windows.Input;

namespace TrainDesigner
{
    interface IToolViewModel
    {
        string Name { get; }
        string ImageSource { get; }

        ICommand ToolCommand { get; }
    }
}
