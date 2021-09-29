using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] float sensitivityX = 8f;
    [SerializeField] float sensitivityY = 0.5f;

    float mouseX, mouseY;

    [SerializeField] Transform playerCamera;
    [SerializeField] float yClamp = 85f;
    float yRotation = 0f;

    private void Update()
    {

        if (Cursor.lockState != CursorLockMode.Confined)
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
        Cursor.visible = false;

        transform.Rotate(Vector3.up, mouseX * Time.deltaTime);

        yRotation = -mouseY;
        yRotation = Mathf.Clamp(yRotation, -yClamp, yClamp);
        Vector3 targetRotation = transform.eulerAngles;
        targetRotation.x = yRotation;
        playerCamera.eulerAngles = targetRotation;
    }

    public void ReceiveInput(Vector2 mouseInput)
    {
        mouseX = mouseInput.x * sensitivityX;
        mouseY = mouseInput.y * sensitivityY -100;
        //print(mouseX);
        //print(mouseY);
    }
}
