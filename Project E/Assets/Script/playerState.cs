using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerState : MonoBehaviour {

    public string playerlocation;

    public areaHome areaHome;
    public areaChase areaChase;
    public areaA areaA;
    public areaB areaB;
    public areaC areaC;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (areaHome.playerInHome == true)
        {
            playerlocation = "Home";
            return;
        }
        if (areaChase.playerInChase == true)
        {
            playerlocation = "Chase";
            return;
        }
        if (areaA.playerInA == true)
        {
            playerlocation = "A";
            return;
        }
        if (areaB.playerInB == true)
        {
            playerlocation = "B";
            return;
        }
        if (areaC.playerInC == true)
        {
            playerlocation = "C";
            return;
        }




    }
}
