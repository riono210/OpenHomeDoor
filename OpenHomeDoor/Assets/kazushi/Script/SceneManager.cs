using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    //private Door Door;
    private ParentDoor ParentDoor;
    public LayerMask LayerMaskOfDoor;

    void Start()
    {
        //Door = GameObject.Find("Door").GetComponent<Door>();
        ParentDoor = GetComponent<ParentDoor>();
    }

    void Update()
    {
        OpenDoor();
    }

    public void OpenDoor()
    {

        Ray MouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;  //ヒットしたオブジェクトの情報を格納する。

        if (Physics.Raycast(MouseRay, out hit, Mathf.Infinity, LayerMaskOfDoor))  //outでオブジェクトの情報を得る。
        {
            hit.collider.GetComponent<ParentDoor>().Doors();
                /*
            if (hit.collider.name == "Door1" && Input.GetKeyDown("A"))
            {
                ParentDoor.DestroyDoor();
                Debug.Log("Open");
            }
            else if (hit.collider.name == "Door2" && Input.GetKeyDown("S"))
            {
                ParentDoor.DestroyDoor();
            }
            else if (hit.collider.name == "Door3" && Input.GetKeyDown("D"))
            {
                ParentDoor.DestroyDoor();
            }
            else if (hit.collider.name == "Door4" && Input.GetKeyDown("F"))
            {
                ParentDoor.DestroyDoor();
            }
            else if (hit.collider.name == "Door5" && Input.GetKeyDown("G"))
            {
                ParentDoor.DestroyDoor();
            }
            else if (hit.collider.name == "Door6" && Input.GetKeyDown("H"))
            {
                ParentDoor.DestroyDoor();
            }
*/

            //ParentDoor.Doors();
            //Debug.Log("hit");
            //ClickDoor();
        }
    }

    private void ClickDoor()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Open");
        }
    }
        //Debug.DrawRay(MouseRay.origin, MouseRay.direction, Color.red);
}



