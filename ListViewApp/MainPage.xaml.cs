using MAUI.ViewModels;
using System.Collections.ObjectModel;

namespace ListViewApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public ObservableCollection<DeviceViewModel> Devices { get; set; } = new ObservableCollection<DeviceViewModel>();

        public MainPage()
        {
            InitializeComponent();
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Dispatcher.Dispatch(() =>
                {

                    Devices.Clear();

                    Devices.Add(new DeviceViewModel(new MAUI.Models.Device(Guid.NewGuid(), "Some Samsung Device", MAUI.Shared.Models.DevicePlatformOwner.Google), null, null, false));
                    Devices.Add(new DeviceViewModel(new MAUI.Models.Device(Guid.NewGuid(), "Some Apple Device", MAUI.Shared.Models.DevicePlatformOwner.Apple), null, null, false));
                    Devices.Add(new DeviceViewModel(new MAUI.Models.Device(Guid.NewGuid(), "Microsoft", MAUI.Shared.Models.DevicePlatformOwner.Microsoft), null, null, false));
                    Devices.Add(new DeviceViewModel(new MAUI.Models.Device(Guid.NewGuid(), "Some Samsung Device", MAUI.Shared.Models.DevicePlatformOwner.Google), null, null, false));
                    Devices.Add(new DeviceViewModel(new MAUI.Models.Device(Guid.NewGuid(), "Some Samsung Device", MAUI.Shared.Models.DevicePlatformOwner.Google), null, null, false));
                    Devices.Add(new DeviceViewModel(new MAUI.Models.Device(Guid.NewGuid(), "Some Apple Device", MAUI.Shared.Models.DevicePlatformOwner.Apple), null, null, false));
                    Devices.Add(new DeviceViewModel(new MAUI.Models.Device(Guid.NewGuid(), "Microsoft", MAUI.Shared.Models.DevicePlatformOwner.Microsoft), null, null, false));
                    Devices.Add(new DeviceViewModel(new MAUI.Models.Device(Guid.NewGuid(), "Some Samsung Device", MAUI.Shared.Models.DevicePlatformOwner.Google), null, null, false));
                });
            });
        }
    }

}
