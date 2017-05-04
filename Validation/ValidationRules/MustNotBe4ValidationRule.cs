using System.Globalization;
using System.Windows.Controls;

namespace Validation.ValidationRules
{
    public class MustNotBe4ValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var text = value as string;

            if (int.TryParse(text, out int zahl))
            {
                return zahl == 4 ?
                        new ValidationResult(isValid: false, errorContent: "Value must not be 4!") :
                        ValidationResult.ValidResult;
            }

            return new ValidationResult(false, "Could not be convertet.");
        }
    }
}
