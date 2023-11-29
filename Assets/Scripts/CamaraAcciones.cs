using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraAcciones : MonoBehaviour
{
    ButtonManager _buttonManager;
    public GameObject controller;

    float rotacionX = 0f;
    float rotacionY = 0f;
    float zoom = 110;

    void Start()
    {
        _buttonManager = controller.GetComponent<ButtonManager>();
    }

    void Update()
    {
        if (_buttonManager.camaraMode)
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            rotacionX += mouseX;
            rotacionY += mouseY;

            if (Input.GetMouseButton(0))
            {
                transform.position = new Vector3(rotacionX, 110, rotacionY);
            }

            if (Input.GetMouseButton(1))
            {
                transform.eulerAngles = new Vector3(-rotacionY, rotacionX, 0);
            }

            zoom += (Input.mouseScrollDelta.y * -1);

            transform.position = new Vector3(transform.position.x, zoom, transform.position.z);
        }

        if (_buttonManager.createMode)
        {

        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(Camera.main.ScreenPointToRay(Input.mousePosition));
    }
}
