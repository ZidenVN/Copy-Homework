using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos.User.Res
{
    public class UserProfileViewRes
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? Phone { get; set; }

        public int? Sex { get; set; }

        public DateTimeOffset? DateOfBirth { get; set; }
    }
}
