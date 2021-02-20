using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerManager : NetworkBehaviour
{
    public override void OnStartServer()
    {
        base.OnStartServer();
        Debug.Log("Server Started");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ClientRpc]
    public void RpcShowRoles()
    {
        //show roles to every player
        //instantiate role and party? todo

        if (hasAuthority)
        {
            Debug.Log("we have authority");
        }
        else
        {
            Debug.Log("we don't have authority");
        }


    }
}
