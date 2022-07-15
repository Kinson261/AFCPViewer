using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using SFB;
using Dummiesman;

public class openFile : MonoBehaviour
{
    GameObject loadedObject;
    private string _path;
    string[] path;
    string error = string.Empty;
    public Texture2D texture;

    public void OpenExplorer(){
        path = StandaloneFileBrowser.OpenFilePanel("Open File", "", "obj", true);
        WriteResult(path[0]);

        if (!File.Exists(path[0])){
            error = "File " + path[0] + " does not exist";
        }
        else{
            if (loadedObject != null){
                Destroy(loadedObject);
            }
            loadedObject = new OBJLoader().Load(path[0]);
            loadedObject.tag = "model3d";
            error = string.Empty;

            loadedObject = loadedObject.transform.GetChild(0).gameObject;

            //get shader object
            Shader shader = Shader.Find("Diffuse");
            //set shader to object
            loadedObject.GetComponent<Renderer>().material.shader = shader;
            loadedObject.GetComponent<Renderer>().material.mainTexture = texture;
            //set color to object
            loadedObject.GetComponent<Renderer>().material.color = Color.white;

        }
    }


    public void WriteResult(string[] paths) {
        if (paths.Length == 0) {
            return;
        }

        _path = "";
        foreach (var p in paths) {
            _path += p + "\n";
        }
    }

    public void WriteResult(string path) {
        _path = path;
    }
}
