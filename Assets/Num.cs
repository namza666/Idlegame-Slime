using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Num : GameManager {
    float num;
	// Use this for initialization
    
	void Start () {
        num = GameManager.instance.num;
        GameManager.instance.num += 1;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
