using FluentValidation;
using LightingService.Application.Requests;

namespace LightingService.API.Validators
{
    public class TestRequest2Validator : AbstractValidator<TestRequest2>
    {
        public TestRequest2Validator()
        {
            //Console.WriteLine($"TestRequest2Validator constructor called at {DateTime.Now}");
            RuleFor(x => x.Id).LessThan(0).WithMessage("Id should be less than 0");
        }
    }
}
