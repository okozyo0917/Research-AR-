using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogSystemScript : MonoBehaviour
{
    static public int VoiceLog=0;
    static public int TextLog=0;
    static public int LaungageLog=0;
    static public int WindowLog=0;
    static public int GimicLog=0;

    [Header("ログを書き換えるテキスト")]
    public Text Logdata1;
    public Text Logdata2;
    public Text Logdata3;
    public Text Logdata4;
    public Text Logdata5;
    
    [Header("ログデータ表示のUI")]
    public GameObject UI5;

    int flags = 0;

    void Start()
    {
        Logdata1.text = "音声ガイドを再生した数・・・"+VoiceLog+"回";
        Logdata2.text = "文字ガイドを開いた数・・・" + TextLog + "回";
        Logdata3.text = "窓に触れた数・・・" + WindowLog + "回";
        Logdata4.text = "窓以外のギミックに触れた数・・・" + GimicLog + "回";
        Logdata5.text = "言語切り替えを使った数・・・" + LaungageLog + "回";
    }

    void Update()
    {
        //Logdata5.text = "x"+ TouchMenuScript.positionx +"y"+ TouchMenuScript.positiony + "z"+ TouchMenuScript.positionz;
    }
    public void Log()
    {
        if (flags == 0)
        {
            UI5.SetActive(true);
            flags = 1;
            return;
        }
        if (flags == 1)
        {
            UI5.SetActive(false);
            flags = 0;
            return;
        }
    }

}
