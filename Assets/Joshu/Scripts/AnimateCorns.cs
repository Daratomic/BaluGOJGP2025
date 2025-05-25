using UnityEngine;
using UnityEngine.UI;

public class AnimateCorns : MonoBehaviour
{
    // Assign the sprite Animators via the Inspector.
    public Animator[] spriteAnimators;

    // Optionally, you can also reference the UI Button in this script.
    public Button uiButton;

    void Start()
    {
        // Disable all animators initially, if needed.
        foreach (Animator anim in spriteAnimators)
        {
            if (anim != null)
                anim.enabled = false;
        }

        // If you reference the button here, add its listener.
        if (uiButton != null)
            uiButton.onClick.AddListener(ActivateAnimators);
    }

    // This method will be called on the button click.
    public void ActivateAnimators()
    {
        foreach (Animator anim in spriteAnimators)
        {
            if (anim != null)
            {
                anim.enabled = true;
                // Optionally restart or play a specific state:
                // anim.Play("YourAnimationStateName");
            }
        }
    }
}