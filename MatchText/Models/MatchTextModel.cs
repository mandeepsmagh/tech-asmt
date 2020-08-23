using System.ComponentModel.DataAnnotations;

namespace MatchText.Models
{
    public class MatchTextModel
    {
        [Required(ErrorMessage = "Required field!")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage="Invalid input, allowed characters are : a-z, A-Z")]
        public string Text {get; set;}

        [Required(ErrorMessage = "Required field!")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage="Invalid input, allowed characters are: a-z, A-Z")]
        public string SubText {get; set;}
        public string Matches {get; set;}

    }
}