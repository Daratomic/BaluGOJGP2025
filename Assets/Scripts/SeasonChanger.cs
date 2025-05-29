using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeasonChanger : MonoBehaviour
{
    public GameObject Grass;
    private Color Spring = new Color(0.15f, 0.37f, 0.22f);
    private Color Summer = new Color(0.39f, 0.72f, 0.25f);
    private Color Autumn = new Color(1.0f, 1.0f, 1.0f);
    private SpriteRenderer grassRenderer;
    public ParticleSystem rainSystem;
    public GameObject Fog;
    private SpriteRenderer fogRenderer;
    public ParticleSystem snowSystem;
    public Sprite RegularColours;
    public Sprite AutumnColours;
    public Sprite WinterColours;
    // Start is called before the first frame update
    void Start()
    {
        grassRenderer = Grass.GetComponent<SpriteRenderer>();
        grassRenderer.sprite = RegularColours;
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
            grassRenderer.color = Summer;
            yield return new WaitForSeconds(10);
            grassRenderer.sprite = AutumnColours;
            grassRenderer.color = Autumn;
            fogRenderer.enabled = true;
            yield return new WaitForSeconds(5);
            fogRenderer.enabled = false;
            yield return new WaitForSeconds(5);
            grassRenderer.sprite = WinterColours;
            snowEmission.enabled = true;
            yield return new WaitForSeconds(5);
            snowEmission.enabled = false;
            yield return new WaitForSeconds(5);
            grassRenderer.sprite = RegularColours;
            grassRenderer.color = Spring;
            rainEmission.enabled = true;
        }
    }
}
