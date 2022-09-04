using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteraactiveWaveControlle : MonoBehaviour
{
    Camera mainCamera;
    Mouse mouse;
    private Material material;

    private Color previousColor;
    void Start()
    {
         #if UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX || UNITY_EDITOR || UNITY_STANDALONE_LINUX
		    mouse = Mouse.current;
		#endif

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        var renderer = GetComponent<MeshRenderer>();

        material = Instantiate(renderer.sharedMaterial);
        renderer.material = material;

        previousColor = material.GetColor("_baseColor");
        material.SetColor("_waveCenter", previousColor);
    }

    private void OnDestroy() 
    {
        if(material != null)
        {
            Destroy(material);
        }    
    }

    void Update()
    {
        if (mouse.leftButton.wasPressedThisFrame)
        {
            ClickMouseRaycast();
        }
    }

    void ClickMouseRaycast()
    {
        mainCamera = Camera.main;
        
        Vector2 coordinate = new Vector2(Screen.width/2, Screen.height/2);
        
        Ray raycast = mainCamera.ScreenPointToRay(coordinate);
        if(Physics.Raycast (raycast,out var hit)&& hit.collider.gameObject == gameObject)
        {
            StartWave(hit.point);
            
        }
    }

    void StartWave(Vector3 center)
    {
        //Debug.Log("Start shader");
        Color waveColor = Color.HSVToRGB(Random.value,1,1);

        material.SetVector("_waveCenter",center);
        material.SetFloat("_waveStartTime", Time.time);
        material.SetColor("_baseColor", previousColor);
        material.SetColor("_waveColor", waveColor);

        previousColor = waveColor;
    }


}
