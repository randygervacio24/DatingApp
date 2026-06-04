using System;

namespace API.Entities;

public class FixedAsset{
    //ID
    public string Id 
    { 
        get; 
        set; 
    } = Guid.NewGuid().ToString();

    //Name
    public required string Name 
    { 
        get; 
        set; 
    } 

    //Category
     public required string Category 
    { 
        get; 
        set; 
    } 

      //Value
    public decimal Value 
    { 
        get; 
        set; 
    } 

    //Purcahse Date
     public DateTime PurchaseDate 
    { 
        get; 
        set; 
    } 
}