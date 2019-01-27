using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSinglton : SingletonMonoBehaviour<ManagerSinglton>
{
    public int planeNum;
    public NotificationObject<bool> doorExist;
    public Vector3 doorPos;

    public bool once = true;

	// Use this for initialization
	void Start () {
       

    }

    // Update is called once per frame
    void Update () {

    }

    protected override void Awake()
    {
        base.Awake();

        planeNum = 0;
        doorExist = new NotificationObject<bool>(false);
        doorPos = Vector3.zero;
    }
}
