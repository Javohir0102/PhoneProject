using System;
using System.Collections.Generic;
using PhoneProject.Models;
using PhoneProject.Services;

namespace PhoneProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContactServices contactServices = new ContactServices();
            contactServices.ExistedContacts();
            contactServices.ReadAllContacts();
            contactServices.AddContact();
            contactServices.ReadAllContacts();
        }
    }
}
