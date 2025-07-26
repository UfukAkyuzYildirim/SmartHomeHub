using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightingService.Application.Features.TableControl
{
    public class TableControlDownValidator : AbstractValidator<TableControlDownRequest>
    {
        public TableControlDownValidator()
        {
            RuleFor(x => x.Speed)
                .GreaterThan(0)
                .WithMessage("Id should be greater than 0");
            RuleFor(x => x.Speed)
                .LessThanOrEqualTo(100)
                .WithMessage("Id should be less than or equal to 100");
        }
    }
}
