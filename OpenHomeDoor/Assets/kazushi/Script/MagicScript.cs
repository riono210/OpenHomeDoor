using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicScript : SingletonMonoBehaviour<MagicScript> {

    public GameObject Camera;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    protected override void Awake()
    {
        base.Awake();
        Camera = null;

    }
}
