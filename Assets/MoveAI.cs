using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoveAI : MonoBehaviour {
    public Rigidbody2D rb;
    float speed=0.20f;
    float delay=3;

    float time;
    float time2;
    
    bool IsGround;
    float num;

    // Use this for initialization
    void Start () {
        num = GameManager.instance.num;
        GameManager.instance.num += 1;
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
       

        

        if (IsGround == true)
        {
            if (time > delay)
            {
                speed *= -1;
                
                
                GetMoney();
                time = 0;

            }
            

        }
        rb.AddForce(new Vector2(speed, 0), ForceMode2D.Impulse);
        
    }
    void GetMoney()
    {
        Mouse.instance.cout += 1;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "platfrom")
        {
            IsGround = true;

        }
        else
        {
            IsGround = false;
        }
    }
}
