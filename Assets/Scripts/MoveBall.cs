using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float Speed;
    public GameObject LeftRacket;
    public GameObject RightRacket;
    AudioSource audioSource;
    
    void Start ()
    {
        Speed = 10.0f;
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0)* Speed;
        audioSource = GetComponent<AudioSource>();
    }
	
	void FixedUpdate ()
    {
		
	}
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(!audioSource.isPlaying)
        {
            audioSource.Play();
        }

        if (other.gameObject.name == "LeftWall")
        {
            RightRacket.GetComponent<Racket>().ScoreUp();
        }
        if (other.gameObject.name == "RightWall")
        {
            LeftRacket.GetComponent<Racket>().ScoreUp();
        }

        if (other.gameObject.name == "LeftRacket")
        {
            float xDir = 1;
            ReturnDirection(other,xDir);
        }
        if (other.gameObject.name == "RightRacket")
        {
            float xDir = -1;
            ReturnDirection(other, xDir);
        }
    }

    private void ReturnDirection(Collision2D other, float xDir)
    {
        float yMinus = transform.position.y - other.gameObject.transform.position.y; //raketin üstüne çarparsa yönünü x=+1 y=hesaplanacak
        float RacketLenght = other.collider.bounds.size.y; //Raketin uzunluğu hesaplanır
        var y = yMinus / RacketLenght; //floatları var olarakda tanımlasak V.S. onun float olduğunu algılayıp ona göre davranıyor
        Vector2 direction = new Vector2(xDir, y);  //Bulduğumuz yön vektörü
        GetComponent<Rigidbody2D>().velocity = direction * Speed; //Bu vektörü topumuzun hızına ekler
    }
}
