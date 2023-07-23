using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;

namespace ContactWebModels
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is Required")]
        [StringLength(ContactManagerConstants.MAX_FIRST_NAME_LENGTH)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is Required")]
        [StringLength(ContactManagerConstants.MAX_LAST_NAME_LENGTH)]
        public string LastName { get; set; }

        [StringLength(ContactManagerConstants.MAX_EMAIL_LENGTH)]
        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [StringLength(ContactManagerConstants.MAX_PHONE_LENGTH)]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        [Display(Name = "Home Phone Number")]
        [Required(ErrorMessage = "Phone Number is required.")]
        public string PhonePrimary { get; set; }

        [Phone(ErrorMessage = "Invalid Phone Number")]
        [StringLength(ContactManagerConstants.MAX_PHONE_LENGTH)]
        [Required(ErrorMessage = "Mobile of Office Phone required.")]
        [Display(Name = "Mobile Phone")]
        public string PhoneSecondary { get; set; }


        [DataType(DataType.Date)]
        public DateType Birthday { get; set; }


        [Display(Name = "Street Address Line 1")]
        [StringLength(ContactManagerConstants.MAX_STREET_ADDRESS_LENGTH)]
        public string StreetAddress1 { get; set; }

        [Display(Name = "Street Address Line 2")]
        [StringLength(ContactManagerConstants.MAX_STREET_ADDRESS_LENGTH)]
        public string StreetAddress2 { get; set; }


        [StringLength(ContactManagerConstants.MAX_CITY_LENGTH)]
        [Required(ErrorMessage = "City is Required.")]
        public string City { get; set; }

        [Required(ErrorMessage = "State is Required")]
        public int StateId { get; set; }

        [StringLength(ContactManagerConstants.MAX_STATE_ABBR_LENGTH)]
        public virtual State State { get; set; }

        [Required(ErrorMessage = "The User ID is required to map contact to a User correctly")]
        public string UserId { get; set; }

        [Display(Name = "Full Name")]
        public string FriendlyName => $"{FirstName} {LastName}";

        [Required(ErrorMessage = "ZIP is Required")]
        [StringLength(ContactManagerConstants.MAX_ZIP_CODE_LENGTH, MinimumLength = ContactManagerConstants.MIN_ZIP_CODE_LENGTH)]
        [Display(Name = "Zip Code")]
        [RegularExpression("(^\\d{5}(-\\d{4})?$)|(^[ABCEGHJKLMNPRSTVXY]{1}\\d{1}[A-Z]{1} *\\d{1}[A-Z]{1}\\d{1}$)", ErrorMessage = "Zip Code is invalid.")]
        public string ZipCode { get; set; }

        [Display(Name = "Full Address")]
        public string FriendlyAddress => State is null
            ? ""
            : string.IsNullOrWhiteSpace(StreetAddress1)
                ? $"{City}, {State.Abbreviation}, {ZipCode}"
                : string.IsNullOrWhiteSpace(StreetAddress2)
                    ? $"{StreetAddress1}, {City}, {State.Abbreviation}, {ZipCode}"
                    : $"{StreetAddress1} - {StreetAddress2}, {City}, {State.Abbreviation}, {ZipCode}";

    }
}
