namespace DomainLayer
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Profile
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string City { get; set; }

        public string Sex { get; set; }

        public string Level { get; set; }

        public string Programme { get; set; }

        public string Skype { get; set; }

        public string Phone { get; set; }

        public string Vkontakte { get; set; }

        public bool Open { get; set; }

        public ICollection<Photo> Photos { get; set; }

        public ICollection<Profile> OpenList { get; set; }
    }
}
