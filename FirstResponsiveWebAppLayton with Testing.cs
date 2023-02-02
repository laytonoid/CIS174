using System.ComponentModel.DataAnnotations;

namespace Responsive.Models
{
    public class ResponsiveModel
    {
        [Required(ErrorMessage = "Entry must be first and last name")]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage =
            "Entry must be first and last name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Birth year must be number between 1850 and 2100")]
        [Range(1850, 2100, ErrorMessage =
            "Birth year must be year between 1850 and 2100")]
        public int? BirthYear { get; set; }

        public string CalculateAge1(string name, int birth)
        {
            (string, int, int) person; 
            person.Item1 = name;
            person.Item2 = birth;
            person.Item3 = 2023 - birth;
            string finalValue = Convert.ToString(person.Item1 + " is " + person.Item3 + " this year.");
            return finalValue;
        }
    }
}