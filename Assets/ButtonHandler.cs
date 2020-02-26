using GoogleARCore.Examples.ObjectManipulation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour {

	GameObject pwn;
	public void ChangeObjectTypeCercleRed()
	{
		pwn = GameObject.Find("Pawn Generator");
		pwn.GetComponent<PawnManipulator>().SetIndex(0);
		Debug.Log("AAPOKOPKOKPKPOKPOKPKO");

	}
	public void ChangeObjectTsypeToCercleGreen()
	{
		pwn = GameObject.Find("Pawn Generator");
		pwn.GetComponent<PawnManipulator>().SetIndex(1);
		Debug.Log("BBPOKOPKOKPKPOKPOKPKO");

	}
	public void ChangeObjectTypeToArrow()
	{
		pwn = GameObject.Find("Pawn Generator");
		pwn.GetComponent<PawnManipulator>().SetIndex(2);
		Debug.Log("CCPOKOPKOKPKPOKPOKPKO");

	}

}
