using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconObject : MonoBehaviour {
    
    private GameObject testOne;
    private GameObject[] go;
    private GameObject go1;

    // Use this for initialization
    void Start () {
        testOne = GameObject.FindGameObjectWithTag("Test");
        //testOne.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TakeIcon()
    {
        if (CharacterObject.mode == "t")
        {
            foreach (GameObject ob in GameObject.FindGameObjectsWithTag("summButt"))
            {
                if (ob.GetComponent<ButtonSumm>().isSelected)
                {
                    ob.GetComponentInChildren<RawImage>().texture = gameObject.GetComponent<Image>().sprite.texture;
                    return;
                }
            }
        }
        else
        {
            GameObject.FindGameObjectWithTag("mainButt").GetComponent<RawImage>().texture = gameObject.GetComponent<Image>().sprite.texture;
        }
    }
}
