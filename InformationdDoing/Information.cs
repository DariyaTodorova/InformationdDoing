using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace InformationdDoing
{
    public class Information
    {
        private string city;
        private string name;
        private int age;
        private string gender;
        private string address;

        public string City 
        { 
            get { return city; } 
            set { city = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (age < 18 && age < 60)
                {
                    Console.WriteLine("Wrong age!");
                }   
            } 
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public void Output()
        {
            Console.WriteLine($"{this.city}, {this.name}, {this.age}, {this.gender}, {this.address}");
        }

        public Information(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Information(string city, string name, int age, string gender, string address)
        {
            this.city = city;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
        }

    }
}
