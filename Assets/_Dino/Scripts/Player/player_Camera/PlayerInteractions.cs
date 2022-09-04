using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInteractions : MonoBehaviour
{
    Camera mainCamera;
    Mouse mouse;

    public bool isgrabingObject;
    
    
   [SerializeField] private LayerMask usableLayer;
   private TakeObjects grababbleObject;
   
   
    void Start()
    {
        
        #if UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX || UNITY_EDITOR || UNITY_STANDALONE_LINUX
        mouse = Mouse.current;
        #endif
    }

    void Update()
    {
        if (mouse.leftButton.isPressed)
        {
            isgrabingObject = true;
            ClickMouseRaycast();
        }

        if (mouse.leftButton.wasReleasedThisFrame && grababbleObject != null)
        {
            isgrabingObject = false;
            grababbleObject.DropObject(isgrabingObject);
        }
        
    }


    void ClickMouseRaycast()
    {
        mainCamera = Camera.main;
        Vector2 coordinate = new Vector2(Screen.width/2, Screen.height/2);
        
        Ray raycast = mainCamera.ScreenPointToRay(coordinate);
        if (Physics.Raycast(raycast, out var hit, usableLayer))
        {
            IUsable usable = hit.transform.GetComponent<IUsable>();
            if (usable != null)
            {
                usable.Use(isgrabingObject);
                grababbleObject = hit.transform.GetComponent<TakeObjects>();
            }
        }

    }


    void HandlePlayerInteractions()
    {
        
    }
}

public enum PlayerStates
{
    none,
    GrabingObject,
    Interacting,
    

}
