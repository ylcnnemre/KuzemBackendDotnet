using FluentValidation;
using KuzemBackendDotnet.Application.Features.Commands.Semester.CreateSemester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzemBackendDotnet.Application.Validators
{
    public class CreateSemesterValidator:AbstractValidator<CreateSemesterCommandRequest>
    {
        public CreateSemesterValidator()
        {
            RuleFor(item => item.name).NotEmpty().NotNull().WithMessage("Bu alan boş geçilemez").WithMessage("Name must be a string.").MinimumLength(3).MaximumLength(50);
            RuleFor(item => item.description).NotEmpty().NotNull().WithMessage("Bu alan boş geçilemez").WithMessage("Name must be a string.").MinimumLength(3).MaximumLength(200);
            RuleFor(item => item.year).NotEmpty().WithMessage("Bu alan boş geçilemez").GreaterThanOrEqualTo(2024).WithMessage("Yıl 2024 den ileri olmalı");
            RuleFor(item => item.period).NotEmpty().MinimumLength(3).MaximumLength(50);
            RuleFor(item => item.active).NotNull();
        }

    }
}
