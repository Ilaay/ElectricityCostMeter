using ElectricityCostMeter.Core;

namespace ElectricityCostMeter.MVVM.ViewModel
{
	internal class MainViewModel : ObservableObject
	{

		public RelayCommand HomeViewCommand { get; set; }
		public RelayCommand DevicesViewCommand { get; set; }

		public HomeViewModel HomeVM { get; set; }
		public DevicesViewModel DevicesVM { get; set; }

		private object _currentView;

		public object CurrentView
		{
			get { return _currentView; }
			set
			{
				_currentView = value;
				OnPropertyChanged();
			}
		}

		public MainViewModel()
		{
			HomeVM = new HomeViewModel();
			DevicesVM = new DevicesViewModel();

			_currentView = HomeVM;

			HomeViewCommand = new RelayCommand(o =>
			{
				CurrentView = HomeVM;
			});

			DevicesViewCommand = new RelayCommand(o =>
			{
				CurrentView = DevicesVM;
			});
		}
	}
}
