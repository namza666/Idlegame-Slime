using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRedSlime : MonoBehaviour {
    public GameObject Cube;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

    }
    public void birth()
    {
        
            if (Mouse.instance.cout >= 25)
            {
                Mouse.instance.cout -= 25;
                Instantiate(Cube, new Vector2(Move.instance.position.position.x, Move.instance.position.position.y), Quaternion.identity);

            }


        

    }
}
