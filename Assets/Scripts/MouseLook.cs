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

    public override void OnStartAuthority()
    {
        pov = virtualCamera.GetCinemachineComponent<CinemachinePOV>();
    }

    [Client]
    private void Update()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
        GameObject cam = GameObject.Find("MainCamera");
        //transform.rotation = cam.GetComponent<CinemachineBrain>().ActiveVirtualCamera.State.RawOrientation;
        //print(cam.GetComponent<CinemachineBrain>().ActiveVirtualCamera.State.FinalOrientation.y);
        //Vector3 newRotation = new Vector3(cam.eulerAngles.x, cam.eulerAngles.x, cam.eulerAngles.z);
        //print("new" + newRotation);
        //print("old" + transform.rotation.eulerAngles);
        //gameObject.transform.eulerAngles = newRotation;

        transform.Rotate(0f, mouseX * Time.deltaTime, 0f);
        //transform.eulerAngles = cam.rotation.eulerAngles;
        //print(mouseX);

        /*yRotation = -mouseY;
        yRotation = Mathf.Clamp(yRotation, -yClamp, yClamp);
        
        Vector3 targetRotation = transform.eulerAngles;
        targetRotation.x = yRotation;
        playerCamera.eulerAngles = targetRotation;*/
        print(yClamp);
        float followOffset = Mathf.Clamp(pov.m_VerticalAxis.Value - (mouseY * Time.deltaTime), -yClamp, yClamp);
        print(followOffset);
        pov.m_VerticalAxis.Value = followOffset;
    }

    public void ReceiveInput(Vector2 mouseInput)
    {
        mouseX = mouseInput.x * sensitivityX;
        mouseY = mouseInput.y * sensitivityY;
        //print(mouseY);
    }
}
