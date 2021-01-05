﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class UserScoreDTO
    {
        public string UserId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public List<QuizDetailsDTO> QuizDetails { get; set; }

    }
}
