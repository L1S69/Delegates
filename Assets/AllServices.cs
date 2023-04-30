using System;
using System.Collections.Generic;

public class AllServices
{
   private Dictionary<Type, IService> _allServices = new Dictionary<Type, IService>(); // Dictonary of services using their types as keys

   public void Init() // Creates instances of all services and adds them to the dictonary
   {
      var resourceService = new ResourceService();
      Register(resourceService);
      
      var storeService = new StoreService(resourceService);
      Register(storeService);
   }

   public T Get<T>() // Returns a service of type T
   {
      var type = typeof(T);
      return (T) _allServices[type];
   }

   private void Register<T>(T services) where T : IService // Adds a service of type T to the dictonary using T as key
   {
      var type = typeof(T);
      _allServices[type] = services;
   }
}
