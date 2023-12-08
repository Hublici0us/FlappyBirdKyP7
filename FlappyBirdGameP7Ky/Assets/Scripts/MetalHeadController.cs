using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalHeadController : MonoBehaviour
{
    public float upForce = 200f;
    bool isDead = false;
    Rigidbody2D rb2d;
    Animator anim;
    PolygonCollider2D poly2d;

    // Start is called before the first frame update
    void Start()
    {
        /*at start, checks if rigidbody is attached to script
         * so we can later use it in parts of the script. */
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        poly2d = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));
                anim.SetTrigger("Fly");
            }
        }
    }

    private void OnCollisionEnter2D()
    {
        GameControl.instance.birdDied();
        isDead = true;
        anim.SetTrigger("Die");
        poly2d.offset = new Vector2(0, 4);
        
    }
}
