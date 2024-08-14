using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Config : MonoBehaviour
{
    public void Configurações()
   {   
            SceneManager.LoadScene("Configurações");        
   }

   public void ConfigBack()
   {
    SceneManager.LoadScene("Fase 1");
   }
}
