using System;
using System.Collections.Generic;
using PhoneProject.Models;

namespace PhoneProject.Services;

public class ContactServices
{
    public List<Contact> contactList = new List<Contact>();
    public void ShowMenu(string message)
    {
        Console.WriteLine(message);
    }
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
    public void RemoveContact()
    {
        Console.Write("ism kiriting: ");
        string name = Console.ReadLine();
        contactList.RemoveAll(r => r.name == name);
    }
    public void EditContact()
    {
        Console.Write("Kimni kontaktini o'gartirmoqchisiz?, (ismini kiriting): ");
        string name = Console.ReadLine();
        bool isContactExist = contactList.Exists(r => r.name == name);
        if (isContactExist)
        {
            contactList.Find(r => r.name == name).phone = Console.ReadLine();
            Console.WriteLine("contact is successfully changed");
        }
        else
        {
            Console.WriteLine("not found this contact");
        }
    }

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

