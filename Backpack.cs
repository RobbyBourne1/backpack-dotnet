using System;

namespace backpack_dotnet
{
 class Backpack
 {
     public string Type { get; set; }
     public string Item { get; set; }
     public bool Tracked { get; set; } = false;
     public int TrackedItems { get; set; } = 0;

     public Backpack(string type, string item)
     {
         Type = type;
         Item = item; 
     }

     public int AddTrackedItem()
     {
         TrackedItems++;
         return TrackedItems;
     }
     public int RemoveTrackedItem()
     {
         if (TrackedItems > 0)
         {
             TrackedItems--;
         }
         return TrackedItems;
     }
    public
 }

}