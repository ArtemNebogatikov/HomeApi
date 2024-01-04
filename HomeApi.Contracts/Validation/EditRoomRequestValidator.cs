using FluentValidation;
using HomeApi.Contracts.Models.Rooms;
using System.Linq;

namespace HomeApi.Contracts.Validation
{
    public class EditRoomRequestValidator : AbstractValidator<EditRoomRequest>
    {
        /// <summary>
        /// Метод, конструктор, устанавливающий правила
        /// </summary>
        public EditRoomRequestValidator()
        {
            RuleFor(x => x.NewVoltage).NotEmpty().InclusiveBetween(120, 220);
        }

        /// <summary>
        ///  Метод кастомной валидации для свойства location
        /// </summary>
    }
}
