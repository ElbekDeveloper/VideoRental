using System.Collections.Generic;

namespace VideoStoreUI.Models
{
    public class RandomPersonViewModel
    {
        public PersonModel PersonModel { get; set; }
        public List<Friend> Friends { get; set; }
    }

    public class Friend
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}