using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public float cost=10;
    float time=1;
    public static Upgrade instance;

    public void Awake()
    {
        instance = this;
    }

    public void Upgrades()
    {
        
        if (Mouse.instance.cout >= 0 && Mouse.instance.cout-cost+time > 0)
        {

            Mouse.instance.cout -= cost+time;
            cost += time;
            Mouse.instance.upgrade += 0.5f;
            
            time += 5;
            Debug.Log(""+cost);
        }
    }
}
