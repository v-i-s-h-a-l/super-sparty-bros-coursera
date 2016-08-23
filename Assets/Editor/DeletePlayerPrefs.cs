using UnityEngine;
using System.Collections;
using UnityEditor;

public class DeletePlayerPrefs : ScriptableObject {

	[MenuItem("Editor/Delete Player Prefs")]
	static void DeletePrefs() {
		if (EditorUtility.DisplayDialog ("Delete all player prefs?", 
			    "Are you sure you want to delete all player preferences?",
			    "Yes", "No")) {
			PlayerPrefs.DeleteAll ();
		}
	}
}
