using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour


{

    public void PlayGame(){
        
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        SceneManager.LoadScene("SampleScene");
        
    }

    public void QuitGame(){
        Debug.Log("Oyundan Çıktık!");
        Application.Quit();
    }
     
    public void ReturnToMainmenu(){
        SceneManager.LoadScene("MainMenu");
    }
    
}
