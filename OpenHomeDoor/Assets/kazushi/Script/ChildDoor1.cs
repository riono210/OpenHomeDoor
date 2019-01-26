using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildDoor1 : ParentDoor {

    public override void Doors()
    {
        if (Input.GetKeyDown("a")){  //キーは小文字のみ

            GameObject Parent = transform.root.gameObject;
            Destroy(Parent);
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
