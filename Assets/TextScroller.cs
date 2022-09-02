using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("OnText", 17.5f);
    }

    void Update()
    {
    }

    public void OnText()
    {
        StartCoroutine(TextScroll());
    }

    private IEnumerator TextScroll()
    {
        yield return new WaitForSeconds(4f);

    }
}
