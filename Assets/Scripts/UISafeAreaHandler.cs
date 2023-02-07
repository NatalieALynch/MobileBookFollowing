using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISafeAreaHandler : MonoBehaviour
{
    RectTransform panel;

    void Start()
    {
        panel = GetComponent<RectTransform>();
    }

    void Update()
    {
        Rect area = Screen.safeArea;
        Vector2 screenSize = new Vector2(Screen.width, Screen.height);

        panel.anchorMin = area.position / screenSize;
        panel.anchorMax = (area.position + area.size) / screenSize;

        return;
    }

}
