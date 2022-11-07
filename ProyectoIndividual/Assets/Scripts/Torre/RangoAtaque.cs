using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangoAtaque : MonoBehaviour
{
    ControlTorre tcRoot;
    float tiempoSiguienteBala;
    Transform target;
    
   
    private void Start()
    {
        tcRoot = transform.parent.GetComponent<ControlTorre>();
    }
    private void OnTriggerStay(Collider obj)
    {
        switch(obj.tag)
        {
            case "Enemigo":
                target = obj.gameObject.GetComponent<MovimientoEnemigo>().puntoDeDanio;
                tcRoot.cabezaTorre.transform.LookAt(new Vector3(target.position.x, tcRoot.cabezaTorre.transform.position.y, target.position.z));
                tcRoot.canion.transform.LookAt(target.position);
                if (Time.time > tiempoSiguienteBala)
                {
                    Instantiate(tcRoot.balaReferencia, tcRoot.spawnBala.position, tcRoot.spawnBala.rotation);
                    tiempoSiguienteBala = Time.time + tcRoot.tiempoDisparo;
                }
                
                break;

        }

    }

}
