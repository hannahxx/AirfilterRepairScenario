using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Leap;

public class GestureController : MonoBehaviour
{
    Controller controller;
    public int ccccc = 1;
    public int k = 1;
    // Use this for initialization
    void Start()
    {
        controller = new Controller();
        controller.EnableGesture(Gesture.GestureType.TYPECIRCLE);
        controller.EnableGesture(Gesture.GestureType.TYPESWIPE);
    }

    void Update()
    {
        BonnetUp bonn = GameObject.Find("Bonnet").GetComponent<BonnetUp>();
        //CollisionAttach cs1 = GameObject.Find("jacks").GetComponent<CollisionAttach>();
        //CollisionAttachWrench cs2 = GameObject.Find("wrench").GetComponent<CollisionAttachWrench>();
       
        Frame frame = controller.Frame();

        foreach (Gesture gesture in frame.Gestures())
        {
            switch (gesture.Type)
            {
                case (Gesture.GestureType.TYPESWIPE):
                    {
                        filterchange2 permission = GameObject.Find("airfiltertop").GetComponent<filterchange2>();
                        BonnetUp2 b1 = GameObject.Find("GameObject").GetComponent<BonnetUp2>();
                        if (bonn.bnu)
                        {
                            b1.Bonnetup2();
                          
                         //   break;
                        }
                        if(permission.bonnetpermit)
                        {
                            b1.Bonnetdown();
                          //  break;
                        }
                        break;
                    }
            }
        }
    }
               
}

    


