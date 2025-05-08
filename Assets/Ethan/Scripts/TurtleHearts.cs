using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleHearts : MonoBehaviour
{
    Vector3 pos;
    public float speed = 1f;

    public SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer.enabled = false;
    }

    void Update()
    {
        pos = Input.mousePosition;
        pos.z = speed;
        transform.position = Camera.main.ScreenToWorldPoint(pos);
        if(Input.GetMouseButtonDown(0) && TurtleClicked.turtleClicked)
        {
            StartCoroutine(Visibility());
        }
    }

    /*void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Turtle"))
        {
            turtleCheck = true;
        }
    }*/

    IEnumerator Visibility()
    {
        spriteRenderer.enabled = true;
        yield return new WaitForSeconds(1);
        spriteRenderer.enabled = false;
    }
}
