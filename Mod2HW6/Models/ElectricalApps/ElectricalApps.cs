namespace Mod2HW6.Models.ElectricalApps
{
    public abstract class ElectricalApps
    {
        public string Name { get; init; }
        public int Power { get; init; }
        public double Weight { get; init; }
        public bool SwithedOn { get; set; }
        public ApplianceType ApplianceType { get; init; }
    }
}
