﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadScene : MonoBehaviour {

    public string sceneName;
    public ScreenFade screenFade;
    public bool fadeIn = true;
    void Start()
    {
        screenFade = GameObject.Find("ScreenFade").GetComponent<ScreenFade>();
    }

    // Use this for initialization
    public void LoadScene ()
    {
        screenFade.gameObject.SetActive(true);
        screenFade.Fade(fadeIn);
        Invoke("Load", screenFade.fadeTime);
	}

    void Load()
    {
        SceneManager.LoadScene(sceneName);
    }

}
