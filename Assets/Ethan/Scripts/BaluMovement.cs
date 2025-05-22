using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaluMovement : MonoBehaviour
{

    public void ButtonClicked()
    {
        StartCoroutine(BaluAppearance());
    }

    IEnumerator BaluAppearance()
    {
        float moveSpeed = 2.0f;
        float elapsedTime = 0.0f;
        while (elapsedTime < 2.0f)
        {
            elapsedTime += Time.deltaTime;
            transform.position = new Vector3(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime);
        }
        yield return null;
    }
}
