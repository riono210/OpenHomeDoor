using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvastext : MonoBehaviour {

    private Text scoreText;

    private bool isGameover = false;
    private bool isClear = false;

    private countTime countTimeScript;
    private OparateManager oparateManagerScript;
    public GameObject MainCamera;
    private GameObject Timer;

	// Use this for initialization
	void Start () {
        Timer = GameObject.Find("Timer");
        countTimeScript = Timer.GetComponent<countTime>();
        
        MainCamera = GameObject.Find("MainCamera");
        oparateManagerScript = MainCamera.GetComponent<OparateManager>();

        scoreText = this.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        
        Timer = GameObject.Find("Timer");
        countTimeScript = Timer.GetComponent<countTime>();

        isClear = oparateManagerScript.GameClear;
        isGameover = countTimeScript.gameover;

        if (isClear == true)
        {
            scoreText.text = countTimeScript.newseconds.ToString("#");
        }

        else if (isGameover == true)
        {
            scoreText.text = oparateManagerScript.CountDoor.ToString("#");
        }
	}
}
