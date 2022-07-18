using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamController : MonoBehaviour
{

    private Player playerFollowTarget;
    CinemachineVirtualCamera cinemachineVirtualCamera;

    // Start is called before the first frame update
    void Start()
    {
        //Finds the player with the camera and follows the player
        playerFollowTarget = FindObjectOfType<Player>();
        cinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>();
        cinemachineVirtualCamera.Follow = playerFollowTarget.transform;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
