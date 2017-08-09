using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotaController : MonoBehaviour {
    public float velocity;
	// Use this for initialization
	void Start () {
        velocity = 2;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(-velocity * Time.deltaTime, 0, 0);
	}
}
