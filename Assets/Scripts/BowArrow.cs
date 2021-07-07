using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowArrow : MonoBehaviour
{
    public GameObject arrow;
    public float force;
    public Transform shotPoint;
    public Animator animator;
    public Player HangiYon;
    public HangiYon yon;


    // Update is called once per frame
    void Update()
    {
        Vector2 bowPosition = transform.position;

        if (Input.GetKeyDown(KeyCode.F))
        {
            Shoot();
            animator.Play("Bow");
        }

    }
    void Shoot()
    {
        if (yon = Player.HangiYon.Sag)
        {
            GameObject newArrow = Instantiate(arrow, shotPoint.position, shotPoint.rotation);
            newArrow.GetComponent<Rigidbody2D>().velocity = transform.right * force;
        }

    }

}
