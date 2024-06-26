﻿using FluentValidation;
using Tempo.Knight.Dto.Requests.Knight;

namespace Tempo.Knight.Application.Validations.Knight
{
    public class CombatTrainingKnightValidator : AbstractValidator<RequestTrainingKnight>
    {
        /// <summary>
        /// Rules basic for validation Knight
        /// </summary>
        public CombatTrainingKnightValidator()
        {
            RuleFor(x => x.CombatTraining)
                .LessThan(10).WithMessage("Point must be more than 0")
                .NotNull()
                .NotEmpty();
            RuleFor(x => x.CombatTraining)
                .GreaterThan(0).WithMessage("Point must be less than 10")
                .NotNull()
                .NotEmpty();


        }

    }
}
