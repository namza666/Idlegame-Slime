using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour {
    
    public int importantVariable = 99;
    
    public static GameManager instance;
    public int num=1;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public void Update()
    {
        Debug.Log("Num :"+num);
    }

}
