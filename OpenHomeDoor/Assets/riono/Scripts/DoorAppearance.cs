using HoloToolkit.Unity.SpatialMapping;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAppearance : MonoBehaviour {

    public GameObject door;
    public GameObject camera;
    public GameObject floorParent;

    private void Awake()
    {
        ManagerSinglton.Instance.doorExist.action += DoorCreate;
    }

    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DoorCreate(bool isdoor)
    {
        Vector3 doorPos = camera.transform.forward;
        Vector3 floorPos = Vector3.zero;
        //Debug.Log("floor;" + floorParent.name);
        //Debug.Log("floor;" + floorParent.transform.childCount);

        float doorSizeY = door.transform.localScale.y  / 2;
        var planes = floorParent.GetComponentInChildren<Transform>();
        foreach(Transform value in planes)
        {

            SurfacePlane child = value.GetComponent<SurfacePlane>();
            Debug.Log("scerch..." + child.PlaneType);

            if (child.PlaneType == PlaneTypes.Floor)
            {
                floorPos = value.position;

                Debug.Log("find!");
                break;
            }
        }
        doorPos = new Vector3(doorPos.x, floorPos.y + doorSizeY  , doorPos.z + 1f);
        Instantiate(door,doorPos, Quaternion.identity);
    }
}
