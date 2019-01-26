using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightControl : MonoBehaviour {

    public float range; 
    Transform trans;

    public Transform home;


    public characterConfig characterConfig;

    public bool swth;
    public playerState playerState;


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

            range = range - 0.01f;

            if(range <= 2)
            {
                range = 2;
                
            }
        }


       

        transform.localScale = new Vector3(range, range, range);
	}
}
