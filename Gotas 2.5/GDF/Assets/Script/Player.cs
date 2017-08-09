using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    [SerializeField]
    float jumpMultiplier;
    public int score = 0;
    [SerializeField]
    Text scoreText;
    bool onGround;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (Input.GetKey(KeyCode.Space) && onGround)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpMultiplier, ForceMode2D.Force);
            onGround = false;
        }
		
	}
    private void Update()
    {
        scoreText.text = "Pontos : " + score;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collided");
        onGround = true;
    }
}
