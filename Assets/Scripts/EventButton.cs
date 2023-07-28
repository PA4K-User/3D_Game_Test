using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EventButton : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject winPanel;

    [SerializeField] private Button playAgainGameoverBtn;
    [SerializeField] private Button playAgainWinBtn;
    [SerializeField] private Button quitGameoverBtn;
    [SerializeField] private Button quitWinBtn;
   
    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.gameObject.SetActive(false);
        winPanel.gameObject.SetActive(false);

        playAgainGameoverBtn.onClick.AddListener(OnChangeScene);
        playAgainWinBtn.onClick.AddListener(OnChangeScene);
        quitGameoverBtn.onClick.AddListener(OnQuitGame);
        quitWinBtn.onClick.AddListener(OnQuitGame);

    }

    private void Update()
    {       

        if(Settings.isDead)
        {
            gameOverPanel.gameObject.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Time.timeScale = 0f;

            Settings.isDead = false;
            
        }
        else if (Settings.isWon)
        {
            winPanel.gameObject.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Time.timeScale = 0f;

            Settings.isWon = false;
                        
        }
    }

    void OnChangeScene()
    {        
        SceneManager.LoadScene("GamePlay");
    }

    void OnQuitGame()
    {
        Application.Quit();
    }
}
