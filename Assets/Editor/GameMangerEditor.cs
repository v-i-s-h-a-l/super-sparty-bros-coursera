using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(GameManager))]
public class GameMangerEditor : Editor {

	public override void OnInspectorGUI() {

		DrawDefaultInspector ();

		GameManager myGM = (GameManager)target;

		if (GUILayout.Button ("Reset Player State")) {
			PlayerPrefManager.ResetPlayerState (myGM.startLives, false);
		}

		if (GUILayout.Button ("Reset High Score")) {
			PlayerPrefManager.SetHighscore (0);
		}

		if (GUILayout.Button("Output Player State")) {
			PlayerPrefManager.ShowPlayerPrefs();
		}
	}
}
