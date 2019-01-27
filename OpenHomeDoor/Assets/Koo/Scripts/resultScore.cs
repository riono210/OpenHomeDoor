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

	// Use this for initialization
	void Start () {
        Timer = GameObject.Find("Timer");
        countTimeScript = Timer.GetComponent<countTime>();
	}
	
	// Update is called once per frame
	void Update () {
        ClearTime = (int)countTimeScript.newseconds;
        if (isGameover == false && isClear == true)
        {
                    
        }
	}
}
