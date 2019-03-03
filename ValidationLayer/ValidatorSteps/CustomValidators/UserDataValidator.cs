using DataLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationLayer.Interfaces;

namespace ValidationLayer.Validators.CustomValidators
{
    internal class UserDataValidator : IValidatorStep<UserData>
    {
        bool IValidatorStep<UserData>.IsValid(UserData data, IList<InvalidProperty> errors)
        {
            if(data.Email == null || data.Email.Length <= 3)
                errors.Add(new InvalidProperty(nameof(data.Email), "Name must be 4+ length"));
            return errors.Count == 0;
        }
    }
}
