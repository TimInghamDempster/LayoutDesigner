using System;
using System.Collections.Generic;
using WPFUtils;

namespace TrainDesigner
{
    class MainWindowViewModel : ViewModelBase
    {
        public IEnumerable<IToolViewModel> Tools { get; private set; }

        public MainWindowViewModel(
            IEnumerable<IToolViewModel> tools)
        {
            Tools = tools ??
                throw new ArgumentNullException(nameof(tools));
        }
    }
}
