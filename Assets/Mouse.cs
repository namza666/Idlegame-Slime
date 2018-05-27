using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Mouse : MonoBehaviour {
    public Text money;
    public float cout;
    public GameObject Cube;
    public static Mouse instance;
    public float upgrade = 1;
    public float time = 1;
    // Use this for initialization
    private void Awake()
    {
        instance = this;
        
    }
    void Start () {
       
	}

    // Update is called once per frame
    void Update()
    {
        money.text = "Money : " + cout;
       
    if (Input.GetMouseButtonDown(0))
    { 
       
        GetMoney();
        
    }
        
       

    }

    void GetMoney()
    {
        cout += 1* upgrade*time;
    }
}
