using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FloatingAttachPoint : MonoBehaviour
{
    [SerializeField] private Transform attachPoint;     // Don't forget to set this attach point in the XR Grab Interactable too.
    [Space(10)]
    [SerializeField] private Transform rightHand;
    [SerializeField] private Transform leftHand;
   
    private Transform handGrabbing;

    // DON'T FORGET TO CALL THIS METHOD IN THE SELECT ENTERED EVENT OF INTERACTABLE EVENTS OF THE XR GRAB INTERACTABLE!
    public void Grabbed(SelectEnterEventArgs interactor)
    {
        handGrabbing = interactor.interactorObject.transform;

        if (handGrabbing.name == rightHand.name)
        {
            attachPoint.position = rightHand.position;
            attachPoint.rotation = rightHand.rotation;
        }
        else if (handGrabbing.name == leftHand.name)
        {
            attachPoint.position = leftHand.position;
            attachPoint.rotation = leftHand.rotation;
        }      
    }
}
