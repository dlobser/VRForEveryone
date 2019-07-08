using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable_Destroy : Interactable
{
    //explodes an object when clicked

    public GameObject explosion;

    public override void HandleHover()
    {
        if(clicked>.5f){
            HandleTrigger();
        }
    }

	public override void HandleTrigger()
	{
		base.HandleTrigger();
        GameObject e = Instantiate(explosion);
        e.transform.position = this.transform.position;
        Destroy(this.gameObject);
	}
}
