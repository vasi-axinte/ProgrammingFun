﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class AnswersCheckDTO
    {
        public int QuestionId { get; set; }

        public int SelectedAnswer { get; set; }
    }
}