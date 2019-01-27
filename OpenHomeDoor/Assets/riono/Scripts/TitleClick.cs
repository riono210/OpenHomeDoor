using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using HoloToolkit.Unity.InputModule;

public class TitleClick : MonoBehaviour, IInputClickHandler {
    
	public GameObject camela;

	// クリック
	public void OnInputClicked(InputClickedEventData eventData)
    {
		RaycastHit hit = GazeManager.Instance.HitInfo;
        GameObject hitObj = GazeManager.Instance.HitObject;
		//Debug.Log("ojg;"+ hitObj.name);

		if(hitObj.name == "StartButton"){
			Destroy(camela);
			SceneManager.LoadScene("SpatialProcessing 1");
		}

        //throw new System.NotImplementedException();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
