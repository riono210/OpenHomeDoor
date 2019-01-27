using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildDoor1 : ParentDoor {

    private void Start()
    {
    }

    public override void Doors()
    {
        if (Input.GetKeyDown("a")){  //キーは小文字のみ

            GameObject Parent = transform.root.gameObject;
            Destroy(Parent);
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
