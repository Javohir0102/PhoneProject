﻿using System;
using System.Collections.Generic;
using PhoneProject.Models;
using PhoneProject.Services;
using Spectre.Console;

namespace PhoneProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContactServices contactServices = new ContactServices();

            // Ask for the user's favorite fruit
            var menuChoice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Select your [green]choice[/]?")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Move up and down to reveal more services)[/]")
                    .AddChoices(new[] {
            "AddContact", "RemoveContact", "EditContact",
            "ExistedContacts", "ReadAllContacts",
                    }));

            // Echo the fruit back to the terminal
            AnsiConsole.WriteLine($"Your choice: {menuChoice}");

            switch (menuChoice)
            {
                case "AddContact":
                    {
                        contactServices.AddContact();
                        break;
                    }
                case "RemoveContact":
                    {
                        contactServices.RemoveContact();
                        break;
                    }
                case "EditContact":
                    {
                        contactServices.EditContact();
                        break;
                    }
                case "ExistedContacts":
                    {
                        contactServices.ExistedContacts();
                        break;
                    }
                case "ReadAllContacts":
                    {
                        contactServices.ReadAllContacts();
                        break;
                    }
            }
        }
    }
}
