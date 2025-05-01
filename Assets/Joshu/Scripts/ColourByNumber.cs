using UnityEngine;

public class ColourByNumber : MonoBehaviour
{
    public Color selectedColor = Color.white; // Default color
    public Color[] colors;

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
}