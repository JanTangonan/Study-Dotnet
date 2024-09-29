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
    private string[] hobbies = [];

    //CONSTRUCTORS
    public Profile(
      string name,
      int age,
      string city,
      string country,
      string pronouns
    )
    {
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
    }

    //METHODS
    public string ViewProfile()
    {
      string h = string.Empty;
      foreach (string hobby in hobbies) {
        h += $"{hobby}, ";
      }
      h = h.TrimEnd(',', ' ');
      return $"Name: {this.name} \nAge: {this.age} \nCity {this.city} \nCountry: {this.country} \nPronouns: {this.pronouns} \nHobbies: {h}"; 
    }

    public void SetHobbies(string[] hobbies)
    {
      this.hobbies = hobbies;
    }
   }
}
