using GoogleARCore.Examples.ObjectManipulation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour {

	GameObject pwn;
	GameObject btn;
	public void ChangeObjectTypeCercleRed()
	{
		pwn = GameObject.Find("Pawn Generator");
		pwn.GetComponent<PawnManipulator>().SetIndex(0);
	}
	public void ChangeObjectTsypeToCercleGreen()
	{
		pwn = GameObject.Find("Pawn Generator");
		pwn.GetComponent<PawnManipulator>().SetIndex(1);

	}

	public void ChangeObjectTypeToCercleBlue()
	{
		pwn = GameObject.Find("Pawn Generator");
		pwn.GetComponent<PawnManipulator>().SetIndex(2);

	}
	public void ChangeObjectTypeToArrow()
	{
		pwn = GameObject.Find("Pawn Generator");
		pwn.GetComponent<PawnManipulator>().SetIndex(3);

	}

	public void ChangeObjectTypeToArrowOut()
	{
		pwn = GameObject.Find("Pawn Generator");
		pwn.GetComponent<PawnManipulator>().SetIndex(4);

	}

	public void ChangeObjectTypeToArrowIn()
	{
		pwn = GameObject.Find("Pawn Generator");
		pwn.GetComponent<PawnManipulator>().SetIndex(5);

	}

}
