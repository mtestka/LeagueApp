using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterObject : MonoBehaviour {

    private DataController dataController;
    public Sprite[] charSp;
    private const float xPos = -450f;
    private const float yPos = 870f;
    public float movedPanel = 1110f;
    public Button gameOb;
    public GameObject panel;
    private GameObject testOne, team, solo, timer;
    private GameObject[] go;
    private IconObject[] io;
    public static string mode = "s";
    private int y = 0, a = 0;

	// Use this for initialization
	void Start () {
        dataController = GameObject.FindObjectOfType<DataController>();
        team = GameObject.FindGameObjectWithTag("team");
        solo = GameObject.FindGameObjectWithTag("solo");
        testOne = GameObject.FindGameObjectWithTag("Test");
        timer = GameObject.FindGameObjectWithTag("timer");
        timer.SetActive(false);
        System.Array.Sort(charSp, (a, b) => a.name.CompareTo(b.name));
        for(int i = 0; i<charSp.Length; i++)
        {
            var ob1 = Instantiate(gameOb, transform.localPosition, Quaternion.identity);
            ob1.transform.SetParent(panel.transform, false);
            ob1.image.sprite = charSp[i];
            ob1.name = charSp[i].name;
            ob1.transform.localPosition = new Vector3(xPos + 180 * (i%6), yPos - 180 * (i / 6) + movedPanel - 3*180, 0);
        }
        StartCoroutine(inactiveTest());
    }

    IEnumerator inactiveTest()
    {
        yield return new WaitForSeconds(0.1f);
        testOne.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public void Clear()
    {
        if (mode == "t")
        {
            /*foreach (GameObject gb in GameObject.FindGameObjectsWithTag("summButt"))
            {
                gb.GetComponentInChildren<RawImage>().texture = null;
            }*/
        }
        else
        {
            GameObject.FindGameObjectWithTag("mainButt").GetComponent<RawImage>().texture = null;
        }
    }

    public void Modes()
    {
        if(mode == "s")
        {
            mode = "t";
            //team.SetActive(true);
            timer.SetActive(true);
            solo.SetActive(false);
            GameObject.FindGameObjectWithTag("modeButt").GetComponentInChildren<Text>().text = "T mode";
        }
        else
        {
            mode = "s";
            //team.SetActive(false);
            timer.SetActive(false);
            solo.SetActive(true);
            GameObject.FindGameObjectWithTag("modeButt").GetComponentInChildren<Text>().text = "S mode";
        }
    }

    public void ShowCounters()
    {
        if (mode == "s")
        {
            if (GameObject.FindGameObjectWithTag("mainButt").GetComponent<RawImage>().texture != null)
            {
                Debug.Log(GameObject.FindGameObjectWithTag("mainButt").GetComponent<RawImage>().texture.name);
                string sprite = GameObject.FindGameObjectWithTag("mainButt").GetComponent<RawImage>().texture.name.Substring(0, GameObject.FindGameObjectWithTag("mainButt").GetComponent<RawImage>().texture.name.Length - 6);
                Debug.Log(sprite);
                for (int i = 0; i < dataController.mainData.champions.Length; i++)
                {
                    string value = dataController.mainData.champions[i].championName;
                    if (value == sprite)
                    {
                        Debug.Log("Done! " + i);
                        a = i;
                        break;
                    }
                }
                GameObject[] counters = GameObject.FindGameObjectsWithTag("counters");
                for (int y = 0; y < 6; y++)
                {
                    string nameCounter = dataController.mainData.champions[a].counters[y].CounterName;
                    counters[y].GetComponentInChildren<RawImage>().texture = GameObject.Find(nameCounter + "Square").GetComponent<Image>().sprite.texture;
                }
            }
        }
        else
        {

        }
    }

}
