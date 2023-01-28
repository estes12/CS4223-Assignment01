using UnityEngine;
using UnityEngine.SceneManagement;

public class NoMenu : MonoBehaviour
{
    public void SkipMenu() // Linked to Start button to skip the menu and go straight to game
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}