using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{

    AudioSource sound;
    public AudioClip pointScore;
    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<MetalHeadController>() != null)
        {
            GameControl.instance.birdScored();
            sound.PlayOneShot(pointScore);
        }
    }
}
