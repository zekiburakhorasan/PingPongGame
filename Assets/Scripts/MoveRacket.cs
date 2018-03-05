using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveRacket : Racket
{
    public string verticalAxis; //Dikey eksen tanımlanacak
    
    void Start ()
    {
        
    }
    
	void FixedUpdate ()
    {
        float y = Input.GetAxisRaw(verticalAxis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, y) * MoveSpeed;
	}
}
