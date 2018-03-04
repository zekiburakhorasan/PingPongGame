using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float speed = 10.0f;

    MoveRacket SolRacket;
    MoveRacket SagRacket;

    public GameObject LeftRacket;
    public GameObject RightRacket;

    // Use this for initialization
    void Start ()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0)*speed;
        SolRacket = LeftRacket.GetComponent<MoveRacket>();
        SagRacket = RightRacket.GetComponent<MoveRacket>();
}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
		
	}

    //Skor yapma
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "LeftWall")
        {
            SolRacket.Score++;
        }
        if (other.gameObject.name == "RightWall")
        {
            SagRacket.Score++;
        }

        if (other.gameObject.name == "LeftRacket")
        {
            //raketin üstüne çarparsa yönünü x=+1 y=hesaplanacak
            float yMinus = transform.position.y - other.gameObject.transform.position.y;
            //Raketin uzunluğu hesaplanır
            float RacketLenght = other.collider.bounds.size.y;
            //floatları var olarakda tanımlasak V.S. onun float olduğunu algılayıp ona göre davranıyor
            var y = yMinus / RacketLenght;
            //Bulduğumuz yön vektörü
            Vector2 direction = new Vector2(1, y);
            //Bu vektörü topumuzun hızına ekler
            GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
        if (other.gameObject.name == "RightRacket")
        {
            //raketin üstüne çarparsa yönünü x=-1 y=hesaplanacak
            float yMinus = transform.position.y - other.gameObject.transform.position.y;
            //Raketin uzunluğu hesaplanır
            float RacketLenght = other.collider.bounds.size.y;
            //floatları var olarakda tanımlasak V.S. onun float olduğunu algılayıp ona göre davranıyor
            var y = yMinus / RacketLenght;
            Vector2 direction = new Vector2(-1, y);
            //Bu vektörü topumuzun hızına ekler
            GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
    }
}
