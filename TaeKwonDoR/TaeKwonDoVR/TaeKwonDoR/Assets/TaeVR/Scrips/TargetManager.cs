using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour {

    public int score;
   
    public GameObject KickBadTargerGen;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void enableTarget()
    {
        gameObject.SetActive(true);
    }
    public void disableTarget()
    {
        gameObject.SetActive(false);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("foot"))
        {

        }
        disableTarget();
        KickBadTargerGen.gameObject.GetComponent<KickGabTargetGenreation>().trigger = true;
    }
    //public void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.tag == ("foot"))
    //    {

    //    }
    //    disableTarget();
    //    KickBadTargerGen.gameObject.GetComponent<KickGabTargetGenreation>().trigger = true;
    //}
}
