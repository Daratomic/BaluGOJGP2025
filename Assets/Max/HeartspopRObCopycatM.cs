using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartspopRObCopycatM : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator Animator;
    public AnimationClip heart;

    private void OnMouseDown()
    {
        StartCoroutine(Clicked());
    }
    private void FixedUpdate ()
    {
        
    }
    IEnumerator Clicked()
    {
        TurtleClicked.turtleClicked = true;
        yield return new WaitForSeconds(2);
        
        TurtleClicked.turtleClicked = false;
    }
}
