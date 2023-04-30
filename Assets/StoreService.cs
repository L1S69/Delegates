using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreService : IService
{
   private readonly ResourceService _resourceService;

   public StoreService(ResourceService resourceService)
   {
      _resourceService = resourceService;
   }

   public void Buy(string ItemID, int amount)
   {
      var price = 15000;
      if (_resourceService.IsEnoughtCurrency(price))
      {
         Debug.Log(ItemID +" " + amount);
      }
   }
   
}
