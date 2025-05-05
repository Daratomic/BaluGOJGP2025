//using UnityEngine;

//public class ColourByNumber : MonoBehaviour
//{
//    public Color selectedColor = Color.white; // Default color
//    public Color[] colors;

//    public void SetColor(Color newColor)
//    {
//        selectedColor = new Color(newColor.r, newColor.g, newColor.b, 1f); // Always keep alpha = 1
//    }

//    public void SelectColor(int index)
//    {
//        if (index >= 0 && index < colors.Length)
//        {
//            selectedColor = colors[index];
//        }
//    }

//    void Update()
//    {
//        if (Input.GetMouseButtonDown(0)) // Left-click
//        {
//            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

//            if (hit.collider != null && hit.collider.CompareTag("Colourable"))
//            {
//                SpriteRenderer sr = hit.collider.GetComponent<SpriteRenderer>();
//                if (sr != null)
//                {
//                    Color newColor = new Color(selectedColor.r, selectedColor.g, selectedColor.b, 1f);
//                    sr.color = newColor; // Apply color while keeping full opacity

//                    Debug.Log($"Changed {hit.collider.name} to {sr.color}");
//                }
//            }
//        }
//    }
//}


using UnityEngine;
using UnityEngine.UI;

public class ColourByNumber : MonoBehaviour
{
    public Color selectedColor = Color.white; // Default color
    public Color[] colors;
    public Button[] colorButtons; // Array of UI buttons

    void Start()
    {
        UpdateButtonColors();
    }

    public void SetColor(Color newColor)
    {
        selectedColor = new Color(newColor.r, newColor.g, newColor.b, 1f); // Always keep alpha = 1
    }

    public void SelectColor(int index)
    {
        if (index >= 0 && index < colors.Length)
        {
            selectedColor = colors[index];
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left-click
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null && hit.collider.CompareTag("Colourable"))
            {
                SpriteRenderer sr = hit.collider.GetComponent<SpriteRenderer>();
                if (sr != null)
                {
                    Color newColor = new Color(selectedColor.r, selectedColor.g, selectedColor.b, 1f);
                    sr.color = newColor; // Apply color while keeping full opacity

                    Debug.Log($"Changed {hit.collider.name} to {sr.color}");
                }
            }
        }
    }


    void UpdateButtonColors()
    {
        for (int i = 0; i < colorButtons.Length; i++)
        {
            if (i < colors.Length)
            {
                Color colorWithAlpha = new Color(colors[i].r, colors[i].g, colors[i].b, 1f); // Ensure alpha is 1
                ColorBlock cb = colorButtons[i].colors;
                cb.normalColor = colorWithAlpha;
                cb.highlightedColor = colorWithAlpha;
                cb.pressedColor = colorWithAlpha;
                cb.selectedColor = colorWithAlpha;
                colorButtons[i].colors = cb;
            }
        }
    }
}