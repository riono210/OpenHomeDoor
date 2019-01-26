using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countTime : MonoBehaviour 
{

    [SerializeField]private float newseconds=30.0f;
    private float oldseconds;

    private bool gameover = false;
    bool clear = false;
    private bool startFlag = false;

    private Text timerText;
    private AudioSource sound01;

	// Use this for initialization
	void Start () 
    {
        timerText = GetComponentInChildren<Text>();
        sound01 = this.GetComponent<AudioSource>();
	}
	

	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown("s"))
        {
            startFlag = true;
        }

        if (startFlag == true)
        {
            TimeManager();
        }

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
            sound01.PlayOneShot(sound01.clip);

        } 
    }

}
