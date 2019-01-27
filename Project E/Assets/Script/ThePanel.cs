using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThePanel : MonoBehaviour {

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
            UIEvt_PanelHide();
    }

    public void UIEvt_PanelHide()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
