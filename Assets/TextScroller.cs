using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextScroller : MonoBehaviour
{
    public LyricsDataManager lyricsDataManager;
    public TextMeshProUGUI lyricsText;
    public AudioSource yanTheme;
    public int lyricsId = 0;
    public int lyricsIndex = 0;

    void Start()
    {
        Invoke("OnText", 17.5f);
        yanTheme.Play();
        lyricsText.text = "";
    }

    void Update()
    {
    }

    public void OnText()
    {
        Debug.Log("실행");
        StartCoroutine(TextScroll());
    }

    private IEnumerator TextScroll()
    {
        Debug.Log("실행2");
        string lyricsData = lyricsDataManager.GetLyrics(lyricsId, lyricsIndex);
        while (lyricsId <= 5)
        {
            lyricsData = lyricsDataManager.GetLyrics(lyricsId, lyricsIndex);
            if (lyricsData == null)
            {
                lyricsIndex = 0;
                lyricsId++;
                if (lyricsId >= 6)
                {
                    lyricsText.text = "";
                    break;
                }
            }
            lyricsData = lyricsDataManager.GetLyrics(lyricsId, lyricsIndex);
            lyricsText.text = lyricsData;
            lyricsIndex++;
            yield return new WaitForSeconds((60f/119f) * 2f);
        }

    }
}
