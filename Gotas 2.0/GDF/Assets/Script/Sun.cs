using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour {

    private Material currentMaterial;
    private float speed;


    // Use this for initialization
    void Start()
    {
        speed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("BackTrigger"))
        {
            this.transform.position = new Vector3(15f, 3.7f, 0);
        }
    }
}