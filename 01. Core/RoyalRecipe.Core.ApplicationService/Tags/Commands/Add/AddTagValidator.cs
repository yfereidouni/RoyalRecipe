using FluentValidation;

namespace RoyalRecipe.Core.ApplicationServices.Tags.Commands.Add
{
    public class AddTagValidator : AbstractValidator<AddTagCommand>
    {
        public AddTagValidator()
        {
            RuleFor(c=>c.Title).NotEmpty().WithMessage("برای عنوان تگ عنوان الزامی است.")
                .MaximumLength(50).WithMessage("طول ورودی برای تگ حداکثر 50 کاراکتر میباشد.");

        }
    }
}
