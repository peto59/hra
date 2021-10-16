using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using Cinemachine;

public class MouseLook : NetworkBehaviour
{

    [SerializeField] public float sensitivityX = 8f;
    [SerializeField] float sensitivityY = 0.5f;
    [SerializeField] float yClamp = 70f;

    [SerializeField] CinemachineVirtualCamera virtualCamera = null;
    public CinemachinePOV pov;

    float mouseX;
    float mouseY;

    float recoil;

    public override void OnStartAuthority()
    {
        pov = virtualCamera.GetCinemachineComponent<CinemachinePOV>();
    }

    [Client]
    private void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        transform.Rotate(0f, mouseX * Time.deltaTime, 0f);

        float followOffset = Mathf.Clamp(pov.m_VerticalAxis.Value - (mouseY * Time.deltaTime), -yClamp, yClamp);
        pov.m_VerticalAxis.Value = followOffset;
    }

    public void ReceiveInput(Vector2 mouseInput)
    {
        mouseX = mouseInput.x * sensitivityX;
        mouseY = mouseInput.y * sensitivityY;
    }
}
