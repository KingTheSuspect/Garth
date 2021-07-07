using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float hiz, ziplama;
    public bool yerdemi;
    public enum HangiYon { Sag, Sol };
    public HangiYon yon;

    Rigidbody2D agirlik;

    void Start()
    {
        agirlik = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && yerdemi)
        {

            agirlik.AddForce(Vector2.up * ziplama);


        }
        float h = Input.GetAxis("Horizontal");


        if (h > 0.1f)
        {
            transform.localScale = new Vector2(1, 1);
            transform.Translate(h * hiz * Time.deltaTime, 0, 0);
            yon = HangiYon.Sag;

        }
        if (h < -0.1f)
        {
            transform.localScale = new Vector2(-1, 1);
            transform.Translate(h * hiz * Time.deltaTime, 0, 0);
            yon = HangiYon.Sol;
        }
    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Zemin")
        {
            yerdemi = true;
        }
    }
    public void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Zemin")
        {
            yerdemi = true;
        }
    }
    public void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Zemin")
        {
            yerdemi = false;
        }

    }


}



