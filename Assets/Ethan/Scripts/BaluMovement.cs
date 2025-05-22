using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;

public class BaluMovement : MonoBehaviour
{
    public Button LTMB;

    void Start()
    {
        Button btn = LTMB.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }
    public void OnClick()
    {
        StartCoroutine(BaluAppearance());
    }

    IEnumerator BaluAppearance()
    {
        float moveSpeed = 1.5f;
        float elapsedTime = 0.0f;
        while (elapsedTime < 2.0f)
        {
          elapsedTime += Time.deltaTime;
          transform.position = new Vector3(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime);
        }
        LTMB.gameObject.SetActive(false);
        yield return null;
    }
}
