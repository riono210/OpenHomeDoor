using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentDoor : MonoBehaviour {
    

    public virtual void Doors(){

    }

    public void DestroyDoor(){

        Debug.Log("Success");
        Destroy(this.gameObject);
    }
}
