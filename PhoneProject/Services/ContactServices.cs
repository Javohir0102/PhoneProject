using System;
using PhoneProject.Models;

namespace PhoneProject.Services;

public class ContactServices
{
    private Contact[] contacts =
    {
        new Contact
        {
            name = "Javohir",
            phone = "12312312"
        },
        new Contact
        {
            name = "Hurshid",
            phone = "12122121"
        }
    };
    public void ReadAllContacts() 
    {
        foreach (Contact contact in contacts) 
        {
            Console.WriteLine($"Name {contact.name}, Phone number {contact.phone}");
        }
    }
}

