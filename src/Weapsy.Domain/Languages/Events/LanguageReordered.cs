﻿using System;
using Weapsy.Core.Domain;

namespace Weapsy.Domain.Languages.Events
{
    public class LanguageReordered : Event
    {
        public Guid SiteId { get; set; }
        public int SortOrder { get; set; }
    }
}
