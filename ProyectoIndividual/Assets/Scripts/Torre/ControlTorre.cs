using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTorre : MonoBehaviour
{
    public GameObject cabezaTorre;
    public Transform spawnBala;
    public GameObject canion;
    public GameObject rangoAtaqueControl;
    public GameObject balaReferencia;
    public float tiempoDisparo;
    public float rangoAtaque;
    void Start()
    {
        rangoAtaqueControl.GetComponent<SphereCollider>().radius = rangoAtaque;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
