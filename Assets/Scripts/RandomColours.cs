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

    public TMP_Text SuccessText;
    private int CompleteColours;
    // Start is called before the first frame update
    void Start()
    {
        color1 = button1.GetComponent<Image>().color;
        color2 = button2.GetComponent<Image>().color;
        color3 = button3.GetComponent<Image>().color;
        color4 = button4.GetComponent<Image>().color;
        color5 = button5.GetComponent<Image>().color;
        color6 = button6.GetComponent<Image>().color;

        TopRingColour.text = (Random.Range(1, 7)).ToString();
        MiddleRingColour.text = (Random.Range(1, 7)).ToString();
        BottomRingColour.text = (Random.Range(1, 7)).ToString();
        LeftPillarColour.text = (Random.Range(1, 7)).ToString();
        RightPillarColour.text = (Random.Range(1, 7)).ToString();
        FirstArchColour.text = (Random.Range(1, 7)).ToString();
        MiddleArchColour.text = (Random.Range(1, 7)).ToString();
        FinalArchColour.text = (Random.Range(1, 7)).ToString();

        CompleteColours = 0;
        SuccessText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (TopRingColour.text == "1")
        {
            if (TopRingRenderer.color == color1)
            {
                CompleteColours++;
            }
        }
        else if (TopRingColour.text == "2")
        {
            if (TopRingRenderer.color == color2)
            {
                CompleteColours++;
            }
        }
        else if (TopRingColour.text == "3")
        {
            if (TopRingRenderer.color == color3)
            {
                CompleteColours++;
            }
        }
        else if (TopRingColour.text == "4")
        {
            if (TopRingRenderer.color == color4)
            {
                CompleteColours++;
            }
        }
        else if (TopRingColour.text == "5")
        {
            if (TopRingRenderer.color == color5)
            {
                CompleteColours++;
            }
        }
        else
        {
            if (TopRingRenderer.color == color6)
            {
                CompleteColours++;
            }
        }

        if (MiddleRingColour.text == "1")
        {
            if (MiddleRingRenderer.color == color1)
            {
                CompleteColours++;
            }
        }
        else if (MiddleRingColour.text == "2")
        {
            if (MiddleRingRenderer.color == color2)
            {
                CompleteColours++;
            }
        }
        else if (MiddleRingColour.text == "3")
        {
            if (MiddleRingRenderer.color == color3)
            {
                CompleteColours++;
            }
        }
        else if (MiddleRingColour.text == "4")
        {
            if (MiddleRingRenderer.color == color4)
            {
                CompleteColours++;
            }
        }
        else if (MiddleRingColour.text == "5")
        {
            if (MiddleRingRenderer.color == color5)
            {
                CompleteColours++;
            }
        }
        else
        {
            if (MiddleRingRenderer.color == color6)
            {
                CompleteColours++;
            }
        }

        if (BottomRingColour.text == "1")
        {
            if (BottomRingRenderer.color == color1)
            {
                CompleteColours++;
            }
        }
        else if (BottomRingColour.text == "2")
        {
            if (BottomRingRenderer.color == color2)
            {
                CompleteColours++;
            }
        }
        else if (BottomRingColour.text == "3")
        {
            if (BottomRingRenderer.color == color3)
            {
                CompleteColours++;
            }
        }
        else if (BottomRingColour.text == "4")
        {
            if (BottomRingRenderer.color == color4)
            {
                CompleteColours++;
            }
        }
        else if (BottomRingColour.text == "5")
        {
            if (BottomRingRenderer.color == color5)
            {
                CompleteColours++;
            }
        }
        else
        {
            if (BottomRingRenderer.color == color2)
            {
                CompleteColours++;
            }
        }

        if (LeftPillarColour.text == "1")
        {
            if (LeftPillarRenderer.color == color1)
            {
                CompleteColours++;
            }
        }
        else if (LeftPillarColour.text == "2")
        {
            if (LeftPillarRenderer.color == color2)
            {
                CompleteColours++;
            }
        }
        else if (LeftPillarColour.text == "3")
        {
            if (LeftPillarRenderer.color == color3)
            {
                CompleteColours++;
            }
        }
        else if (LeftPillarColour.text == "4")
        {
            if (LeftPillarRenderer.color == color4)
            {
                CompleteColours++;
            }
        }
        else if (LeftPillarColour.text == "5")
        {
            if (LeftPillarRenderer.color == color5)
            {
                CompleteColours++;
            }
        }
        else
        {
            if (LeftPillarRenderer.color == color6)
            {
                CompleteColours++;
            }
        }

        if (RightPillarColour.text == "1")
        {
            if (RightPillarRenderer.color == color1)
            {
                CompleteColours++;
            }
        }
        else if (RightPillarColour.text == "2")
        {
            if (RightPillarRenderer.color == color2)
            {
                CompleteColours++;
            }
        }
        else if (RightPillarColour.text == "3")
        {
            if (RightPillarRenderer.color == color3)
            {
                CompleteColours++;
            }
        }
        else if (RightPillarColour.text == "4")
        {
            if (RightPillarRenderer.color == color4)
            {
                CompleteColours++;
            }
        }
        else if (RightPillarColour.text == "5")
        {
            if (RightPillarRenderer.color == color5)
            {
                CompleteColours++;
            }
        }
        else
        {
            if (RightPillarRenderer.color == color6)
            {
                CompleteColours++;
            }
        }

        if (FirstArchColour.text == "1")
        {
            if (FirstArchRenderer.color == color1)
            {
                CompleteColours++;
            }
        }
        else if (FirstArchColour.text == "2")
        {
            if (FirstArchRenderer.color == color2)
            {
                CompleteColours++;
            }
        }
        else if (FirstArchColour.text == "3")
        {
            if (FirstArchRenderer.color == color3)
            {
                CompleteColours++;
            }
        }
        else if (FirstArchColour.text == "4")
        {
            if (FirstArchRenderer.color == color4)
            {
                CompleteColours++;
            }
        }
        else if (FirstArchColour.text == "5")
        {
            if (FirstArchRenderer.color == color5)
            {
                CompleteColours++;
            }
        }
        else
        {
            if (FirstArchRenderer.color == color6)
            {
                CompleteColours++;
            }
        }

        if (MiddleArchColour.text == "1")
        {
            if (MiddleArchRenderer.color == color1)
            {
                CompleteColours++;
            }
        }
        else if (MiddleArchColour.text == "2")
        {
            if (MiddleArchRenderer.color == color2)
            {
                CompleteColours++;
            }
        }
        else if (MiddleArchColour.text == "3")
        {
            if (MiddleArchRenderer.color == color3)
            {
                CompleteColours++;
            }
        }
        else if (MiddleArchColour.text == "4")
        {
            if (MiddleArchRenderer.color == color4)
            {
                CompleteColours++;
            }
        }
        else if (MiddleArchColour.text == "5")
        {
            if (MiddleArchRenderer.color == color5)
            {
                CompleteColours++;
            }
        }
        else
        {
            if (MiddleArchRenderer.color == color6)
            {
                CompleteColours++;
            }
        }

        if (FinalArchColour.text == "1")
        {
            if (FinalArchRenderer.color == color1)
            {
                CompleteColours++;
            }
        }
        else if (FinalArchColour.text == "2")
        {
            if (FinalArchRenderer.color == color2)
            {
                CompleteColours++;
            }
        }
        else if (FinalArchColour.text == "3")
        {
            if (FinalArchRenderer.color == color3)
            {
                CompleteColours++;
            }
        }
        else if (FinalArchColour.text == "4")
        {
            if (FinalArchRenderer.color == color4)
            {
                CompleteColours++;
            }
        }
        else if (FinalArchColour.text == "5")
        {
            if (FinalArchRenderer.color == color5)
            {
                CompleteColours++;
            }
        }
        else
        {
            if (FinalArchRenderer.color == color6)
            {
                CompleteColours++;
            }
        }

        if (CompleteColours == 6)
        {
            SuccessText.text = "Success!";
        }
    }
}
