using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Canion : MonoBehaviour
{
    [SerializeField] private GameObject placeToThrow;
    private float speed = 10f;
    private Keyboard keyboard;
    private CannonStates State;
    void Start()
    {
#if UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX || UNITY_EDITOR || UNITY_STANDALONE_LINUX
       keyboard = Keyboard.current;
#endif
        State = CannonStates.None;

    }

    // Update is called once per frame
    void Update()
    {
        switch (State)
        {
            case  CannonStates.None:
                break;
            case CannonStates.Loaded:
                MoveCannon();
                break;

        }
    }


    void MoveCannon()
    {
        if (keyboard.aKey.isPressed)
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y + 1 * Time.deltaTime * speed, transform.localEulerAngles.z);
        }

        if (keyboard.dKey.isPressed)
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y -1 * Time.deltaTime * speed, transform.localEulerAngles.z);
            
        }

        if (keyboard.wKey.isPressed)
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x  + 1 * Time.deltaTime * speed, transform.localEulerAngles.y , transform.localEulerAngles.z);
            
        }

        if (keyboard.sKey.isPressed)
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x  -1 * Time.deltaTime * speed, transform.localEulerAngles.y , transform.localEulerAngles.z);

        }
    }

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<TakeObjects>())
        {
            Debug.Log("Se carga cañon");
            State= CannonStates.Loaded;
            
            other.transform.position = placeToThrow.transform.position;
            other.transform.parent = placeToThrow.transform;
        }
    }


    private enum CannonStates
    {
        None, 
        Loaded,
    }
}
