namespace ElectricityCostMeter.MVVM.Model
{
	public class ElectricalDevice
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public int WorkingHours { get; set; }
		public float KW { get; set; }

		public ElectricalDevice(string name, string description, int workingHours, float kw)
		{
			Name = name;
			Description = description;
			WorkingHours = workingHours;
			KW = kw;
		}

		public float CalculateElectricityUsed()
		{
			return KW * WorkingHours;
		}
	}
}
