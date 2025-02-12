using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestructionPlateforme : MonoBehaviour
{

    public GameObject cube;
    public Button detruireCube;


    // Start is called before the first frame update
    void Start()
    {
        detruireCube.onClick.AddListener(destruction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void destruction(){
        Destroy(cube);
    }
}
