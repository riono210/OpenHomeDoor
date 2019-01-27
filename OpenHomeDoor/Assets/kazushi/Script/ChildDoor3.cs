﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildDoor3 : ParentDoor {

    public override void Doors()
    {
        if (Input.GetKeyDown("d")){  //キーは小文字のみ

            //GameObject Parent = transform.root.gameObject;
            Destroy(this.gameObject);
            MagicScript.Instance.Camera.GetComponent<OparateManager>().CountDoor += 1;
            MagicScript.Instance.Camera.GetComponent<OparateManager>().Opend = true;

            Debug.Log("Open");
        }
    }
}
