using System.Collections;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(camerafollow))]

public class camfolloweditor : Editor {

	public override void OnInspectorGUI(){
		DrawDefaultInspector();
		camerafollow of=(camerafollow)target;
		if (GUILayout.Button("Set Min Cam Pos"))
		{
				of.setmincampos();
		}
		if (GUILayout.Button("Set Max Cam Pos"))
		{
				of.setmaxcampos();
		}
	}
}
