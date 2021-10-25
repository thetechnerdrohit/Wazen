﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.Application.Features.Roles.Commands.CreateRole
{
    public class CreateRoleDto
    {
        public Guid ID { get; set; }
        public string RoleName { get; set; }
        public string RoleArabicName { get; set; }
        public string Description { get; set; }
        public Boolean IsActive { get; set; }
    }
}
