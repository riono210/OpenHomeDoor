using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resultScore : MonoBehaviour {

    private bool isGameover = false;
    private bool isClear = false;
    private float ClearTime = 0.0f;
    private GameObject Timer;
    private countTime countTimeScript;
    private OparateManager oparateManagerScript;
    public  GameObject MainCamera;

    public GameObject ClearCanvas;
    public GameObject gameOverCanvas;

	// Use this for initialization
	void Start () {
        Timer = GameObject.Find("Timer");
        countTimeScript = Timer.GetComponent<countTime>();

        MainCamera = GameObject.Find("MainCamera");
        oparateManagerScript = MainCamera.GetComponent<OparateManager>();

	}
	
	// Update is called once per frame
	void Update () {
        
        isClear = oparateManagerScript.GameClear;
        ClearTime = (int)countTimeScript.newseconds;
        isGameover = countTimeScript.gameover;

        if (isClear == true)
        {
            Instantiate(ClearCanvas);
        }

        else if(isGameover == true)
        {
            Instantiate(gameOverCanvas); 
        }
	}
}
