using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaControl : MonoBehaviour
{
    public float speed; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0, speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
         switch(collision.collider.tag)
        {
            case "area impacto":
                collision.collider.transform.root.gameObject.GetComponent<MovimientoEnemigo>().vida -=5;
                Destroy(this.gameObject);
                break;
        }
    }
}
