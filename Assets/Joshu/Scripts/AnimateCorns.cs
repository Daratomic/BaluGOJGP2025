using UnityEngine;
using UnityEngine.UI;

public class AnimateCorns : MonoBehaviour
{
    public Animator[] spriteAnimators;
    public Button uiButton;

    void Start()
    {
        foreach (Animator anim in spriteAnimators)
        {
            if (anim != null)
                anim.enabled = false;
        }
        if (uiButton != null)
            uiButton.onClick.AddListener(ActivateAnimators);
    }

    public void ActivateAnimators()
    {
        foreach (Animator anim in spriteAnimators)
        {
            if (anim != null)
            {
                anim.enabled = true;
                // anim.Play("animationame");
            }
        }
    }
}