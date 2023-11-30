using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class CamaraAcciones : MonoBehaviour
{
    public GameObject prefabTree;
    public GameObject prefabTree2;
    public GameObject prefabHouse;
    public GameObject prefabSpecial;

    public TMP_Text arbolText;
    public TMP_Text arbol2Text;
    public TMP_Text houseText;
    public TMP_Text specialText;

    ButtonManager _buttonManager;
    public GameObject controller;

    float rotacionX = 0f;
    float rotacionY = 0f;
    float zoom = 110;

    int layerMask = 1 << 6;

    void Start()
    {
        _buttonManager = controller.GetComponent<ButtonManager>();
    }

    void Update()
    {
        arbolText.text = "Hay un total de " + GameObject.FindGameObjectsWithTag("Arbol").Length + " árbol";
        arbol2Text.text = "Hay un total de " + GameObject.FindGameObjectsWithTag("Arbol2").Length + " árbol2";
        houseText.text = "Hay un total de " + GameObject.FindGameObjectsWithTag("Casa").Length + " casas";
        specialText.text = "Hay un total de " + GameObject.FindGameObjectsWithTag("Especial").Length + " espadas";

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
            if (Input.GetMouseButtonDown(1))
            {
                Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.SphereCast(rayo, 20, out hit, Mathf.Infinity))
                {
                    if(hit.collider.gameObject.tag == "Terreno")
                    {
                        CreateObject(hit.point, new Quaternion(0, 0, 0, 0));
                    }
                }
            }
        }

        if (_buttonManager.editMode)
        {

        }

        if (_buttonManager.deleteMode)
        {
            if (Input.GetMouseButtonDown(1))
            {
                Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(rayo, out hit, Mathf.Infinity, layerMask))
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }

    }

    private void CreateObject(Vector3 position, Quaternion rotation)
    {
        if (_buttonManager.treeCreate)
        {
            Instantiate(prefabTree, position, rotation);
        }

        if (_buttonManager.tree2Create)
        {
            Instantiate(prefabTree2, position, rotation);
        }

        if (_buttonManager.houseCreate)
        {
            Instantiate(prefabHouse, position, rotation);
        }

        if (_buttonManager.specialCreate)
        {
            Instantiate(prefabSpecial, position, rotation);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(Camera.main.ScreenPointToRay(Input.mousePosition));
    }
}
