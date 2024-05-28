using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIElement : MonoBehaviour
{
   private UIDocument _document;
[SerializeField] private Button startGameButton;
[SerializeField] private Button quitGameButton;
[SerializeField] private Button marketButton;
[SerializeField] private Image soundOnIcon;
[SerializeField] private Image soundOffIcon;
private bool muted = false;

void Start()
{
    if(!PlayerPrefs.HasKey("Muted"))
    {
        PlayerPrefs.SetInt("Muted", 0);
        Load();
    }
    else
    {
        Load();
    }
    
    AudioListener.pause = muted;
}

public void PlayGame()
{
    Debug.Log("PLAY!");
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}

public void QuitGame()
{
    Debug.Log("QUIT!");
    Application.Quit();
}

public void OnButtonPress()
{
    muted = !muted;
    AudioListener.pause = muted;
    Save();
   
}



private void Load()
{
    muted = PlayerPrefs.GetInt("Muted") == 1;
}

private void Save()
{
    PlayerPrefs.SetInt("Muted", muted ? 1 : 0);
}

private void Awake()
{
    _document = GetComponent<UIDocument>();
    startGameButton = _document.rootVisualElement.Q<Button>("StartGame") as Button;
    quitGameButton = _document.rootVisualElement.Q<Button>("QuitGame") as Button;
    marketButton = _document.rootVisualElement.Q<Button>("Market") as Button;
    soundOnIcon = _document.rootVisualElement.Q<Image>("SoundOnIcon") as Image;
    soundOffIcon = _document.rootVisualElement.Q<Image>("SoundOffIcon") as Image;
    

    startGameButton.clicked += PlayGame;
    quitGameButton.clicked += QuitGame;
    marketButton.clicked += OnButtonPress;
}

}
