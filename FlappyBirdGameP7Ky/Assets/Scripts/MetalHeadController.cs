using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class MetalHeadController : MonoBehaviour
{
    public float upForce = 200f;
    bool isDead = false;
    Rigidbody2D rb2d;
    Animator anim;
    PolygonCollider2D poly2d;
    AudioSource sounds;
    public AudioClip boost;
    public AudioClip tink;


    // Start is called before the first frame update
    void Start()
    {
        /*at start, checks if rigidbody is attached to script
         * so we can later use it in parts of the script. */
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        poly2d = GetComponent<PolygonCollider2D>();
        sounds = GetComponent<AudioSource>();
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
                playSound(boost);
                anim.SetTrigger("Fly");
            }
        }
    }

    private void OnCollisionEnter2D()
    {
        GameControl.instance.birdDied();
        rb2d.velocity = Vector2.zero;
        isDead = true;
        anim.SetTrigger("Die");
        playSound(tink);
        poly2d.offset = new Vector2(0, 6);
        
    }

    public void playSound(AudioClip clip)
    {
        sounds.PlayOneShot(clip);
    }
}
