using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapHandler : MonoBehaviour
{
    //Add future implementation to prevent null accesors by
    //passing  data as Singleton Variables searched by tag

    [SerializeField] private Transform leftMaxMovement;
    [SerializeField] private Transform rightMaxMovement;

    public Transform LeftMaxMovement { get { return leftMaxMovement; } }
    public Transform RightMaxMovement { get { return rightMaxMovement; } }

    // Start is called before the first frame update
    void Start()
    {

    }

}
