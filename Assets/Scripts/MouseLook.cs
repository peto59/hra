using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using Cinemachine;

public class MouseLook : NetworkBehaviour
{
    [SerializeField] float sensitivityX = 8f;
    float mouseX;

    private void Start()
    {
        //playerCamera = GameObject.Find("Camer").transform;
    }

    [Client]
    private void Update()
    {
        transform.Rotate(Vector3.up, mouseX * Time.deltaTime);
        //print(mouseX);

        /*yRotation = -mouseY;
        yRotation = Mathf.Clamp(yRotation, -yClamp, yClamp);
        
        Vector3 targetRotation = transform.eulerAngles;
        targetRotation.x = yRotation;
        playerCamera.eulerAngles = targetRotation;*/
        /*float followOffset = Mathf.Clamp(transposer.m_FollowOffset.y - (mouseY * deltaTime), -yClamp, yClamp);
        transposer.m_FollowOffset.y = followOffset;*/
    }

    public void ReceiveInput(Vector2 mouseInput)
    {
        mouseX = mouseInput.x * sensitivityX;
        //print(mouseY);
    }
}
