using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class goHome : MonoBehaviour {

    private AudioSource decideSound;

	
	void Start () {
        decideSound = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        decideSound.PlayOneShot(decideSound.clip);
        Invoke(("LoadTitle"), 0.7f);
    }

    public void LoadTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
