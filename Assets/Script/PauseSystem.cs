using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseSystem : MonoBehaviour
{
    [SerializeField] public GameObject CanvasMenu;

    public void Pause()
    {
        CanvasMenu.SetActive(true);
    }

    public void Resume()
    {
        CanvasMenu.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
