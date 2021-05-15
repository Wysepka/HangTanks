using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    //Add future implementation for Data class for
    //Holding references for Components and Classes;
    //=====================================================//
    //-----------------------------------------------------//

    TankEngine tankEngine;
    TankMovement tankMovement;

    TankEventHandler eventHandler = null;
    TankEventReceiver eventReceiver = null;
    
    //=====================================================//

    public TankMovement TankMovement { get { return tankMovement; } }
    public TankEventHandler EventHandler { get { return eventHandler; } }


    //=====================================================//

    private void Awake()
    {
        eventHandler = new TankEventHandler(this);
        eventReceiver = new TankEventReceiver(eventHandler);

        if (!GetComponent<TankMovement>()) tankMovement = gameObject.AddComponent<TankMovement>();
        else tankMovement = gameObject.GetComponent<TankMovement>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnEnable()
    {
        eventReceiver.RegisterToIncomingEvents();
    }

    private void OnDisable()
    {
        eventReceiver.UnRegisterToIncomingEvents();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
