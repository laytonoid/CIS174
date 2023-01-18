namespace Responsive.Models
{
    public class ResponsiveModel
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }

        public string CalculateAge()
        {
            int currentYear = 2023;
            string age = Convert.ToString(currentYear - BirthYear);
            string finalValue = Name + " is " + age + ".";
            return finalValue;
        }
    }
}