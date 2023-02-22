using ElectricityCostMeter.MVVM.Model;
using ElectricityCostMeter.Core;
using System.Collections.Generic;

namespace ElectricityCostMeter.MVVM.ViewModel
{
	internal class HomeViewModel
	{
		public RelayCommand AddDeviceCommand { get; set; }
		private List<ElectricalDevice> _devices = new List<ElectricalDevice>();

		public HomeViewModel()
		{
			AddDeviceCommand = new RelayCommand(o =>
			{
				_devices.Add(new ElectricalDevice("TestName", "", 1, 1));
			});
		}

	}
}
