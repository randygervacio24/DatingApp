using System;

namespace API.Entities;

public class AppUser{
    //ID
    public string Id 
    { 
        get; 
        set; 
    } = Guid.NewGuid().ToString();

    //Name
    public required string FullName 
    { 
        get; 
        set; 
    } 

    //Email Address
     public required string EmailAddress 
    { 
        get; 
        set; 
    } 
}