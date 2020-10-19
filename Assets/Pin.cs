using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public bool isPinned = false;
    void FixedUpdate()
    {
        if(!isPinned)
            rb.MovePosition(rb.position + (Vector2.up * speed * Time.deltaTime) );
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Rotator")
        {
            isPinned = true;
            transform.SetParent(col.transform);
            Score.PinCount++;
            //col.GetComponent<Rotator>().speed *= -1; 

        }
        else if(col.tag == "Pin")
        {
            // -- GAME OVER --
            FindObjectOfType<GameManager1>().EndGame();
        }

    }
}
