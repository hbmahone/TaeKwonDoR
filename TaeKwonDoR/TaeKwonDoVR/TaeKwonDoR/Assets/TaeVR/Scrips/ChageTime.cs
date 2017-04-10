using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChageTime : MonoBehaviour {

    public GameObject timer;
    //public GameObject SceneManager;
	// Use this for initialization
	void Start () {

        timer.gameObject.GetComponent<TextMesh>().text = "Hello";
    }

    float timeLeft = 15.0f;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft > 0)
        {
            timer.gameObject.GetComponent<TextMesh>().text = timeLeft.ToString().Substring(0, 4);

        }
        else
        {
            gameObject.GetComponent<KickGabTargetGenreation>().isOn = false;
        }
    }
}
