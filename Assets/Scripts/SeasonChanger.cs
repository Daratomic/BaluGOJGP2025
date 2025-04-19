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
    public GameObject Fog;
    private SpriteRenderer fogRenderer;
    public ParticleSystem snowSystem;
    // Start is called before the first frame update
    void Start()
    {
        topRenderer = GrassTop.GetComponent<SpriteRenderer>();
        bottomRenderer = GrassBottom.GetComponent<SpriteRenderer>();
        topRenderer.color = Spring;
        bottomRenderer.color = Spring;
        var rainEmission = rainSystem.emission;
        rainEmission.enabled = true;
        fogRenderer = Fog.GetComponent<SpriteRenderer>();
        fogRenderer.enabled = false;
        var snowEmission = snowSystem.emission;
        snowEmission.enabled = false;
        StartCoroutine(SeasonCoroutine());
    }

    // Update is called once per frame
    IEnumerator SeasonCoroutine()
    {
        var rainEmission = rainSystem.emission;
        fogRenderer = Fog.GetComponent<SpriteRenderer>();
        var snowEmission = snowSystem.emission;
        while (true)
        {
            yield return new WaitForSeconds(5);
            rainEmission.enabled = false;
            yield return new WaitForSeconds(5);
            topRenderer.color = Summer;
            bottomRenderer.color = Summer;
            yield return new WaitForSeconds(10);
            topRenderer.color = Autumn;
            bottomRenderer.color = Autumn;
            fogRenderer.enabled = true;
            yield return new WaitForSeconds(5);
            fogRenderer.enabled = false;
            yield return new WaitForSeconds(5);
            topRenderer.color = Winter;
            bottomRenderer.color = Winter;
            snowEmission.enabled = true;
            yield return new WaitForSeconds(5);
            snowEmission.enabled = false;
            yield return new WaitForSeconds(5);
            topRenderer.color = Spring;
            bottomRenderer.color = Spring;
            rainEmission.enabled = true;
        }
    }
}
