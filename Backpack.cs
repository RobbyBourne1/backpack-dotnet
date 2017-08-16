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

     public int AddTrackedItem(string item)
     {
         if (item == "Pencil" || item == "Folder" || item == "Pen")
         {
         TrackedItems++;
         }
        return TrackedItems;

     }
     public int RemoveTrackedItem(string item)
     {
         if (TrackedItems > 0 && item == "Pencil" || item == "Folder" || item == "Pen")
         {
             TrackedItems--;
         }
         return TrackedItems;
     }
    public override string ToString()
    {
        return $"You have added a {this.Item} to your {this.Type} BackPack. You have this many tracked items in your bag:{this.TrackedItems} ";
    }
 }

}