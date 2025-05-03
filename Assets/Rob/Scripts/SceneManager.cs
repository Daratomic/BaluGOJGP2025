using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    
    void ChangeScene()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Right arrow pressed");
            UnityEngine.SceneManagement.SceneManager.LoadScene("Scenes/ShopScene");
        }
    }
}
