﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidation : AbstractValidator<Brand>
    {
        public BrandValidation()
        {
            RuleFor(b => b.BrandName).NotEmpty();
        }
    }
}
