using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class QuickShaderSets  {
	
	[MenuItem ("Assets/Hammer 2 - Quick Shader Change/Standard to Mobile Diffuse shader")]
	static void StandardToMobileDiffuseShader(){
		// Get all paths
		Dictionary<string, string> materialAssets = GetAllMaterialPaths();
		// prepare some vars
		int count = 0;
		string path;
		Material materialToChange;


		// Get all materials and check and set
		foreach(string material in materialAssets.Keys){
			path = materialAssets[material];
			materialToChange = (Material)AssetDatabase.LoadAssetAtPath( path.Replace( "\\", "/" ), typeof(Material) );
			if(materialToChange.shader.name == "Standard"){
				Undo.RecordObject((Object)materialToChange, "Hammer 2 - Changed Shaders to Mobile Diffuse");
				materialToChange.shader = Shader.Find("Mobile/Diffuse");
				count++;
				Debug.Log("[QuickShaderSets] StandardToMobileDiffuseShader. Changed material: " + materialToChange.name);
			}
		}
		Debug.Log("[QuickShaderSets] StandardToMobileDiffuseShader. DONE!");
		Debug.Log("[QuickShaderSets] MobileDiffuseToStandardShader. Changed " + count + " materials");
		AssetDatabase.Refresh(); // Not sure, but can't hurt...
	}

	[MenuItem ("Assets/Hammer 2 - Quick Shader Change/Mobile Diffuse to Standard shader")]
	static void MobileDiffuseToStandardShader(){
		// Get all paths
		Dictionary<string, string> materialAssets = GetAllMaterialPaths();
		// prepare some vars
		int count = 0;
		string path;
		Material materialToChange;
		// Get all materials and check and set
		foreach(string material in materialAssets.Keys){
			path = materialAssets[material];
			materialToChange = (Material)AssetDatabase.LoadAssetAtPath( path.Replace( "\\", "/" ), typeof(Material) );
			if(materialToChange.shader.name == "Mobile/Diffuse"){
				Undo.RecordObject((Object)materialToChange, "Hammer 2 - Changed Shaders to Standard");
				materialToChange.shader = Shader.Find("Standard");
				count++;
				Debug.Log("[QuickShaderSets] MobileDiffuseToStandardShader. Changed material: " + materialToChange.name);
			}
		}
		Debug.Log("[QuickShaderSets] MobileDiffuseToStandardShader. DONE!");
		Debug.Log("[QuickShaderSets] MobileDiffuseToStandardShader. Changed " + count + " materials");
		AssetDatabase.Refresh(); // Not sure, but can't hurt...
	}

	static Dictionary<string, string> GetAllMaterialPaths(){
		// retrieve all materials in our project asset folder
		// Thanking Xadhoom here for this codesnippet so I can get all the materials easy and fast!! THANKS!
		string[] materialsInProject = Directory.GetFiles( "Assets\\", "*.mat", SearchOption.AllDirectories );
		Dictionary<string, string> materialAssets = new Dictionary<string, string>();
		foreach( string materialFile in materialsInProject )
			materialAssets[Path.GetFileNameWithoutExtension( materialFile )] = materialFile;
		return materialAssets;
	}
}
