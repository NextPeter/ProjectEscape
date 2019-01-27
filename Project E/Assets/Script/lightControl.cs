using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;

public class lightControl : MonoBehaviour {

    public float range;

    public float homeRange;
    public float chaseMinRange;
    public float chaseIncreaseByTime;
    public float chaseMaxRange;
    public float freedomMinRange;
    public float freedomIncreaseByTime;
    public float freedomMaxRange;
    public float homeSickMaxRange;
    public float homeSickMinRange;
    Transform trans;

    public Transform home;

    public characterConfig characterConfig;

    public bool isTweening;
    public PlayerState playerState;

    void Awake()
    {
        isTweening = false;
    }
    // Use this for initialization
    void Start () {
		
	}

    float chaseOutTime;
    
	// Update is called once per frame
	void Update () {
        if(!isTweening)
        {
            float happinessLightRangeRatio = (homeSickMaxRange - homeSickMinRange) / characterConfig.maxHappiness;
            switch (playerState.playerState)
            {
                case PlayerStateEnum.AtHome:
                    //range = homeRange;
                    range = Mathf.Clamp(characterConfig.curHappiness * happinessLightRangeRatio, homeSickMinRange, homeSickMaxRange);
                    break;
                case PlayerStateEnum.Esacaping:
                    //range = Mathf.Clamp(range + chaseIncreaseByTime * Time.deltaTime, chaseMinRange, chaseMaxRange);
                    range = Mathf.Clamp(characterConfig.curHappiness * happinessLightRangeRatio, homeSickMinRange, homeSickMaxRange);
                    break;
                case PlayerStateEnum.LookingForFun:
                    //range = Mathf.Clamp(range + freedomIncreaseByTime * Time.deltaTime, freedomMinRange, freedomMaxRange);
                    range = Mathf.Clamp(characterConfig.curHappiness * happinessLightRangeRatio, homeSickMinRange, homeSickMaxRange);
                    break;
                case PlayerStateEnum.HomeSick:
                    range = Mathf.Clamp(characterConfig.curHappiness * happinessLightRangeRatio, homeSickMinRange, homeSickMaxRange);
                    break;
                case PlayerStateEnum.Backhome:
                    break;
            }
            
        }
        transform.localScale = new Vector3(range, range, 1f);
    }

    public void SetToZero(System.Action _whenFadeOut, Action _whenFadeIn)
    {
        Sequence seq = DOTween.Sequence();
        isTweening = true;
        seq.Append(DOTween.To(() => range, (x) => range = x, 0f, 2f));
        seq.AppendCallback(() => _whenFadeOut.Invoke());
        seq.Append(DOTween.To(() => range, (x) => range = x, 0f, 2f));
        seq.AppendCallback(() => _whenFadeIn.Invoke());
    }
}
