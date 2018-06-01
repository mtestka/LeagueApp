using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSumm : MonoBehaviour {

    public bool isSelected = false;
    private GameObject[] go;
    private int Cdr = 0;
    public float Ghost, Clarity, Heal, Cleanse, Teleport, Flash, Ignite, Exhaust, Barrier, Smite, tGhost, tClarity,
        tHeal, tCleanse, tTeleport, tFlash, tIgnite, tExhaust, tBarrier, tSmite;
    public bool Ionian, Insight, SpellBook, ready, bGhost, bClarity, bHeal, bCleanse, bTeleport, bFlash, bIgnite, bExhaust, bBarrier,
        bSmite;

// Use this for initialization
    void Start () {
        tGhost = 180;
        tClarity = 240;
        tHeal = 240;
        tCleanse = 210;
        tTeleport = 300;
        tFlash = 300;
        tIgnite = 210;
        tExhaust = 210;
        tBarrier = 180;
        tSmite = 75;
        /*Ghost = tGhost*(100-Cdr)/100;
        Clarity = tClarity*(100-Cdr)/100;
        Heal = tHeal*(100-Cdr)/100;
        Cleanse = tCleanse*(100-Cdr)/100;
        Teleport = tTeleport*(100-Cdr)/100;
        Flash = tFlash*(100-Cdr)/100;
        Ignite = tIgnite*(100- Cdr)/100;
        Exhaust = tExhaust*(100-Cdr)/100;
        Barrier = tBarrier*(100-Cdr)/100;
        Smite = tSmite*(100-Cdr)/100;*/
        Ionian = false;
        Insight = false;
        SpellBook = false;
    }
	
	// Update is called once per frame
	void Update () {
        ValueChanged();
        Ghost = tGhost * (100 - Cdr)/100;
        Clarity = tClarity * (100 - Cdr)/100;
        Heal = tHeal * (100 - Cdr)/100;
        Cleanse = tCleanse * (100 - Cdr)/100;
        Teleport = tTeleport * (100 - Cdr)/100;
        Flash = tFlash * (100 - Cdr)/100;
        Ignite = tIgnite * (100 - Cdr)/100;
        Exhaust = tExhaust * (100 - Cdr)/100;
        Barrier = tBarrier * (100 - Cdr)/100;
        Smite = tExhaust * (100 - Cdr)/100;

        if (bGhost && tGhost > 0)
            tGhost -= Time.maximumDeltaTime/20;
        else {
            bGhost = false;
            tGhost = 180;
        }
        if (bClarity && tClarity > 0)
            tClarity -= Time.maximumDeltaTime / 20;
        else {
            bClarity = false;
            tClarity = 240;
        }
        if (bHeal && tHeal > 0)
            tHeal -= Time.maximumDeltaTime / 20;
        else {
            bHeal = false;
            tHeal = 240;
        }
        if (bCleanse && tCleanse > 0)
            tCleanse -= Time.maximumDeltaTime / 20;
        else {
            bCleanse = false;
            tCleanse = 210;
        }
        if (bTeleport && tTeleport > 0)
            tTeleport -= Time.maximumDeltaTime / 20;
        else {
            bTeleport = false;
            tTeleport = 300;
        }
        if (bFlash && tFlash > 0)
            tFlash -= Time.maximumDeltaTime / 20;
        else {
            bFlash = false;
            tFlash = 300;
        }
        if (bIgnite && tIgnite > 0)
            tIgnite -= Time.maximumDeltaTime / 20;
        else {
            bIgnite = false;
            tIgnite = 210;
        }
        if (bExhaust && tExhaust > 0)
            tExhaust -= Time.maximumDeltaTime / 20;
        else {
            bExhaust = false;
            tExhaust = 210;
        }
        if (bBarrier && tBarrier > 0)
            tBarrier -= Time.maximumDeltaTime / 20;
        else {
            bBarrier = false;
            tBarrier = 180;
        }

        if (bSmite && tSmite > 0)
            tSmite -= Time.maximumDeltaTime / 20;
        else {
            bSmite = false;
            tSmite = 75;
        }
    }

    public void Calculated()
    {

    }

    public void ValueChanged()
    {
        if (Ionian)
            if (Insight)
                if (SpellBook)
                    Cdr = 40;
                else
                    Cdr = 15;
            else Cdr = 10;
        else if (Insight)
            if (Ionian)
                if (SpellBook)
                    Cdr = 40;
                else
                    Cdr = 15;
            else Cdr = 5;
        else if (SpellBook)
            if (Ionian)
                if (Insight)
                    Cdr = 40;
                else
                    Cdr = 35;
            else Cdr = 25;
        else
            Cdr = 0;
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

    public void Selected()
    {
        foreach(GameObject ob in GameObject.FindGameObjectsWithTag("summButt"))
        {
            if(gameObject.GetComponentInChildren<RawImage>() != null && ob.name == "SummLeft")
            {
                Texture temp = ob.GetComponentInChildren<RawImage>().texture;
                ob.GetComponentInChildren<RawImage>().texture = gameObject.GetComponentInChildren<RawImage>().texture;
                gameObject.GetComponentInChildren<RawImage>().texture = temp;
            }
            ob.GetComponent<ButtonSumm>().isSelected = false;
        }
        isSelected = !isSelected;
        /*foreach(GameObject ob in GameObject.FindGameObjectsWithTag("summButt"))
        {
            if (isSelected && ob.GetComponent<RawImage>().texture != null)
            {
                GameObject iconMain;
                if (ob.name == "SummLeft")
                {
                    iconMain = ob;
                }
            }
        }*/
    }
}
