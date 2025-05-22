using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomColours : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;

    public SpriteRenderer TopRingRenderer;
    public SpriteRenderer MiddleRingRenderer;
    public SpriteRenderer BottomRingRenderer;
    public SpriteRenderer LeftPillarRenderer;
    public SpriteRenderer RightPillarRenderer;
    public SpriteRenderer FirstArchRenderer;
    public SpriteRenderer MiddleArchRenderer;
    public SpriteRenderer FinalArchRenderer;

    private Color color1;
    private Color color2;
    private Color color3;
    private Color color4;
    private Color color5;
    private Color color6;

    public TMP_Text TopRingColour;
    public TMP_Text MiddleRingColour;
    public TMP_Text BottomRingColour;
    public TMP_Text LeftPillarColour;
    public TMP_Text RightPillarColour;
    public TMP_Text FirstArchColour;
    public TMP_Text MiddleArchColour;
    public TMP_Text FinalArchColour;

    public ParticleSystem fireworks;
    private bool TopRingComplete;
    private bool MiddleRingComplete;
    private bool BottomRingComplete;
    private bool LeftPillarComplete;
    private bool RightPillarComplete;
    private bool FirstArchComplete;
    private bool MiddleArchComplete;
    private bool FinalArchComplete;
    // Start is called before the first frame update
    void Start()
    {
        ColorBlock cb1 = button1.colors;
        ColorBlock cb2 = button2.colors;
        ColorBlock cb3 = button3.colors;
        ColorBlock cb4 = button4.colors;
        ColorBlock cb5 = button5.colors;
        ColorBlock cb6 = button6.colors;

        color1 = cb1.normalColor;
        color2 = cb2.normalColor;
        color3 = cb3.normalColor;
        color4 = cb4.normalColor;
        color5 = cb5.normalColor;
        color6 = cb6.normalColor;

        TopRingColour.text = (Random.Range(1, 7)).ToString();
        MiddleRingColour.text = (Random.Range(1, 7)).ToString();
        BottomRingColour.text = (Random.Range(1, 7)).ToString();
        LeftPillarColour.text = (Random.Range(1, 7)).ToString();
        RightPillarColour.text = (Random.Range(1, 7)).ToString();
        FirstArchColour.text = (Random.Range(1, 7)).ToString();
        MiddleArchColour.text = (Random.Range(1, 7)).ToString();
        FinalArchColour.text = (Random.Range(1, 7)).ToString();

        TopRingComplete = false;
        MiddleRingComplete = false;
        BottomRingComplete = false;
        LeftPillarComplete = false;
        RightPillarComplete = false;
        FirstArchComplete = false;
        MiddleArchComplete = false;
        FinalArchComplete = false;
        fireworks.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (TopRingColour.text == "1")
        {
            if (TopRingRenderer.color == color1)
            {
                TopRingComplete = true;
            }
            else
            {
                TopRingComplete = false;
            }
        }
        else if (TopRingColour.text == "2")
        {
            if (TopRingRenderer.color == color2)
            {
                TopRingComplete = true;
            }
            else
            {
                TopRingComplete = false;
            }
        }
        else if (TopRingColour.text == "3")
        {
            if (TopRingRenderer.color == color3)
            {
                TopRingComplete = true;
            }
            else
            {
                TopRingComplete = false;
            }
        }
        else if (TopRingColour.text == "4")
        {
            if (TopRingRenderer.color == color4)
            {
                TopRingComplete = true;
            }
            else
            {
                TopRingComplete = false;
            }
        }
        else if (TopRingColour.text == "5")
        {
            if (TopRingRenderer.color == color5)
            {
                TopRingComplete = true;
            }
            else
            {
                TopRingComplete = false;
            }
        }
        else
        {
            if (TopRingRenderer.color == color6)
            {
                TopRingComplete = true;
            }
            else
            {
                TopRingComplete = false;
            }
        }

        if (MiddleRingColour.text == "1")
        {
            if (MiddleRingRenderer.color == color1)
            {
                MiddleRingComplete = true;
            }
            else
            {
                MiddleRingComplete = false;
            }
        }
        else if (MiddleRingColour.text == "2")
        {
            if (MiddleRingRenderer.color == color2)
            {
                MiddleRingComplete = true;
            }
            else
            {
                MiddleRingComplete = false;
            }
        }
        else if (MiddleRingColour.text == "3")
        {
            if (MiddleRingRenderer.color == color3)
            {
                MiddleRingComplete = true;
            }
            else
            {
                MiddleRingComplete = false;
            }
        }
        else if (MiddleRingColour.text == "4")
        {
            if (MiddleRingRenderer.color == color4)
            {
                MiddleRingComplete = true;
            }
            else
            {
                MiddleRingComplete = false;
            }
        }
        else if (MiddleRingColour.text == "5")
        {
            if (MiddleRingRenderer.color == color5)
            {
                MiddleRingComplete = true;
            }
            else
            {
                MiddleRingComplete = false;
            }
        }
        else
        {
            if (MiddleRingRenderer.color == color6)
            {
                MiddleRingComplete = true;
            }
            else
            {
                MiddleRingComplete = false;
            }
        }

        if (BottomRingColour.text == "1")
        {
            if (BottomRingRenderer.color == color1)
            {
                BottomRingComplete = true;
            }
            else
            {
                BottomRingComplete = false;
            }
        }
        else if (BottomRingColour.text == "2")
        {
            if (BottomRingRenderer.color == color2)
            {
                BottomRingComplete = true;
            }
            else
            {
                BottomRingComplete = false;
            }
        }
        else if (BottomRingColour.text == "3")
        {
            if (BottomRingRenderer.color == color3)
            {
                BottomRingComplete = true;
            }
            else
            {
                BottomRingComplete = false;
            }
        }
        else if (BottomRingColour.text == "4")
        {
            if (BottomRingRenderer.color == color4)
            {
                BottomRingComplete = true;
            }
            else
            {
                BottomRingComplete = false;
            }
        }
        else if (BottomRingColour.text == "5")
        {
            if (BottomRingRenderer.color == color5)
            {
                BottomRingComplete = true;
            }
            else
            {
                BottomRingComplete = false;
            }
        }
        else
        {
            if (BottomRingRenderer.color == color6)
            {
                BottomRingComplete = true;
            }
            else
            {
                BottomRingComplete = false;
            }
        }

        if (LeftPillarColour.text == "1")
        {
            if (LeftPillarRenderer.color == color1)
            {
                LeftPillarComplete = true;
            }
            else
            {
                LeftPillarComplete = false;
            }
        }
        else if (LeftPillarColour.text == "2")
        {
            if (LeftPillarRenderer.color == color2)
            {
                LeftPillarComplete = true;
            }
            else
            {
                LeftPillarComplete = false;
            }
        }
        else if (LeftPillarColour.text == "3")
        {
            if (LeftPillarRenderer.color == color3)
            {
                LeftPillarComplete = true;
            }
            else
            {
                LeftPillarComplete = false;
            }
        }
        else if (LeftPillarColour.text == "4")
        {
            if (LeftPillarRenderer.color == color4)
            {
                LeftPillarComplete = true;
            }
            else
            {
                LeftPillarComplete = false;
            }
        }
        else if (LeftPillarColour.text == "5")
        {
            if (LeftPillarRenderer.color == color5)
            {
                LeftPillarComplete = true;
            }
            else
            {
                LeftPillarComplete = false;
            }
        }
        else
        {
            if (LeftPillarRenderer.color == color6)
            {
                LeftPillarComplete = true;
            }
            else
            {
                LeftPillarComplete = false;
            }
        }

        if (RightPillarColour.text == "1")
        {
            if (RightPillarRenderer.color == color1)
            {
                RightPillarComplete = true;
            }
            else
            {
                RightPillarComplete = false;
            }
        }
        else if (RightPillarColour.text == "2")
        {
            if (RightPillarRenderer.color == color2)
            {
                RightPillarComplete = true;
            }
            else
            {
                RightPillarComplete = false;
            }
        }
        else if (RightPillarColour.text == "3")
        {
            if (RightPillarRenderer.color == color3)
            {
                RightPillarComplete = true;
            }
            else
            {
                RightPillarComplete = false;
            }
        }
        else if (RightPillarColour.text == "4")
        {
            if (RightPillarRenderer.color == color4)
            {
                RightPillarComplete = true;
            }
            else
            {
                RightPillarComplete = false;
            }
        }
        else if (RightPillarColour.text == "5")
        {
            if (RightPillarRenderer.color == color5)
            {
                RightPillarComplete = true;
            }
            else
            {
                RightPillarComplete = false;
            }
        }
        else
        {
            if (RightPillarRenderer.color == color6)
            {
                RightPillarComplete = true;
            }
            else
            {
                RightPillarComplete = false;
            }
        }

        if (FirstArchColour.text == "1")
        {
            if (FirstArchRenderer.color == color1)
            {
                FirstArchComplete = true;
            }
            else
            {
                FirstArchComplete = false;
            }
        }
        else if (FirstArchColour.text == "2")
        {
            if (FirstArchRenderer.color == color2)
            {
                FirstArchComplete = true;
            }
            else
            {
                FirstArchComplete = false;
            }
        }
        else if (FirstArchColour.text == "3")
        {
            if (FirstArchRenderer.color == color3)
            {
                FirstArchComplete = true;
            }
            else
            {
                FirstArchComplete = false;
            }
        }
        else if (FirstArchColour.text == "4")
        {
            if (FirstArchRenderer.color == color4)
            {
                FirstArchComplete = true;
            }
            else
            {
                FirstArchComplete = false;
            }
        }
        else if (FirstArchColour.text == "5")
        {
            if (FirstArchRenderer.color == color5)
            {
                FirstArchComplete = true;
            }
            else
            {
                FirstArchComplete = false;
            }
        }
        else
        {
            if (FirstArchRenderer.color == color6)
            {
                FirstArchComplete = true;
            }
            else
            {
                FirstArchComplete = false;
            }
        }

        if (MiddleArchColour.text == "1")
        {
            if (MiddleArchRenderer.color == color1)
            {
                MiddleArchComplete = true;
            }
            else
            {
                MiddleArchComplete = false;
            }
        }
        else if (MiddleArchColour.text == "2")
        {
            if (MiddleArchRenderer.color == color2)
            {
                MiddleArchComplete = true;
            }
            else
            {
                MiddleArchComplete = false;
            }
        }
        else if (MiddleArchColour.text == "3")
        {
            if (MiddleArchRenderer.color == color3)
            {
                MiddleArchComplete = true;
            }
            else
            {
                MiddleArchComplete = false;
            }
        }
        else if (MiddleArchColour.text == "4")
        {
            if (MiddleArchRenderer.color == color4)
            {
                MiddleArchComplete = true;
            }
            else
            {
                MiddleArchComplete = false;
            }
        }
        else if (MiddleArchColour.text == "5")
        {
            if (MiddleArchRenderer.color == color5)
            {
                MiddleArchComplete = true;
            }
            else
            {
                MiddleArchComplete = false;
            }
        }
        else
        {
            if (MiddleArchRenderer.color == color6)
            {
                MiddleArchComplete = true;
            }
            else
            {
                MiddleArchComplete = false;
            }
        }

        if (FinalArchColour.text == "1")
        {
            if (FinalArchRenderer.color == color1)
            {
                FinalArchComplete = true;
            }
            else
            {
                FinalArchComplete = false;
            }
        }
        else if (FinalArchColour.text == "2")
        {
            if (FinalArchRenderer.color == color2)
            {
                FinalArchComplete = true;
            }
            else
            {
                FinalArchComplete = false;
            }
        }
        else if (FinalArchColour.text == "3")
        {
            if (FinalArchRenderer.color == color3)
            {
                FinalArchComplete = true;
            }
            else
            {
                FinalArchComplete = false;
            }
        }
        else if (FinalArchColour.text == "4")
        {
            if (FinalArchRenderer.color == color4)
            {
                FinalArchComplete = true;
            }
            else
            {
                FinalArchComplete = false;
            }
        }
        else if (FinalArchColour.text == "5")
        {
            if (FinalArchRenderer.color == color5)
            {
                FinalArchComplete = true;
            }
            else
            {
                FinalArchComplete = false;
            }
        }
        else
        {
            if (FinalArchRenderer.color == color6)
            {
                FinalArchComplete = true;
            }
            else
            {
                FinalArchComplete = false;
            }
        }

        if (TopRingComplete & MiddleRingComplete & BottomRingComplete & LeftPillarComplete & RightPillarComplete & FirstArchComplete & MiddleArchComplete & FinalArchComplete)
        {
            fireworks.gameObject.SetActive(true);
        }
        else
        {
            fireworks.gameObject.SetActive(false);
        }
    }
}
