using System;
using System.Collections;
using UnityEngine;

[System.Serializable]
public class NotificationObject<T> {
    // ex: bool hoge = new  NotificationObject<bool>(true);


    // 使っていない
    public delegate void NotificationAction (T t);

    private T data;

    public NotificationObject (T t) {
        Value = t;
    }

    public NotificationObject () { }

    // デストラクタ
    ~NotificationObject () {
        Dispose ();
    }

    public UnityEngine.Events.UnityAction<T> action;

    public T Value {
        get {
            return data;
        }
        set {
            data = value;
            Notice ();
        }
    }

    private void Notice () {
        if (action != null)
            action (data);
    }

    public void Dispose () {
        action = null;
    }
}