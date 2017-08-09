using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controle_Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Bt_Start()
    {
        //Application.loadedLevel("Game");
        SceneManager.LoadScene("Game");
    }

    public void Bt_Options()
    {
        Debug.Log("Options running");
    }

    public void Bt_Exit()
    {
        Application.Quit();        
    }
}

