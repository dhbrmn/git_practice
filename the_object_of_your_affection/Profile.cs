using System;

namespace DatingProfile
{
    class Profile
    {
        //FIELDS
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;
        private bool hasHobbies = false;

        //CONSTRUCTOR
        public Profile(string Name, int Age, string City = "Someplace", string Country = "On Earth", string Pronouns = "they/them")
        {
            this.Name = Name;
            this.Age = Age;
            this.City = City;
            this.Country = Country;
            this.pronouns = Pronouns;
        }

        //PROPERTIES

        private string Name
        { get; set; }

        private int Age
        {
            get { return age; }
            set
            {
                age = value;
            }
        }

        private string City
        { get; set; }

        private string Country
        { get; set; }

        private string Pronouns
        { get; set; }

        private string[] Hobbies
        {
            get
            {
                return hobbies;
            }
            set
            {
                hobbies = value;
            }
        }

        //METHODS

        public string ViewProfile()
        {
            if (age >= 18)
            {
                if (hasHobbies)
                {
                    return $"Name: {Name} | Age: {Age} | City: {City} | Country: {Country} | Hobbies: {String.Join(", ", Hobbies)}";
                }
                else
                {
                    return $"Name: {Name} | Age: {Age} | City: {City} | Country: {Country}";
                }
            }
            else
            {
                return "You must be at least 18 years old to use this app.";
            }
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
            if (this.hobbies.Length != 0)
            {
                hasHobbies = true;
            }
        }

    }
}

