﻿using System.ComponentModel.DataAnnotations;
using CadastroWeb.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime Birthdate { get; set; }
    public string Gender { get; set; }
    public string Password { get; set; }
}

