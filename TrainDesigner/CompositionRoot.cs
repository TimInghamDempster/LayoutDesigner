using System.Collections.Generic;
using TrainDesigner.ToolViewModels;
using WPFUtils;

namespace TrainDesigner
{
    public class CompositionRoot
    {
        public ViewModelBase Compose()
        {
            return new MainWindowViewModel(
                new List<IToolViewModel>()
                {
                    new PathToolViewModel(),
                    new PathToolViewModel(),
                    new PathToolViewModel()
                });
        }
    }
}
