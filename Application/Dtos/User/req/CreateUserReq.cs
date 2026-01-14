using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos.User.req
{
    public class CreateUserReq
    {
        public string? Email { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Sex { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string? RoleName { get; set; }
    }
}
