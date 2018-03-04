using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacket : MonoBehaviour
{
    public float speed;
    //Dikey eksen tanımlanacak
    public string verticalAxis;
    Rigidbody2D rb2;
    public float Score;

    // Use this for initialization
    void Start ()
    {
        //Hız tanımlandı
        speed = 10.0f;
        //Oyun nesnesine ait Rigitbody2D bileşeni alınıyor ve atama yapılıyor
        rb2 = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void FixedUpdate ()
    {
        float y = Input.GetAxisRaw(verticalAxis);
        rb2.velocity = new Vector2(0, y) * speed;
	}
}
