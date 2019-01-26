using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterConfig : MonoBehaviour {

    public float lightRange = 4f;                 //光照范围
    public float characterSpeed = 0.1f;           //主角移动速度
    public int money = 0;                         //获得的金币数
    public float happinessGetWhenEatMoney;
    public float happness = 1000f;                   //幸福值 
    public float AISpeedPercent = 0.8f;           //AI相对于主角移动的速率
    public float AISpeed;

    public characterControl characterControl;
    public lightControl lightControl;
    public AIChontroller AIChontroller;
    public UIsControl UIsControl;

	// Use this for initialization
	void Start () {
        happness = 1000f;
	}

    // Update is called once per frame
    void FixedUpdate()
    {

        AISpeed = AISpeedPercent * characterSpeed;

        //money = characterControl.money;

        if(happness >= 1000)
        {
            characterControl.happness1 = 0;
        }
        happness = UIsControl.happness + characterControl.happness1;


    }

    public void AddMoney()
    {
        money += 1;
        happness += 100f;
    }
    
}
