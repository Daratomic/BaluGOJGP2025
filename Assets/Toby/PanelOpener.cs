using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;
    public AudioClip clickSound; // Assign your sound clip in the Inspector
    private AudioSource audioSource;

    void Start()
    {
        // Add or get the AudioSource component
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    public void OpenPanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);

            // Play the sound
            if (clickSound != null)
            {
                audioSource.PlayOneShot(clickSound);
            }
        }
    }
}
