using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildDoor2_Holo : ParentDoor{
    
    Vector3 OriginalPos;

    //public float PluseXAxis;

    private void Start()
    {
        OriginalPos = transform.position;
        Debug.Log(OriginalPos);
    }
    private void Update()
    {
        MoveNobu();
        //Vector3 Uncheged2 = MagicScript.Instance.Camera.GetComponent<OparateManager>().UnChenged;
    }
    public override void Doors()
    {
        MoveNobu();
        Debug.Log(OriginalPos);
    }

    public void MoveNobu()
    {

        Vector3 currentpos = transform.position;

        //float y = Mathf.Clamp(OriginalPos.y, OriginalPos.y, OriginalPos.y);
        //float z = Mathf.Clamp(OriginalPos.z, OriginalPos.z, OriginalPos.z);
        //float x = Mathf.Clamp(OriginalPos.x, OriginalPos.x, OriginalPos.x + 10.0f);

        float x = Mathf.Clamp(transform.position.x, OriginalPos.x- 10.0f, OriginalPos.x);
        
        transform.position = new Vector3(x, OriginalPos.y, OriginalPos.z);
        if (OriginalPos.x - transform.position.x > +3.0f)
        {
            
            Destroy(this.gameObject);
            MagicScript.Instance.Camera.GetComponent<OparateManager_Holo>().CountDoor += 1;
            MagicScript.Instance.Camera.GetComponent<OparateManager_Holo>().Opend = true;

            Debug.Log("Open");
        }
    }

}
