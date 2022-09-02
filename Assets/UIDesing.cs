using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIDesing : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI lyricsChangeBtnTMP;
    [SerializeField]
    GameObject lyricsTMP;
    string lyricsChangeBtnText = "가사 <color=#73BDFF>On</color>/Off";
    private bool isLyricsOn = true;

    private void Awake()
    {
        lyricsChangeBtnTMP.text = lyricsChangeBtnText;
        lyricsTMP.SetActive(isLyricsOn);
    }

    public void OnClickLyricsBtn()
    {
        isLyricsOn = !isLyricsOn;
        if(isLyricsOn)
        {
            lyricsChangeBtnText = "가사 <color=#73BDFF>On</color>/Off";
        }
        else
        {
            lyricsChangeBtnText = "가사 On/<color=#73BDFF>Off</color>";
        }
        lyricsTMP.SetActive(isLyricsOn);
        lyricsChangeBtnTMP.text = lyricsChangeBtnText;
    }
}
