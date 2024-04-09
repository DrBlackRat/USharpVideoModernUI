using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEditor.Experimental.SceneManagement;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace UdonSharp.Video.Internal
{
    public class Menu : MonoBehaviour
    {
        [MenuItem("Tools/USharpVideo/Open Example Scene")]
        public static void OpenExampleScene()
        {
            if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
            {
                EditorSceneManager.OpenScene("Packages/xyz.drblackrat.usharpvideomodernui/Runtime/Example.unity");
            }
        }
        [MenuItem("Tools/USharpVideo/ Add Prefab to Scene")]
        public static void AddPrefab()
        {
            GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Packages/xyz.drblackrat.usharpvideomodernui/Runtime/USharpVideo.prefab");
            PrefabUtility.InstantiatePrefab(prefab);
        }
    }
}

