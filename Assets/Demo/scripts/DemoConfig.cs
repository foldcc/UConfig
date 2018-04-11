using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DemoConfig : ScriptableObject {

    public string userName;

    public int userID;

    public void print() {
        Debug.Log(string.Format("name: {0} id: {1}" , userName , userID));
    }
}
