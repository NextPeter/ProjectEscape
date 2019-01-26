using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightControl : MonoBehaviour {

    public float range;
    public float homeRange;
    public float chaseMinRange;
    public float chaseIncreaseByTime;
    public float chaseMaxRange;
    public float freedomRange;
    public float homesickByHappinessRatio;
    public float homeSickMinRange;
    Transform trans;

    public Transform home;

    public characterConfig characterConfig;

    public bool swth;
    public PlayerState playerState;

    void Awake()
    {
        swth = false;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(playerState.playerlocation == "A")
        {
            swth = true;
        }

        if (swth == false )
        {
            
            range = characterConfig.lightRange*0.1f *(transform.position.x - home.transform.position.x ) ;     //从characterConfig获取光照范围
        }
        else
        {

            range = range - 0.01f * Time.deltaTime;

            if(range <= minRange)
            {
                range = minRange;
                
            }
        }


       

        transform.localScale = new Vector3(range, range, range);
	}
}
