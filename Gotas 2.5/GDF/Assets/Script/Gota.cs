using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gota : MonoBehaviour
{
    public float timer;
    public float timer2;
    public GameObject Horda1;


    public int position;
    public float altura;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(i);



        timer += Time.deltaTime;

        if (timer <= 60)
        {
            timer2 += Time.deltaTime;

            if (timer2 > 7)
            {
                Spawn();
                timer2 = 0;
            }
        }
        

    }

    public void Spawn()
    {
        GameObject inimigo = Instantiate(Horda1) as GameObject;
    }

 


}
