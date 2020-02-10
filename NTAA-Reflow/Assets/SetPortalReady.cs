using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPortalReady : MonoBehaviour
{
    public Animator portalAnimator;
    public AudioClip triggerSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            AudioSource audioSource = FindObjectOfType<AudioSource>();
            audioSource.PlayOneShot(triggerSound);
            portalAnimator.SetTrigger("isReady");
            Destroy(gameObject, .05f);
        }
    }
}
