﻿using System;
using FluentValidation;
using Weapsy.Domain.Languages.Commands;
using Weapsy.Domain.Languages.Rules;
using Weapsy.Domain.Sites.Rules;

namespace Weapsy.Domain.Languages.Validators
{
    public class CreateLanguageValidator : LanguageDetailsValidator<CreateLanguage>
    {
        private readonly ILanguageRules _languageRules;

        public CreateLanguageValidator(ILanguageRules languageRules, ISiteRules siteRules)
            : base(languageRules, siteRules)
        {
            _languageRules = languageRules;

            RuleFor(c => c.Id)
                .NotEmpty().WithMessage("Id is required.")
                .Must(HaveUniqueId).WithMessage("A language with the same id already exists.");
        }

        private bool HaveUniqueId(Guid id)
        {
            return _languageRules.IsLanguageIdUnique(id);
        }
    }
}
