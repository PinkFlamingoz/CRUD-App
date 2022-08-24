using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace CRUD_App.Presenter.Common
{
    public class DataValidation
    {
        public void validate(object model)
        {
            string errorMessage = "";
            List<ValidationResult> result = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, context, result, true);
            if (isValid == false)
            {
                foreach (var item in result)
                {
                    errorMessage += item.ErrorMessage + " \n ";
                }
                throw new Exception(errorMessage);
            }
        }
    }
}
