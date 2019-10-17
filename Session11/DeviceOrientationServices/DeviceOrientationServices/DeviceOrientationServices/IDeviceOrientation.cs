using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceOrientationServices
{
    public enum DeviceOrientations
    {
        Undefined,
        Landscape,
        Portrait
    }

    public interface IDeviceOrientation
    {
        DeviceOrientations GetOrientation();
    }
}
