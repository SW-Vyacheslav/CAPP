namespace CAPP.UI.Models
{
    public class Size
    {
        public string Name { get; set; } = string.Empty;

        public double Value { get; set; }

        public override string ToString()
        {
            return $"{Name} = {Value}";
        }
    }
}