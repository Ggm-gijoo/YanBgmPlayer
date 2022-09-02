using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using TMPro;

public class ColorChange : MonoBehaviour
{
    SpriteRenderer colorCube;
    [SerializeField]
    SpriteRenderer colorBackgroundImage;
    [SerializeField]
    VolumeProfile volumeProfile;
    [SerializeField]
    TextMeshProUGUI textLyrics;
    Bloom bloom;
    Gradient gradient;
    float angle = 0f;
    [SerializeField]
    float bloonInt = 0f;
    float volumeInt = 0f;
    void Start()
    {
        colorCube = GetComponent<SpriteRenderer>();
        volumeProfile.TryGet(out bloom);
    }

    void Update()
    {
        angle += (float)System.Math.Round(1 / 360f, 5) * Time.deltaTime * 40f;
        volumeInt += Time.deltaTime * 2;
        if(angle >= 1f)
        {
            angle -= 1f;
        }
        bloom.intensity.Override((float)((0.5 * Mathf.Sin(volumeInt - Mathf.PI/2)) + 0.5f) * bloonInt + 5f);
        colorCube.color = Color.HSVToRGB(angle,0.2f,1f);
        colorBackgroundImage.color = Color.HSVToRGB(angle, 0.3f, 1f);
        textLyrics.color = Color.HSVToRGB(angle, 0.2f, 1f);
        Camera.main.backgroundColor = Color.HSVToRGB(angle, 0.3f, 0.2f);
    }
}
