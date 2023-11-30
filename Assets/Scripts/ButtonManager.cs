using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject MenuOpciones;
    public GameObject MenuCamara;
    public GameObject MenuCrear;
    public GameObject MenuInformacion;
    public GameObject MenuEliminar;
    public GameObject MenuEditar;

    public bool camaraMode { get; set; }
    public bool createMode { get; set; }
    public bool editMode { get; set; }
    public bool deleteMode { get; set; }

    public bool treeCreate { get; set; }
    public bool tree2Create { get; set; }
    public bool houseCreate { get; set; }
    public bool specialCreate { get; set; }

    private void Start()
    {
        camaraMode = false;
        createMode = false;
        treeCreate = false;
        tree2Create = false;
        houseCreate = false;
        specialCreate = false;
    }

    public void CamaraMode()
    {
        camaraMode = true;

        MenuOpciones.SetActive(false);
        MenuCamara.SetActive(true);
    }

    public void ExitCamaraMode()
    {
        camaraMode = false;

        MenuCamara.SetActive(false);
        MenuOpciones.SetActive(true);
    }

    public void CreateMode()
    {
        createMode = true;

        MenuOpciones.SetActive(false);
        MenuCrear.SetActive(true);
    }

    public void ExitCreateMode()
    {
        createMode = false;

        MenuCrear.SetActive(false);
        MenuOpciones.SetActive(true);
    }

    public void InformationMode()
    {
        createMode = true;

        MenuOpciones.SetActive(false);
        MenuInformacion.SetActive(true);
    }

    public void ExitInformationMode()
    {
        createMode = false;

        MenuInformacion.SetActive(false);
        MenuOpciones.SetActive(true);
    }

    public void EditMode()
    {
        editMode = true;

        MenuOpciones.SetActive(false);
        MenuEditar.SetActive(true);
    }

    public void ExitEditMode()
    {
        editMode = false;

        MenuEditar.SetActive(false);
        MenuOpciones.SetActive(true);
    }

    public void DeleteMode()
    {
        deleteMode = true;

        MenuOpciones.SetActive(false);
        MenuEliminar.SetActive(true);
    }

    public void ExitDeleteMode()
    {
        deleteMode = false;

        MenuEliminar.SetActive(false);
        MenuOpciones.SetActive(true);
    }

    public void ArbolCrear()
    {
        treeCreate = true;
        tree2Create = false;
        houseCreate = false;
        specialCreate = false;
    }

    public void Arbol2Crear()
    {
        treeCreate = false;
        tree2Create = true;
        houseCreate = false;
        specialCreate = false;
    }

    public void CasaCrear()
    {
        treeCreate = false;
        tree2Create = false;
        houseCreate = true;
        specialCreate = false;
    }

    public void EspecialCrear()
    {
        treeCreate = false;
        tree2Create = false;
        houseCreate = false;
        specialCreate = true;
    }
}

