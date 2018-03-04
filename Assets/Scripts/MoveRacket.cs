using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveRacket : MonoBehaviour
{
    public Text ScoreText;
    public float speed;
    //Dikey eksen tanımlanacak
    public string verticalAxis;
    Rigidbody2D rb2;
    private float Score;

    // Use this for initialization
    void Start ()
    {
        //Hız tanımlandı
        speed = 5.0f;
        //Oyun nesnesine ait Rigitbody2D bileşeni alınıyor ve atama yapılıyor
        rb2 = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void FixedUpdate ()
    {
        float y = Input.GetAxisRaw(verticalAxis);
        //GetComponent<Rigidbody2D>().velocity = new Vector2(0, y) * speed;
        rb2.velocity = new Vector2(0, y) * speed;

        //Debug.Log(Score + " : " + gameObject.name);
	}

    //Skor yap
    public void ScoreUp()
    {
        Score++;
        ScoreText.text = Score.ToString();
    }
}
