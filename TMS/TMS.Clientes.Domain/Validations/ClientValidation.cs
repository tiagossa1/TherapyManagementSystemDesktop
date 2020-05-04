﻿using FluentValidation;
using TMS.Client.Domain.Model;

namespace TMS.Client.Domain.Validations
{
    public abstract class ClientValidation<T> : AbstractValidator<T> where T : ClientModel
    {
        protected void ValidateName()
        {
            RuleFor(c => c.FirstName)
                .NotNull().WithMessage("Please ensure you have entered the First Name")
                .NotEmpty().WithMessage("Please ensure you have entered the First Name");
        }
        protected void ValidateLastName()
        {
            RuleFor(c => c.LastName)
                            .NotNull().WithMessage("Please ensure you have entered the Last Name")
                            .NotEmpty().WithMessage("Please ensure you have entered the Last Name");
        }
        protected void ValidateAddress()
        {
            RuleFor(c => c.Address)
                            .NotNull().WithMessage("Please ensure you have entered the Address")
                            .NotEmpty().WithMessage("Please ensure you have entered the Address");
        }
        protected void ValidateJobTitle()
        {
            RuleFor(c => c.JobTitle)
                            .NotNull().WithMessage("Please ensure you have entered the JobTitle")
                            .NotEmpty().WithMessage("Please ensure you have entered the JobTitle");
        }
        protected void ValidateEmail()
        {
            RuleFor(c => c.Email)
                .NotNull().WithMessage("Please ensure you have entered the Email")
                .NotEmpty().WithMessage("Please ensure you have entered the Email")
                .EmailAddress();
        }
        protected void ValidateNif()
        {
            RuleFor(c => c.NIF)
                .Must(x => x.ToString().Length == 9).WithMessage("Please ensure you have entered the Nif");
        }
        protected void ValidatePhoneNumber()
        {
            RuleFor(c => c.PhoneNumber)
                .Must(x => x.ToString().Length == 9).WithMessage("Please ensure you have entered the Phone Number");
        }
    }
}