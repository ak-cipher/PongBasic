using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public int SceneId;
    public void MoveScene(int SceneId)
    {
        SceneManager.LoadScene(SceneId);
    }
}
