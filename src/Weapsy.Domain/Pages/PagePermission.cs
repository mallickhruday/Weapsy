﻿using System;
using Weapsy.Core.Domain;

namespace Weapsy.Domain.Pages
{
    public class PagePermission : ValueObject
    {
        public Guid PageId { get; set; }  
        public PermissionType Type { get; set; }
        public string RoleId { get; set; }
    }
}
