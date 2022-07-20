using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;


public class saveGraph1 : MonoBehaviour
{
    public RawImage graph;
    public string path;

    public string date;
    public getDateAndTime m_date;

    public void SaveGraph()
    {
        graph = GetComponent<RawImage>();
        date = m_date.date;
        Directory.CreateDirectory(Application.streamingAssetsPath  + "/" + date + "/Graphs/");

        //path = StandaloneFileBrowser.SaveFilePanel("Save File", "", "graph", "png");
        path = Application.streamingAssetsPath  + "/" + date + "/Graphs/g1.png";
        if (path != null)
        {
            Texture2D frameTexture = (Texture2D)graph.mainTexture;
            Texture2D tex = new Texture2D(graph.texture.width, graph.texture.height);
            
            tex.SetPixels(frameTexture.GetPixels());
            tex.Apply();
            File.WriteAllBytes(path, tex.EncodeToPNG());
        }
    }
}
