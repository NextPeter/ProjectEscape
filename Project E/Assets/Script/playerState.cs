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

    public UIsControl ui;
    public GameObject cannotGetBackCollider2D;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (areaHome.playerInHome == true)
        {
            playerlocation = "Home";
        }
        else if (areaChase.playerInChase == true)
        {
            playerlocation = "Chase";
        }
        else if (areaA.playerInA == true)
        {
            playerlocation = "A";
        }
        else if (areaB.playerInB == true)
        {
            playerlocation = "B";
        }
        else if (areaC.playerInC == true)
        {
            playerlocation = "C";
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
                if (playerlocation == "Home")
                {
                    playerState = PlayerStateEnum.AtHome;
                }
                if (playerlocation == "A")
                {
                    Time.timeScale = 0;
                    ui.panelFreedom.SetActive(true);
                    playerState = PlayerStateEnum.LookingForFun;
                    //cannotGetBackCollider2D.SetActive(true);
                }
                break;
            case PlayerStateEnum.LookingForFun:
                if (playerlocation == "B")
                {
                    //Time.timeScale = 0;

                    playerState = PlayerStateEnum.HomeSick;
                    //cannotGetBackCollider2D.SetActive(false);
                }
                break;
            case PlayerStateEnum.HomeSick:
                if (playerlocation == "Home")
                {
                    playerState = PlayerStateEnum.HomeSick;
                }
                break;
            case PlayerStateEnum.Backhome:
                break;
        }

    }

    public void DataReset()
    {
        playerState = PlayerStateEnum.AtHome;
    }
}
