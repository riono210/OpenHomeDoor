using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using HoloToolkit;
//using HoloToolkit.Unity.InputModule;
//using HoloToolkit.Unity.SpatialMapping;

public class FloorRecognize : MonoBehaviour {

    RaycastHit hitInfo;
    public GameObject debugObj;

    // Use this for initialization
    void Start()
    {
        
    }
	
	// Update is called once per frame
	void Update () {
#if UNITY_EDITOR && UNITY_STANDALONE_WIN
        bool hit = Physics.Raycast(GazeManager.Instance.GazeOrigin,
            GazeManager.Instance.GazeNormal, out hitInfo, 20f, SpatialMappingManager.Instance.LayerMask);

        if (hit)
        {
            GameObject surface = hitInfo.transform.gameObject;
            SurfacePlane plane = surface.GetComponent<SurfacePlane>();

            if (plane != null)
            {
                switch (plane.PlaneType)
                {
                    case PlaneTypes.Floor:
                        //Do somothing
                        Vector3 pos = new Vector3(0, 1.3f, 0);
                        Instantiate(debugObj, pos, Quaternion.identity);
                        break;
                    case PlaneTypes.Ceiling:
                        //Do somothing
                        break;
                    case PlaneTypes.Wall:
                        //Do somothing
                        break;
                    case PlaneTypes.Table:
                        //Do somothing
                        break;
                    case PlaneTypes.Unknown:
                        //Do somothing
                        break;
                }
            }
        }
#endif
    }
}
