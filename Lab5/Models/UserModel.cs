using System.Runtime.Serialization;
using Lab5.Core.Entities;

namespace Lab5.Models
{
    [DataContract]
    public class UserModel
    {
        public UserModel(User u)
        {
            Id = u.Id;
            Username = u.Username;
            Surname = u.Surname;
            Name = u.Name;
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Surname { get; set; }
    }
}