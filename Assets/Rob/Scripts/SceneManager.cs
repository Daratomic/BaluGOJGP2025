using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public string SceneName;
    public KeyCode SceneKey;

    private void Update()
    {
        if (Input.GetKeyDown(SceneKey))
        {
            ChangeScene();
        }
    }

    void ChangeScene()
    {
            Debug.Log("Right arrow pressed");
            UnityEngine.SceneManagement.SceneManager.LoadScene(SceneName);
    }
}
