using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleCustomiser : MonoBehaviour
{
    public GameObject turtles;
    public string colourName;
    private float r;
    private float g;
    private float b;
    private SpriteRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        r = 0;
        g = 255;
        b = 87;

        renderer = turtles.GetComponent<SpriteRenderer>();

        renderer.color = new Color ((r/255), (g/255), (b/255));
    }

    // Update is called once per frame
    void Update()
    {
        if (colourName == "Purple")
        {
            r = 80;
            g = 0;
            b = 115;

            renderer.color = new Color((r / 255), (g / 255), (b / 255));
        }
    }
}
