using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleporter : MonoBehaviour
{
    Transform player;
    bool playerIsOverlapping = false;

    public AudioClip teleportSound;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player = other.transform;
            playerIsOverlapping = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            AudioSource audioSource = FindObjectOfType<AudioSource>();
            audioSource.PlayOneShot(teleportSound);
            playerIsOverlapping = false;
        }
    }
    private void FixedUpdate()
    {
        if(playerIsOverlapping)
        {
            player.transform.position += new Vector3(100, 0, 0);
        }

    }
}
