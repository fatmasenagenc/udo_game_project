using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* Bu sayfa da uygulama i�i sat�n al�m sayfas� olarak 
 * planlanm��t� fakat herhangi bir fonksiyonelli�i yok.
 * */
public class MoneySceneButtonMethods : MonoBehaviour
{
    public void BackToMain()
    {
        SceneManager.LoadScene(0);
    }
    
    //buralara ger�ek para harcamayla alakal� ba�lant�lar konabilir
}
