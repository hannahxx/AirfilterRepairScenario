using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Leap;

public class GestureController : MonoBehaviour
{
    Controller controller;
	bonnetet bonnet;
	filterchange2 permission;
	bonnetetUp2 bonnetetUp;

    void Start()
    {
        controller = new Controller();
        controller.EnableGesture(Gesture.GestureType.TYPECIRCLE);
        controller.EnableGesture(Gesture.GestureType.TYPESWIPE);

		bonnet = GameObject.Find("bonnetet").GetComponent<bonnetetUp>();

		permission = GameObject.Find("airfiltertop").GetComponent<filterchange2>();
		bonnetetUp = GameObject.Find("GameObject").GetComponent<bonnetetUp2>();
    }

    void Update()
	{
        Frame frame = controller.Frame();

        foreach (Gesture gesture in frame.Gestures())
        {

			if (Gesture.GestureType.TYPESWIPE) {
				if (bonnet.bnu)
				{
					bonnetetUp.bonnetetup2();

				}
				if(permission.bonnetetpermit)
				{
					bonnetetUp.bonnetetdown();
				}
				break;
			}
          
        }
    }
               
}

    


