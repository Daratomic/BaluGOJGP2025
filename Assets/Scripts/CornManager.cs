using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornManager : MonoBehaviour
{

    [SerializeField] float movementSpeed;


    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        MoveGameObject();
    }

    void MoveGameObject()
    {
        transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
    }
};
