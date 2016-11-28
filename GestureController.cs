using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Leap;

public class GestureController : MonoBehaviour
{
    	Controller controller;
	BonnetUp bonnet;
	filterchange2 permission;
	BonnetUp2 bonnetUp;

    void Start()
    {
        controller = new Controller();
        controller.EnableGesture(Gesture.GestureType.TYPECIRCLE);
        controller.EnableGesture(Gesture.GestureType.TYPESWIPE);

		bonnet = GameObject.Find("bonnet").GetComponent<BonnetUp>();

		permission = GameObject.Find("airfiltertop").GetComponent<filterchange2>();
		bonnetUp = GameObject.Find("GameObject").GetComponent<BonnetUp2>();
    }

    void Update()
	{
        Frame frame = controller.Frame();

        foreach (Gesture gesture in frame.Gestures())
        {

			if (Gesture.GestureType.TYPESWIPE) {
				if (bonnet.bnu)
				{
					bonnetUp.Bonnetup2();

				}
				if(permission.bonnetpermit)
				{
					bonnetUp.Bonnetdown();
				}
				break;
			}
          
        }
    }
               
}

    


