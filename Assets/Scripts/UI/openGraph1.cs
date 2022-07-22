//using AnotherFileBrowser.Windows;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using SFB;
using System.IO;

public class openGraph1 : MonoBehaviour
{
    public RawImage output1;
    public RawImage output2;
    public Canvas canvas;

#if UNITY_WEBGL && !UNITY_EDITOR
    //
    // WebGL
    //
    [DllImport("__Internal")]
    private static extern void UploadFile(string gameObjectName, string methodName, string filter, bool multiple);

    public void OnPointerDown(PointerEventData eventData) {
        UploadFile(gameObject.name, "OnFileUpload", "png", false);
    }

    // Called from browser
    public void OnFileUpload(string url) {
        StartCoroutine(OutputRoutine(url));
    }
#else
    //
    // Standalone platforms & editor
    //
    public void OnPointerDown(PointerEventData eventData) { }

    public void getGraphs() {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    public void OnClick() {        
        //var path1 = Path.Combine(Application.streamingAssetsPath, "g1.png");
        //StartCoroutine(OutputRoutine(new System.Uri(path1).AbsoluteUri));
        StartCoroutine(CoroutineAction());
    }
#endif

    public IEnumerator OutputRoutine(string url, RawImage output) {
        var loader = new WWW(url);
        yield return loader;
        output.texture = loader.texture;
    }

    public static IEnumerator Frames(int frameCount)
    {
        while (frameCount > 0)
        {
            frameCount--;
            yield return null;
        }
    }


    public IEnumerator CoroutineAction(){
        canvas.enabled = true;

        yield return StartCoroutine(Frames(60));

        var path1 = Path.Combine(Application.streamingAssetsPath, "g1.png");
        StartCoroutine(OutputRoutine(new System.Uri(path1).AbsoluteUri, output1));

        var path2 = Path.Combine(Application.streamingAssetsPath, "g2.png");
        StartCoroutine(OutputRoutine(new System.Uri(path2).AbsoluteUri, output2));

        yield return StartCoroutine(Frames(60));

        canvas.enabled = false;

    }

}
