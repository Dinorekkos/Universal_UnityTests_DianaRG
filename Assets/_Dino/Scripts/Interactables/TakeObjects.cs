using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeObjects : MonoBehaviour, IUsable
{
    private bool isTaken;
    public bool CanInteract
    {
        get;
        set;
    }
    
    [SerializeField] private GameObject hand;
   

    public void Use(bool isgrab)
    {
        isTaken = isgrab;
    }

    public void DropObject(bool isgrab)
    {
        isTaken = isgrab;

    }

    private void Update()
    {
        if (isTaken)
        {
            transform.position = hand.transform.position;
        }
        
      
    }
}
