using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class SeasonChanger : MonoBehaviour
{
    public GameObject GrassTop;
    public GameObject GrassBottom;
    private Color Spring = new Color(0.15f, 0.37f, 0.22f);
    private Color Summer = new Color(0.39f, 0.72f, 0.25f);
    private Color Autumn = new Color(1.0f, 0.71f, 0.2f);
    private Color Winter = new Color(0.95f, 0.94f, 0.91f);
    private SpriteRenderer topRenderer;
    private SpriteRenderer bottomRenderer;
    public ParticleSystem rainSystem;
    // Start is called before the first frame update
    void Start()
    {
        topRenderer = GrassTop.GetComponent<SpriteRenderer>();
        bottomRenderer = GrassBottom.GetComponent<SpriteRenderer>();
        topRenderer.color = Spring;
        bottomRenderer.color = Spring;
        var emission = rainSystem.emission;
        emission.enabled = true;
        StartCoroutine(SeasonCoroutine());
    }

    // Update is called once per frame
    IEnumerator SeasonCoroutine()
    {
        var emission = rainSystem.emission;
        while (true)
        {
            yield return new WaitForSeconds(5);
            emission.enabled = false;
            yield return new WaitForSeconds(5);
            topRenderer.color = Summer;
            bottomRenderer.color = Summer;
            yield return new WaitForSeconds(10);
            topRenderer.color = Autumn;
            bottomRenderer.color = Autumn;
            yield return new WaitForSeconds(10);
            topRenderer.color = Winter;
            bottomRenderer.color = Winter;
            yield return new WaitForSeconds(10);
            topRenderer.color = Spring;
            bottomRenderer.color = Spring;
            emission.enabled = true;
        }
    }
}
