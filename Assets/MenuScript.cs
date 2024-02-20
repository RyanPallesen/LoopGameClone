using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
   public void GoToGameScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
