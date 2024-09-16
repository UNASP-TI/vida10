using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    public string videoUrl = "https://www.youtube.com/watch?v=wX4o7N5BG6A";

    public void OnClick()
    {
        Application.OpenURL(videoUrl);
    }
}
