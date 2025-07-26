using FluentValidation;


namespace LightingService.Application.Features.TableControl
{
    public class TableControlUpValidator: AbstractValidator<TableControlUpRequest>
    {
        public TableControlUpValidator() 
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
