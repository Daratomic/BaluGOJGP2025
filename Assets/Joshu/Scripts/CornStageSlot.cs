using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornStageSlot : MonoBehaviour
{

    public SpriteRenderer Renderer;
    [SerializeField] private AudioSource __source;
    [SerializeField] private AudioClip _completeClip;

    public void Placed()
    {
        __source.PlayOneShot(_completeClip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
