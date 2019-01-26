using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildDoor3 : ParentDoor {

	

    public override void Doors()
    {
        if (Input.GetKeyDown("d"))
        {  //キーは小文字のみ

            GameObject Parent = transform.root.gameObject;
            Destroy(Parent);
            Debug.Log("Open");
        }
    }
}
