using MAUI.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI.Models
{
    public class Device
    {
        public Device(Guid id, string deviceName, DevicePlatformOwner devicePlatform)
        {
            Id = id;
            DeviceName = deviceName;
            DevicePlatform = devicePlatform;
        }

        public Guid Id { get; set; }

        public string DeviceName { get; set;}

        public DevicePlatformOwner DevicePlatform { get; set; }
    }
}
