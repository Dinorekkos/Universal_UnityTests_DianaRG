using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerInteractions : MonoBehaviour
{
    public static PlayerInteractions Instance;

    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private bool isgrabingObject;
    [SerializeField] private LayerMask usableLayer;
    [SerializeField] private Text UIText;

    public PlayerStates State;
    
    
    public TakeObjects grababbleObject;
    private bool canInteract;
    private Camera mainCamera;
    private Mouse mouse;
    private Keyboard Keyboard;

    public bool dropObject = false;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        
        #if UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX || UNITY_EDITOR || UNITY_STANDALONE_LINUX
        mouse = Mouse.current;
        Keyboard = Keyboard.current;
#endif
    }

    void Update()
    {
        if (Keyboard.qKey.wasPressedThisFrame)
        {
            if (State == PlayerStates.Interacting)
            {
                State = PlayerStates.none;
                HandlePlayerInteractions();
            }
        }
        
        if (mouse.leftButton.wasPressedThisFrame)
        {
            HandlePlayerInteractions();
        }
        
        if (mouse.leftButton.wasReleasedThisFrame && grababbleObject != null)
        {
            State = PlayerStates.none;
            isgrabingObject = false;
            grababbleObject.DropObject(isgrabingObject);
            dropObject = false;
            
            grababbleObject = null;
            
            HandlePlayerInteractions();
        }
        
        if (mouse.leftButton.isPressed && grababbleObject == null && !dropObject)
        {
            ClickMouseRaycast();
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
            TakeObjects takeObject =   hit.transform.GetComponent<TakeObjects>();
            Rigidbody rigidbody = hit.transform.GetComponent<Rigidbody>();

            if (usable != null && takeObject != null) 
            {
                State = PlayerStates.GrabingObject;
                isgrabingObject = true;
                usable.Use(isgrabingObject);
                Debug.Log(rigidbody.gameObject.name);
                rigidbody.velocity = new Vector3(0, 0, 0);
                grababbleObject = takeObject;
            }
        }

    }

    public void ActivateInteractingPlayer()
    {
        State = PlayerStates.Interacting;
        HandlePlayerInteractions();
        UIText.text = "Player is interacting, can´t move = Press - Q - to stop interacting";
    }

    void HandlePlayerInteractions()
    {
        switch (State)
        {
            case PlayerStates.none:
                playerMovement.lockedMovement = false;
                dropObject = false;
                UIText.text = "Player is  NO interacting, can move";
                // isgrabingObject = false;
                break;
            
            case PlayerStates.GrabingObject:
                // isgrabingObject = true;
                break;
            
            case PlayerStates.Interacting:
                playerMovement.lockedMovement = true;
                break;
                
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("IUsable"))
        {
            ActivateInteractingPlayer();
        }
    }
    
    
}

public enum PlayerStates
{
    none,
    GrabingObject,
    Interacting,
    
    

}
