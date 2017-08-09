using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontos : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    private Gota gota;

    // Use this for initialization

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gota = gameControllerObject.GetComponent<Gota>();
        }
        if (gota == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }
       // Instantiate(explosion, transform.position, transform.rotation);
        if (other.tag == "Player")
        {
            //Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            other.GetComponent<Player>().score++;
            Destroy(gameObject);
        }
    }
}
