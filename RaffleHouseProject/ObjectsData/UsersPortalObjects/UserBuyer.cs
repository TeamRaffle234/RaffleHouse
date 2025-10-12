using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseProject.ObjectsData.UsersPortalObjects
{
    public class UserBuyer
    {
        public UserAlreadyCreatedWihtoutPhoneInfo UserAlreadyCreatedWihtoutPhone { get; set; }

        public static UserBuyer Generate()
        {
            return new UserBuyer
            {
                UserAlreadyCreatedWihtoutPhone = CreateUserAlreadyCreatedWihtoutPhoneInfo(),
            };
        }

        public class UserAlreadyCreatedWihtoutPhoneInfo
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string FullName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Password { get; set; }
        }

        private static UserAlreadyCreatedWihtoutPhoneInfo CreateUserAlreadyCreatedWihtoutPhoneInfo()
        {
            return new UserAlreadyCreatedWihtoutPhoneInfo
            {
                FirstName = "Jerry Lee",
                LastName = "First Junior",
                FullName = "Jerry Lee First Junior",
                Email = "jerry-lee1autotest@putsbox.com",
                PhoneNumber = "",
                Password = "Qw12er",
            };
        }
    }
}
