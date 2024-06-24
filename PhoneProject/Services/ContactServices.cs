using System;
using System.Collections.Generic;
using PhoneProject.Models;

namespace PhoneProject.Services;

public class ContactServices
{
    /*    private Contact[] contacts =
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
        };*/

    public void AddContact()
    {
        Console.Write("ism kiriting: ");
        string name = Console.ReadLine();
        Console.Write("telefon raqam kiriting: ");
        string phone = Console.ReadLine();
        Contact contact = new Contact();

        contact.name = name;
        contact.phone = phone;
        contactList.Add(contact);
    }


    public List<Contact> contactList = new List<Contact>();
    public void ExistedContacts()
    {
        Contact contact1 = new Contact();
        contact1.name = "Javohir";
        contact1.phone = "123123123";
        contactList.Add(contact1);

        Contact contact2 = new Contact();
        contact2.name = "Alisher";
        contact2.phone = "25554444";
        contactList.Add(contact2);
    }
    public void ReadAllContacts()
    {
        foreach (Contact contact in contactList)
        {
            Console.WriteLine($"Name {contact.name}, Phone number {contact.phone}");
        }
    }
}

