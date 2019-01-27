﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildDoor1 : ParentDoor {

    Vector3 OriginalPos;

    public float PluseXAxis;

    private void Start()
    {
        OriginalPos = transform.position;
        Debug.Log(OriginalPos);
    }

    public override void Doors()
    {
        MoveNobu();
        Debug.Log(OriginalPos);
    }

    public void MoveNobu(){

        Vector3 currentpos = transform.position;

        //float y = Mathf.Clamp(OriginalPos.y, OriginalPos.y, OriginalPos.y);
        //float z = Mathf.Clamp(OriginalPos.z, OriginalPos.z, OriginalPos.z);
        //float x = Mathf.Clamp(OriginalPos.x, OriginalPos.x, OriginalPos.x + 10.0f);

        transform.position = new Vector3(transform.position.x, OriginalPos.y, OriginalPos.z);
        if(OriginalPos.x-transform.position.x<-1.0f){
            
            Destroy(this.gameObject);
            MagicScript.Instance.Camera.GetComponent<OparateManager>().CountDoor += 1;
            MagicScript.Instance.Camera.GetComponent<OparateManager>().Opend = true;

            Debug.Log("Open");
        }
    }











    /*
    private void OnMouseDown()
    {
        //スクリーン座標。
        ScreenPos = Camera.main.WorldToScreenPoint(transform.position);
    }

public override void Doors()
    {
        if(Input.GetMouseButton(0)){

            Vector3 MovePosition =  transform.position+ Input.mousePosition;
            if(MovePosition.x>CurrentPosition.x){
                
                Destroy(this.gameObject);

            }
        }
    }

*/
}
