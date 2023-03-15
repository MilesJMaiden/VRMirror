using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorMovement : MonoBehaviour
{

    public Transform playerTarget;
    public Transform mirror;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // create a vector3 of the local player if the player was a child of the mirror.
        Vector3 localPlayer = mirror.InverseTransformDirection(playerTarget.position);

        //Inverts player position
        transform.position = mirror.TransformPoint(new Vector3(localPlayer.x, localPlayer.y, - localPlayer.z));

        //Camera to look at inverted X Position
        Vector3 lookAtMirror = mirror.TransformPoint(new Vector3(-localPlayer.x, localPlayer.y, localPlayer.z));

        //make camera look at it
        transform.LookAt(lookAtMirror);
    }
}
