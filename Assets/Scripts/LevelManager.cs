using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

    // Var pour la progression
    [SerializeField] private GameObject _loaderCanva; 
    [SerializeField] private Image _progressBar;
    

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    private void Awake()
    {
        if(Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }   

        else{
            Destroy(gameObject);
        }
    }

    public void LoadScene(string SceneName){
        SceneManager.LoadScene(SceneName);    
    }

    public void LoadNewGame(){
        SceneManager.LoadScene("Level01");
    }

    public void LoadMaison1(){  
        SceneManager.LoadScene("Maison1");
    }
     public void LoadMaison2(){  
        SceneManager.LoadScene("Maison2");
    }
     public void LoadMaison3(){  
        SceneManager.LoadScene("Maison3");
    }
    

    public void LoadMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame(){
        Debug.Log($"Quitter le jeu");
        Application.Quit();
    }

    // Bar de progression

    public async void LoadAsyncScene(string SceneName){
        
        var scene = SceneManager.LoadSceneAsync(SceneName);

        scene.allowSceneActivation = false;

        _loaderCanva.SetActive(true);

        do{
            await Task.Delay(1000);
            _progressBar.fillAmount = scene.progress;
        }while(scene.progress < 0.9f);
        
        scene.allowSceneActivation = true;

        _loaderCanva.SetActive(false);

        
    } 

    


}
