using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUI.ViewModels
{
    public class DeviceViewModel
    {
        public DeviceViewModel(Models.Device device, ICommand removeCommand, ICommand testCommand, bool isNotThisDevice)
        {
            Device = device;
            RemoveCommand = removeCommand;
            TestCommand = testCommand;
            IsNotThisDevice = isNotThisDevice;
        }

        public bool IsNotThisDevice { get; set; }

        public Models.Device Device { get; set; }

        public ICommand RemoveCommand { get; set; }

        public ICommand TestCommand { get; set; }
    }
}
