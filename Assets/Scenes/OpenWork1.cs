using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpenYouTubeLink : MonoBehaviour
{
    public void OpenLink()
    {
        Debug.Log("buttonclicado");
        Application.OpenURL("https://www.youtube.com/watch?v=wX4o7N5BG6A");
    }
}