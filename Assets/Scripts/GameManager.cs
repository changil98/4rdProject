using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Retry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void End()
    {
        UnityEditor.EditorApplication.isPlaying = false; // Application.Quit()�� ���� �׽�Ʈ��
        Application.Quit();
    }
}
