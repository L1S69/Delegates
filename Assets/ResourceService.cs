using UnityEngine;

public class ResourceService :  IService
{
    public int SoftCurrency { get; private set; }

    public void Add(int amount)
    {
        SoftCurrency += amount;
        Debug.Log(SoftCurrency);
    }

    public bool IsEnoughtCurrency(int require)
    {
        return true;
    }
}
