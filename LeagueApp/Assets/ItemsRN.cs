using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemsRN : MonoBehaviour {

    private GameObject ob1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        foreach (GameObject ob in GameObject.FindGameObjectsWithTag("summButt"))
        {
            if (ob.name == "SummLeft")
            {
                ob1 = ob;
            }
        }
    }

    public void AddCD()
    {
        ob1.GetComponent<ButtonSumm>().GetType().GetField(gameObject.name).SetValue(ob1.GetComponent<ButtonSumm>(), gameObject.GetComponentInChildren<Toggle>().isOn);
    }
}
