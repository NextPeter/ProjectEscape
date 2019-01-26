using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerStateEnum
{
    AtHome,
    Esacaping,
    LookingForFun,
    HomeSick,
    Backhome,
}

public class PlayerState : MonoBehaviour {

    public PlayerStateEnum playerState = PlayerStateEnum.AtHome;
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

        switch(playerState)
        {
            case PlayerStateEnum.AtHome:
                if(playerlocation == "Chase")
                {
                    playerState = PlayerStateEnum.Esacaping;
                }
                break;
            case PlayerStateEnum.Esacaping:
                if (playerlocation == "")
                {
                    playerState = PlayerStateEnum.Esacaping;
                }
                break;
            case PlayerStateEnum.LookingForFun:
                break;
            case PlayerStateEnum.HomeSick:
                break;
            case PlayerStateEnum.Backhome:
                break;
        }
    }
}
