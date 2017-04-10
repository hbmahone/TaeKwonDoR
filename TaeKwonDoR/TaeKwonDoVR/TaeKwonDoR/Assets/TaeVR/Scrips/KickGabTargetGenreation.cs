using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class KickGabTargetGenreation : MonoBehaviour {
    public GameObject TBL, TBR, TUL, TUR, TCTop, TCBottom;
    public bool trigger;
    public bool isOn;
    public GameObject KickText;

	// Use this for initialization
	void Start () {
        trigger = true;
        isOn = true;
}
	
	// Update is called once per frame
	void Update () {
        if ((trigger == true) && (isOn = true))
        {
            choseRandomTarget();
            trigger = false;
        }
	}
    IEnumerator wait()
    {
        yield return new WaitForSecondsRealtime(2);
    }
    public void choseRandomTarget()
    {
        System.Random random = new System.Random();
        int randomNumber = random.Next(1,7);

        StartCoroutine(wait());

        if (randomNumber == 1)
        {
            TBL.gameObject.GetComponent<TargetManager>().enableTarget();
                choseKickNameSides();
        }
        if (randomNumber ==2 )
        {
            TBR.gameObject.GetComponent<TargetManager>().enableTarget();
            choseKickNameSides();
        }
        if (randomNumber ==3 )
        {
            TUL.gameObject.GetComponent<TargetManager>().enableTarget();
            choseKickNameSides();
        }
        if (randomNumber ==4 )
        {
            TUR.gameObject.GetComponent<TargetManager>().enableTarget();
            choseKickNameSides();
        }
        if (randomNumber ==5 )
        {
            TCTop.gameObject.GetComponent<TargetManager>().enableTarget();
            choseKickNameFront();
        }
        if (randomNumber ==6 )
        {
            TCBottom.gameObject.GetComponent<TargetManager>().enableTarget();
            choseKickNameFront();
        }
    }
    public void choseKickNameSides()
    {
        System.Random random = new System.Random();
        int randomNumber = random.Next(1, 3);

        if (randomNumber == 1)
        {
            KickText.gameObject.GetComponent<TextMesh>().text = "Fast";
        }
        if (randomNumber == 2)
        {
            KickText.gameObject.GetComponent<TextMesh>().text = "Round House";
        }
    }
    public void choseKickNameFront()
    {
        System.Random random = new System.Random();
        int randomNumber = random.Next(1, 3);

        if (randomNumber == 1)
        {
            KickText.gameObject.GetComponent<TextMesh>().text = "Front";
        }
        if (randomNumber == 2)
        {
            KickText.gameObject.GetComponent<TextMesh>().text = "Side";
        }
        if (randomNumber == 2)
        {
            KickText.gameObject.GetComponent<TextMesh>().text = "Back";
        }
        if (randomNumber == 2)
        {
            KickText.gameObject.GetComponent<TextMesh>().text = "Back Side";
        }
    }
}
