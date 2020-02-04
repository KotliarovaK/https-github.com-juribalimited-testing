﻿using System.Collections.Generic;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //User credentials that used during test execution
    public class UsedUsers
    {
        public UsedUsers()
        {
            Value = new List<UserDto>();
        }

        public List<UserDto> Value { get; set; }
    }
}