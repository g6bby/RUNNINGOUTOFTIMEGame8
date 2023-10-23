using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCloseTrigger : MonoBehaviour
{
    public Animator doorClose1;
    public Animator doorClose2;
    public GameObject clockObj;
    public GameObject BGaudio;


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
            BGaudio.SetActive(false);
            StartCoroutine("clockDelay");

        }
    }

    IEnumerator clockDelay()
    {
        yield return new WaitForSeconds(.8f);
        clockObj.SetActive(false);

    }
}
