using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{

    public AudioSource racketsound;
    public AudioSource wallsound;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Racket 1" || collision.gameObject.name == "Racket 2")
        {
            this.racketsound.Play();
        }
        else
        {
            this.wallsound.Play();
        }
    }

}
