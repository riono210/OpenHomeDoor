﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countTime : MonoBehaviour 
{

    [SerializeField]private float newseconds=30.0f;
    private float oldseconds;

    private bool gameover = false;
    bool clear = false;

    private Text timerText;

	// Use this for initialization
	void Start () 
    {
        timerText = GetComponentInChildren<Text>();
	}
	

	// Update is called once per frame
	void Update () 
    {
        TimeManager();

        if(newseconds >= 0.0 && clear != true)
        {
            gameover = true;
        }
	}


    void TimeManager()
    {
        oldseconds = newseconds;
        newseconds -= Time.deltaTime;

        if ((int)newseconds <= 4)
        {
            timerText.fontSize = 70;
            timerText.color = new Color(250f/255f, 0f/255f, 0f/255f, 255f/255f);
        }

        //intに直した時に秒数が変わっていたら表示
        if ((int)newseconds != (int)oldseconds && newseconds >= 0.0f)
        {
            Debug.Log((int)newseconds+"s");
            timerText.text = newseconds.ToString("#");

        } 
    }

}