using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    private Material currentMaterial;
    public float speed;
    public float posicaoCenario;
    public float vertical;
    
   
    // Use this for initialization
	void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        this.transform.Translate(Vector3.left * speed * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("BackTrigger"))
        {
            this.transform.position = new Vector3(posicaoCenario, vertical, 0);
        }
    }
}
