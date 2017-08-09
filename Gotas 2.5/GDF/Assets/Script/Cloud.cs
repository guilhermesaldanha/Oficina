using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour {

    private Material currentMaterial;
    public float speed;
    public float posicaoX;
    public float posicaoY;

    // Use this for initialization
    void Start()
    {
        
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
            this.transform.position = new Vector3(posicaoX, posicaoY, 0);
        }
    }
}
