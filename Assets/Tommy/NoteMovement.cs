using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMovement : MonoBehaviour

{

    [SerializeField] public float movementSpeed = 0.1f;
    public Transform targetLocation;
    //public Transform balu;

    // Start is called before the first frame update
    void Start()
    {
       //balu.transform.position = targetLocation.position;
    }

    void MoveGameObject()

    {
        float step = movementSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetLocation.position, step);
    }

    // Update is called once per frame
    void Update()
    {
        MoveGameObject();
    }
}
