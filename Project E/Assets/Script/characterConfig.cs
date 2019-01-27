using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterConfig : MonoBehaviour {

    public float characterSpeed = 0.1f;           //主角移动速度
    public int money = 0;                         //获得的金币数
    public float happinessGetWhenEatMoney;
    public float maxHappiness = 1000f;
    //public float happinessIncreaseNearHome = 5f;
    //public float happinessDecreaseAwayFromHome = 1.5f;
    public float curHappiness = 1000f;                   //幸福值 
    public float happinessAtHome = 200f;
    public float maxHappinessWhenEscape = 800f;
    public float happinessIncreaseWhenEscape;
    public float happinessIncreaseWhenFreedom;
    public float happinessDecreaseWhenHomesick;


    public float AISpeedPercent = 0.8f;           //AI相对于主角移动的速率

    public characterControl characterControl;
    public PlayerState playerState;
    public lightControl lightControl;
    public AIChontroller AIChontroller;

	// Use this for initialization
	void Start () {
        
	}

    // Update is called once per frame
    void Update()
    {
        switch (playerState.playerState)
        {
            case PlayerStateEnum.AtHome:
                curHappiness = happinessAtHome;
                break;
            case PlayerStateEnum.Esacaping:
                curHappiness = Mathf.Clamp(curHappiness + happinessIncreaseWhenEscape * Time.deltaTime, 0f, maxHappinessWhenEscape);
                break;
            case PlayerStateEnum.LookingForFun:
                curHappiness = Mathf.Clamp(curHappiness + happinessIncreaseWhenFreedom * Time.deltaTime, 0f, maxHappiness);
                break;
            case PlayerStateEnum.HomeSick:
                curHappiness = Mathf.Clamp(curHappiness - happinessDecreaseWhenHomesick * Time.deltaTime, happinessAtHome, maxHappiness);
                
                break;
        }

        //if (playerState.playerlocation == "Home" || playerState.playerlocation == "Chase")
        //{
        //    curHappiness = curHappiness + happinessIncreaseNearHome * Time.deltaTime;
        //}
        //else
        //{
        //    curHappiness = curHappiness - happinessDecreaseAwayFromHome * Time.deltaTime;
        //}
        //curHappiness = Mathf.Clamp(curHappiness, 0f, maxHappiness);
    }

    public void AddMoney()
    {
        money += 1;
        curHappiness += happinessGetWhenEatMoney;
    }
    
    public void DataReset()
    {
        curHappiness = maxHappiness;
    }
}
