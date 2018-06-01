using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour {

    public float time;
    private float timeStatic = 1;
    public bool clicked, fors;
    private Text text;
    private object result;
    private GameObject ob1;

    // Use this for initialization
    void Start() {
        //timeStatic = time;
        text = GetComponentInChildren<Text>();
        text.text = 0.ToString();
    }

    // Update is called once per frame
    void Update() {
        foreach (GameObject ob in GameObject.FindGameObjectsWithTag("summButt"))
        {
            //ob.name == "SummLeft"
            if (ob.GetComponent<ButtonSumm>().isSelected)
            {
                ob1 = ob;
            }
        }
        if (ob1)
        {
            result = ob1.GetComponent<ButtonSumm>().GetType().GetField(gameObject.name).GetValue(ob1.GetComponent<ButtonSumm>());
        }
        if (clicked)
        {
            /*timeStatic -= Time.deltaTime;
            ob1.GetComponent<ButtonSumm>().GetType().GetField(gameObject.name).SetValue(ob1.GetComponent<ButtonSumm>(), timeStatic);*/
            text.text = Convert.ToInt32(result).ToString();
            text.color = Color.red;
        }
        else
        {
            text.color = Color.green;
            if (ob1 && ob1.GetComponentInChildren<RawImage>().texture != null)
            {
                text.text = Convert.ToInt32(result).ToString();
            }
        }
        if (text.text  == "0")
        {
            //timeStatic = time;
            //ob1.GetComponent<ButtonSumm>().GetType().GetField(gameObject.name).SetValue(ob1.GetComponent<ButtonSumm>(), time);
            clicked = false;
        }
    }

    public void OnClick()
    {
        clicked = true;
        foreach (GameObject ob in GameObject.FindGameObjectsWithTag("summButt"))
        {
            if (ob.name == "SummLeft")
            {
                ob.GetComponent<ButtonSumm>().GetType().GetField("b"+gameObject.name).SetValue(ob.GetComponent<ButtonSumm>(), true);
            }
        }
    }
}
