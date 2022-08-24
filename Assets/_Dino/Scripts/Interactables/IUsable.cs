using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUsable
{
    
    public bool CanInteract
    {
        get;
        set;
    }

    public void Use();
}
