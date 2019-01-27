using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMPlayer : MonoBehaviour {

    public PlayerState playerState;
    public AudioSource bgm;
    public AudioClip escapingClip;
    public AudioClip lookingForFunClip;
    public AudioClip homeSick;
    public AudioClip backHome;
    public AudioClip end1;
    public AudioClip end2;
    public AudioClip end3;

    private void Update()
    {
        switch(playerState.playerState)
        {
            case PlayerStateEnum.AtHome:
                bgm.clip = null;
                break;
            case PlayerStateEnum.Esacaping:
                bgm.clip = escapingClip;
                break;
            case PlayerStateEnum.LookingForFun:
                bgm.clip = lookingForFunClip;
                break;
            case PlayerStateEnum.HomeSick:
                bgm.clip = homeSick;
                break;
            case PlayerStateEnum.Backhome:
                bgm.clip = backHome;
                break;
                
        }
        if (!bgm.isPlaying && bgm.clip != null)
            bgm.Play();
    }

    public void PlayEnd1()
    {
        //bgm.clip = end1;
        //if (!bgm.isPlaying && bgm.clip != null)
        //    bgm.Play();
        bgm.Stop();
    }

    public void PlayEnd2()
    {
        //bgm.clip = end2;
        //if (!bgm.isPlaying && bgm.clip != null)
        //    bgm.Play();
        bgm.Stop();
    }

    public void PlayEnd3()
    {
        //bgm.clip = end3;
        //if (!bgm.isPlaying && bgm.clip != null)
        //    bgm.Play();
        bgm.Stop();
    }
}
