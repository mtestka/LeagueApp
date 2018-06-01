using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Summoner : MonoBehaviour
{
    public bool isSelected = false;
    private GameObject[] go;
    public float Ghost, Clarity, Heal, Cleanse, Teleport, Flash, Ignite, Exhaust, Barrier, Smite;
    public bool Ionian, Insight;

    // Use this for initialization
    void Start()
    {
        Ghost = 180;
        Clarity = 240;
        Heal = 240;
        Cleanse = 210;
        Teleport = 300;
        Flash = 300;
        Ignite = 210;
        Exhaust = 210;
        Barrier = 180;
        Smite = 75;
        Ionian = false;
        Insight = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*public void Counting(float time)
    {
        if (Counter.clicked)
        {
            time -= Time.deltaTime;
            //text.text = ((int)time).ToString();
            text.color = Color.red;
        }
        else
        {
            text.color = Color.green;
            //text.text = time.ToString();
        }
        if (time <= 0)
        {
            time = timeStatic;
            clicked = false;
        }
    }*/
}
