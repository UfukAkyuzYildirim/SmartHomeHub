using FluentValidation;
using LightingService.Application.Requests;

namespace LightingService.API.Validators
{
    public class TestRequestValidator:AbstractValidator<TestRequest>
    {
        public TestRequestValidator()
        {
            //Console.WriteLine($"TestRequestValidator constructor called at {DateTime.Now}");
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("Id should be greater than 0");
        }
    }
}
