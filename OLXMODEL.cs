using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace OLXRESALEMODELLIBRARY
{
    public class OLXMODEL
    {
        
        string _firstName;
        string _lastName;
        int _age;
        string _gender;
        string _contactNumber;
        string _userId;
        string _password;
        string _email;
        string _address;
        string _itemname;
        string _itemid;
        int _yearofusage;
        string _catname;
        string _amount;
        string _uid;
        byte[] _image;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Age { get => _age; set => _age = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public string ContactNumber { get => _contactNumber; set => _contactNumber = value; }
        public string UserId { get => _userId; set => _userId = value; }
        public string Password { get => _password; set => _password = value; }
        public string Email { get => _email; set => _email = value; }
        public string Address { get => _address; set => _address = value; }
        public byte[] Image { get => _image; set => _image = value; }
        public string Itemname { get => _itemname; set => _itemname = value; }
        public string Itemid { get => _itemid; set => _itemid = value; }
        public int Yearofusage { get => _yearofusage; set => _yearofusage = value; }
        public string Catname { get => _catname; set => _catname = value; }
        public string Amount { get => _amount; set => _amount = value; }
        public string Uid { get => _uid; set => _uid = value; }

        public OLXMODEL() { }
        //public OLXMODEL(string firstName,string lastName,int age,string gender,string contactNumber,string userid,string password,string email,string address)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Age = age;
        //    Gender = gender;
        //    ContactNumber = contactNumber;
        //    UserId = userid;
        //    Password = password;
        //    Email = email;
        //    Address = address;
        //}
    }
}