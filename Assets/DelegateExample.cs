using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    private AllServices _allServices;

    private void Start() // Initializes services
    {
        _allServices = new AllServices();
        _allServices.Init();
        
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            var resourceServices = _allServices.Get<ResourceService>();
            resourceServices.Add(Random.Range(1,10));
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            var storeServices = _allServices.Get<StoreService>();
            storeServices.Buy("randomItem", Random.Range(5,10));
        }
    }
}
