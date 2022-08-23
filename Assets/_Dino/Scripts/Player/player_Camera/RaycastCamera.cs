using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class RaycastCamera : MonoBehaviour
{
    Camera mainCamera;
    Mouse mouse;
    
    void Start()
    {
        
        #if UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX || UNITY_EDITOR || UNITY_STANDALONE_LINUX
        mouse = Mouse.current;
        #endif
        
    }

    void Update()
    {
        if (mouse.leftButton.wasPressedThisFrame)
        {
            //Debug.Log("click mouse");
            ClickMouseRaycast();
        }
    }


    void ClickMouseRaycast()
    {
        mainCamera = Camera.main;
        Vector2 coordinate = new Vector2(Screen.width/2, Screen.height/2);
        
        Ray raycast = mainCamera.ScreenPointToRay(coordinate);
        if (Physics.Raycast(raycast, out var hit) && hit.collider.gameObject )
        {
            //if(ra)
        }

    }
}
