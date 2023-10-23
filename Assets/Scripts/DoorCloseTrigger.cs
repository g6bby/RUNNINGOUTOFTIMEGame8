using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCloseTrigger : MonoBehaviour
{
    public Animator doorClose1;
    public Animator doorClose2;


    void Start()
    {
        doorClose1.enabled = false;
        doorClose2.enabled = false;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            doorClose1.enabled = true;
            doorClose2.enabled = true;

        }
    }
}
