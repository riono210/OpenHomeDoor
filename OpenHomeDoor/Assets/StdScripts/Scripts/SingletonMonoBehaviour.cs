using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour {

    private static T _Instance;

    public static T Instance{
        get{
            if(_Instance == null){
                _Instance = (T)FindObjectOfType(typeof(T));
                Debug.Log("Create " + typeof(T) + "singleton");

                if(_Instance == null){
                    Debug.LogError(typeof(T) + "is nothing");
                }
            }

            return _Instance;
        }
    }

    protected virtual void Awake() {
        CheckInstance();
    }


    protected bool CheckInstance(){
        if(this == Instance){
            return true;
        }

        Destroy(this);
        return false;
    }
}
