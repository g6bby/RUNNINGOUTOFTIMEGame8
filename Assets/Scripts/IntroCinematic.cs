using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroCinematic : MonoBehaviour
{
    public GameObject introCam;
    public GameObject playerCam;

    void Start()
    {
        introCam.SetActive(true);
        playerCam.SetActive(false);

        StartCoroutine("CamDelay");

    }


    IEnumerator CamDelay()
    {
        yield return new WaitForSeconds(4f);

        introCam.SetActive(false);
        playerCam.SetActive(true);
    }
}
