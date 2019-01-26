using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentDoor : MonoBehaviour {

    private SceneManager SceneManager;

    public virtual void Start()
    {
        SceneManager = GameObject.Find("MainCamera").GetComponent<SceneManager>();
    }
    public virtual void Doors(){

    }

    public void DestroyDoor(){

        Debug.Log("Success");
        Destroy(this.gameObject);
    }
}
