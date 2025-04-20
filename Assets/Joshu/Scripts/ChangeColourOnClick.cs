using UnityEngine;

public class ChangeColorOnClick : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Get the SpriteRenderer component attached to the GameObject
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        // Change the color of the sprite when the object is clicked
        spriteRenderer.color = new Color(Random.value, Random.value, Random.value);
    }
}
