using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class exitApp : MonoBehaviour
{
    // Update is called once per frame
    public void quit(){
        //EditorApplication.isPlaying = false;                    // stop the game in the editor
        Application.Quit();                                     // stop the game in build
    }
}
