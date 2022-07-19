using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class saveParameters1 : MonoBehaviour
{
    public TMP_InputField inputFieldQ;
    public TMP_InputField inputFieldH;
    public TMP_InputField inputFieldn;
    public TMP_InputField inputFieldnz;
    public TMP_InputField inputFieldnz_;
    public TMP_InputField inputFieldHm;
    public TMP_InputField inputFieldnr;
    public TMP_InputField inputFieldckp;

    public float Q;
    public float H;
    public float n;
    public float nz;
    public float nz_;
    public float Hm;
    public float nr;
    public float ckp;



    void Start(){
        // initialization
        inputFieldQ.text = "1";
        inputFieldH.text = "1";
        inputFieldn.text = "1";
        inputFieldnz.text = "1";
        inputFieldnz_.text = "1";
        inputFieldHm.text = "1";
        inputFieldnr.text = "1";
        inputFieldckp.text = "1";

        //converting string to floating
        float.TryParse(inputFieldQ.text, out Q);
        float.TryParse(inputFieldH.text, out H);
        float.TryParse(inputFieldn.text, out n);
        float.TryParse(inputFieldnz.text, out nz);
        float.TryParse(inputFieldnz_.text, out nz_);
        float.TryParse(inputFieldHm.text, out Hm);
        float.TryParse(inputFieldnr.text, out nr);
        float.TryParse(inputFieldckp.text, out ckp);

        // add listener to value change of input field
        inputFieldQ.onEndEdit.AddListener(delegate { ValueChangeCheck(); });
        inputFieldH.onEndEdit.AddListener(delegate { ValueChangeCheck(); });
        inputFieldn.onEndEdit.AddListener(delegate { ValueChangeCheck(); });
        inputFieldnz.onEndEdit.AddListener(delegate { ValueChangeCheck(); });
        inputFieldnz_.onEndEdit.AddListener(delegate { ValueChangeCheck(); });
        inputFieldHm.onEndEdit.AddListener(delegate { ValueChangeCheck(); });
        inputFieldnr.onEndEdit.AddListener(delegate { ValueChangeCheck(); });
        inputFieldckp.onEndEdit.AddListener(delegate { ValueChangeCheck(); });

    }

    public void ValueChangeCheck(){
        //converting string to floating
        float.TryParse(inputFieldQ.text, out Q);
        float.TryParse(inputFieldH.text, out H);
        float.TryParse(inputFieldn.text, out n);
        float.TryParse(inputFieldnz.text, out nz);
        float.TryParse(inputFieldnz_.text, out nz_);
        float.TryParse(inputFieldHm.text, out Hm);
        float.TryParse(inputFieldnr.text, out nr);
        float.TryParse(inputFieldckp.text, out ckp);
    }
    

    void getValue(){

    }
}