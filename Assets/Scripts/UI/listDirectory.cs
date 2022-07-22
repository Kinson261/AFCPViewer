using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class listDirectory : MonoBehaviour
{
    string path;
    string[] files;
    public TMP_Text text;
    public getDateAndTime m_date;

    void Start(){
        text = GetComponent<TMP_Text>();
        string date = m_date.date;
        path = @Application.streamingAssetsPath  + "/../../SavedModels/" + date;
        
    }


    void Update(){
        /*files = Directory.GetFiles(path, ".", SearchOption.AllDirectories);
        string text = "";
        foreach (string file in files)
        {
            text += file + "\n\n";
        }
        this.text.text = text;*/

        string text = "";
        string[] root = Directory.GetFiles(path);
        foreach (string file in root)
        {
            //string nameObj = file.Split('\\')[file.Split('\\').Length - 1];
            //text += nameObj + "\n\n";
            text += file + "\n\n\n";
        }


        string[] folders = Directory.GetDirectories(path);
        foreach (string folder in folders)
        {
            text += folder + "\\\n";
            files = Directory.GetFiles(folder, ".", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                string[] name = file.Split('\\');
                text += "        " + name[name.Length-1] + "\n";
            }
            text += "\n\n\n";
        }
        this.text.text = text;
        
    }
}

