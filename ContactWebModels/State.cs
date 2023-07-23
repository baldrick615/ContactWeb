using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactWebModels
{
    public class State
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name of State is required")]
        [Display(Name = "State")]
        [StringLength(ContactManagerConstants.MAX_STATE_NAME_LENGTH)]
        public string Name { get; set; }

        [StringLength(ContactManagerConstants.MAX_STATE_ABBR_LENGTH)]
        [Required(ErrorMessage = "State Abbreviation is required.")]
        public string Abbreviation { get; set; }

    }
}
