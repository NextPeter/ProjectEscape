using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endTrigger : MonoBehaviour {
    //用于触发故事结局

    public AIChontroller AIChontroller;

    public DiamondA DiamondA;
    public DiamondB DiamondB;
    public DiamondC DiamondC;
    public PlayerState PlayerState;


    public bool backHome = false;

    public characterConfig characterConfig;
    public GameObject AI1;
    public GameObject AI2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //=========================================================================================
        if(DiamondA.DiamondAGet == true)
        {
            if(DiamondB.DiamondBGet == false)
            {
                if(DiamondC.DiamondCGet == false)
                {
                    AI1.SetActive(false);
                    AI2.SetActive(true);
                    if (PlayerState.playerlocation == "Home")    //同时满足拿到钻石A并且回家
                    {

                        //此时触发第一个剧情  
                        Debug.Log("第一剧情达成");
                    }
                }
            }
            
        }
        //===========================================================================================
        if (AIChontroller.catchPlayer == true)
        {
            //触发游戏结束
            Debug.Log("被抓住了");
        }
        //========================================================================================
        if(DiamondB.DiamondBGet == true)
        {
            AI1.SetActive(false);
            AI2.SetActive(false);
            if(PlayerState.playerlocation == "Home")
            {
                //回到家触发剧情妈妈去世了
                Debug.Log("第二剧情达成");
            }
        }
        //========================================================================================
        if(DiamondC.DiamondCGet == true)
        {
            
            //触发剧情 无法回家 迷失
            Debug.Log("第三剧情达成");
        }
        //============================================================================================
        if(characterConfig.curHappiness < 300)
        {
            backHome = true;
            if(PlayerState.playerlocation == "Home")
            {
                backHome = false;
            }
        }
	}
}
