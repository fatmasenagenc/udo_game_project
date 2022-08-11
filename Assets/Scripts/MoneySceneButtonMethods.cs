using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoneySceneButtonMethods : MonoBehaviour
{
    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }*/
    public int MainSceneIndex;

    public void BackToMain()
    {
        SceneManager.LoadScene(MainSceneIndex);
    }
    
    //buralara gerçek para harcamayla alakalý baðlantýlar konabilir
}
