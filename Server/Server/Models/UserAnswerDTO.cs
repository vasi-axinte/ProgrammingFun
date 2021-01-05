using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class UserAnswerDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserId { get; set; }

        public List<UserAnswerDetailsDTO> UserAnswerDetails { get; set; }
    }
}
