﻿using System.Runtime.Serialization;

namespace Lab5.Models
{
    [DataContract]
    public class LoginModel
    {
        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}