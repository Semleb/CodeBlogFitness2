using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.BL.Model
{
    public class User
    {
        public string Name { get; }
        public Gender Gender { get; }
        public DateTime BirthDay { get; }
        public double Weight { get; set; }
        public double Height { get; set; }
        
        public User(string name, Gender gender, DateTime birthDay, double weight, double height)
        {
            #region Check
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Name can't be null.", nameof(name));
            }
            if(gender == null)
            {
                throw new ArgumentNullException("Gender can't be null.", nameof(gender));
            }
            if(birthDay < DateTime.Parse("01.01.1900") || birthDay >= DateTime.Now)
            {
                throw new ArgumentException("Error date.", nameof(birthDay));
            }
            if(weight <= 10)
            {
                throw new ArgumentException("Error weight.", nameof(weight));
            }
            if(height <= 10)
            {
                throw new ArgumentException("Error height.", nameof(height));
            }
            #endregion

            Name = name;
            Gender = gender;
            BirthDay = birthDay;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
