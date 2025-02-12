using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCube : MonoBehaviour
{

private bool doitDetruire = false;

    void Start()
    {
        doitDetruire = false;
    }


    void Update()
    {
         if (doitDetruire)
        {
            Destroy(gameObject);
        }
    }



        void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bille"))
        {
            doitDetruire = true;
        }
    }



}
