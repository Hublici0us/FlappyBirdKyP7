using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingObject : MonoBehaviour
{

    BoxCollider2D groundCollider;
    float GroundHorizontalLength;

    // Start is called before the first frame update
    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        GroundHorizontalLength = groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -GroundHorizontalLength)
        {
            repositionBackground();
        }
    }

    void repositionBackground()
    {
        Vector2 groundOffset = new Vector2(GroundHorizontalLength * 2, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
