﻿using System;
using AdvancedAnalysisDesign.Enums;

namespace AdvancedAnalysisDesign.Models
{
    public class RegistrationPayload
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public string NhsNumber { get; set; }
        public byte[] VerificationImage { get; set; }
    }
}
