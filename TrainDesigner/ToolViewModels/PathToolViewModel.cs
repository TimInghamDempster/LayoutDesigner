using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFUtils;

namespace TrainDesigner.ToolViewModels
{
    class PathToolViewModel : IToolViewModel
    {
        public string Name => "New Path";

        public string ImageSource => "Images/PathButton.png";

        public ICommand ToolCommand => new MyCommand();
    }
}
