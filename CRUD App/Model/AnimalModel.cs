using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUD_App.Model
{
    public class AnimalModel
    {
        private int animalID;
        private string animalName;
        private string animalType;
        private string animalColor;
        private int animalAge;
        private string animalSex;
        private DateTime animalBirthDate;
        private string animalOwner;
        private string animalOwnerPhone;

        [DisplayName("Pet ID")]
        public int AnimalID { get { return animalID; } set { animalID = value; } }

        [DisplayName("Pet Name")]
        [Required(ErrorMessage = "Pet name is a must!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Pet name must be between 2 and 50 characters!")]
        public string AnimalName { get { return animalName; } set { animalName = value; } }

        [DisplayName("Pet Type")]
        [Required(ErrorMessage = "Pet type is a must!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Pet type must be between 2 and 50 characters!")]
        public string AnimalType { get { return animalType; } set { animalType = value; } }

        [DisplayName("Pet Color")]
        [Required(ErrorMessage = "Pet color is a must!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Pet color must be between 2 and 50 characters!")]
        public string AnimalColor { get { return animalColor; } set { animalColor = value; } }

        [DisplayName("Pet Age")]
        [Required(ErrorMessage = "Pet age is a must!")]
        [Range(1, 100, ErrorMessage = "Pet age must be between 1 and 100 characters!")]
        public int AnimalAge { get { return animalAge; } set { animalAge = value; } }

        [DisplayName("Pet Sex")]
        [Required(ErrorMessage = "Pet sex is a must!")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "Pet sex must be between 1 letter m or f!")]
        public string AnimalSex { get { return animalSex; } set { animalSex = value; } }

        [DisplayName("Pet Birth Date")]
        [Required(ErrorMessage = "Pet Birthday is a must!")]
        public DateTime AnimalBirthDate { get { return animalBirthDate; } set { animalBirthDate = value; } }

        [DisplayName("Pet Owner")]
        [Required(ErrorMessage = "Pet Owner is a must!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "The pets owner name must be between 2 and 50 characters!")]
        public string AnimalOwner { get { return animalOwner; } set { animalOwner = value; } }

        [DisplayName("Pet Owner Phone")]
        [Required(ErrorMessage = "Owner phone is a must! How are you gonna contact them if not?")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "The owners phonenumber must be between 2 and 20 characters!")]
        public string AnimalOwnerPhone { get { return animalOwnerPhone; } set { animalOwnerPhone = value; } }

    }
}
