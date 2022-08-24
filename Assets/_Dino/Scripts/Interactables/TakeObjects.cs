using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeObjects : MonoBehaviour, IUsable
{
    
    public bool CanInteract
    {
        get;
        set;
    }
    
    [SerializeField] private GameObject hand;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Use()
    {
        transform.parent = hand.transform;
    }
}
