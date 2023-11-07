using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    [SerializeField] Transform playerTarget;
    [SerializeField] Vector3 playerCamOffset;

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTarget.position + playerCamOffset;
    }
}
