using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OparateManager_Holo: MonoBehaviour
{
    //private Door Door;
    //public  Vector3 UnChenged;
    [SerializeField] private int HowManyDoors;
    public int CountDoor;
    private ParentDoor ParentDoor;
    public bool Opend;
   
    public LayerMask LayerMaskOfDoor;
    public GameObject Door1Prefab;
    public GameObject Door2Prefab;
    public GameObject Door3Prefab;
    public GameObject Door4Prefab;
    public GameObject Door5Prefab;
    public GameObject Door6Prefab;


    private Vector3 doorPos;

    void Start()
    {
        //UnChenged = new Vector3(0, 0, 0);
        CountDoor = 0;
        ParentDoor = GetComponent<ParentDoor>();
        MagicScript.Instance.Camera = this.gameObject;
        Debug.Log(this.gameObject);
        //Opend = true;
    }

    void Update()
    {
        
        if(CountDoor == HowManyDoors){
            
        }
        else if(Opend){
            SpownDoor();
        }
        OpenDoor();
    }

    public void OpenDoor()
    {

        // Ray MouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        // RaycastHit hit;  //ヒットしたオブジェクトの情報を格納する。

        // rayの設定
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        GameObject hitObj = GazeManager.Instance.HitObject;
        RaycastHit hit = GazeManager.Instance.HitInfo;
        //Debug.Log("name:" + hitObj.name);
        if (hitObj != null && hitObj.name == "door_handle 1")  //outでオブジェクトの情報を得る。
        {
            //Debug.DrawRay(MouseRay.origin, MouseRay.direction, Color.red,100.0f);
            Debug.Log("hit");
            hit.collider.GetComponent<ParentDoor>().Doors();

        }
    }

    public void SpownDoor(){
        doorPos = ManagerSinglton.Instance.doorPos;
        int rand = (int)Random.Range(1, 6);
        switch (rand)
        {
            case 1:
                Instantiate(Door1Prefab,doorPos, Quaternion.Euler(0,-90,0));
                //UnChenged = Door1Prefab.transform.position;
                break;
            case 2:
                Instantiate(Door2Prefab,doorPos, Quaternion.Euler(0,-90,0));
                break;
            case 3:
                Instantiate(Door3Prefab,doorPos, Quaternion.Euler(0,-90,0));
                break;
            case 4:
                Instantiate(Door4Prefab,doorPos, Quaternion.Euler(0,-90,0));
                break;
            case 5:
                Instantiate(Door5Prefab,doorPos, Quaternion.Euler(0,-90,0));
                break;
            case 6:
                Instantiate(Door6Prefab,doorPos, Quaternion.Euler(0,-90,0));
                break;
        }
        Opend = false;
    }
}

    






