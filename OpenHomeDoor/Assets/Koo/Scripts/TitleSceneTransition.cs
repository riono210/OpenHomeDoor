using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneTransition : MonoBehaviour
{

    private AudioSource decideSound;

    private void Start()
    {
        decideSound = this.GetComponent<AudioSource>();
    }

    public void OnClick(int number)
    {
        {
            switch (number)
            {

                case 0:
                    decideSound.PlayOneShot(decideSound.clip);

                    Invoke(("LoadGameMain"), 0.7f);
                    break;
                case 1:
                    decideSound.PlayOneShot(decideSound.clip);

                    Invoke(("LoadHowto"), 0.7f);
                    break;
                default:
                    break;
            }
        }
    }
    
    public void LoadHowto()
    {
        SceneManager.LoadScene("Howto");
    }

    public void LoadGameMain()
    {
        SceneManager.LoadScene("TestUI");
    }


}