using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Constants
{
    public static class Message
    {
        public static class RoleMessage
        {
            public const string NotFound = "role.not_found";
        }
        public static class UserMessage
        {
            public const string NotFound = "user.user_not_found";
            public const string PhoneAlreadyExist = "user.phone_already_exist";
            public const string EmailAlreadyExists = "user.email_already_exists";

            public const string FullNameIsRequired = "user.full_name_require";
            public const string PasswordStrength = "user.password_strength";
        }
    }
}
