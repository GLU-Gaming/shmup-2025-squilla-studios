using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] public string Level;

    public void GoToGame()
    {
        SceneManager.LoadScene(Level);
    }

    public void Exit()
    {
        Application.Quit();
    }
}