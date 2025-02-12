using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScriptRelancer : MonoBehaviour
{

    private bool doitRelancer = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (doitRelancer)
        {
            doitRelancer = false;
            Invoke("RelancerScene", 5f);
            
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Bille"))
        {
            doitRelancer = true;
        }
    }
    
    void RelancerScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
