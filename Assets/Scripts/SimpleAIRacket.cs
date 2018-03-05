using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleAIRacket : Racket
{
    public Transform Ball;
    public float ReferenceValue;

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        float Distance = Mathf.Abs(Ball.position.y - transform.position.y); //raket ile top arasındaki uzaklık hesaplanacak
        
        if (Distance> ReferenceValue) //koşmak gerekiyor mu?
        {
            if(Ball.transform.position.y<transform.position.y)
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * MoveSpeed;
            }
            if (Ball.transform.position.y > transform.position.y)
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * MoveSpeed;
            }
        }
    }
}
