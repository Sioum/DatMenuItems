#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class DatMenuItems
{

    // COPY PATH //
    [MenuItem("▼ Menu ▼/Copie Path   %#c",false ,11)]
    static void CopiePath()
    {
        GameObject obj = Selection.activeTransform.gameObject;
        string path = "/" + obj.name;

        while (obj.transform.parent != null)
        {
            obj = obj.transform.parent.gameObject;
            path = "/" + obj.name + path;
        }
        EditorGUIUtility.systemCopyBuffer = path;
        Debug.Log("[" + path + "]" + " a été copié dans le presse-papier.");
    }

    // Retour en arrière en mode play seulement:
    [MenuItem("▼ Menu ▼/Retour en arrière (mode éditeur)  %z", false, 1)]
    static void DatUndo()
    {
        if (Application.isPlaying && !EditorApplication.isPaused)
        {
            Debug.LogError("Quittez le mode play pour faire un retour en arrière. Pour plus d'informations voir le script \"DatMenuItemss\".");
        }
        else
        {
            Undo.PerformUndo();
        }
    }

    // Effacer les PlayerPrefs
    [MenuItem("▼ Menu ▼/⚠Effacer PlayerPrefs⚠  %w", false, 16)]
    private static void ClearPlayerPrefs()
    {
        if (EditorUtility.DisplayDialog("Attention", "Etes vous sûre de vouloir effacer les PlayerPrefs ?", "Oui", "Non"))
        {
            PlayerPrefs.DeleteAll();
            Debug.Log("Les PlayerPrefs ont été effacés.");
        }
        else
        {
            Debug.Log("Les PlayerPrefs n'ont pas été effacés.");
        }
    }

    // Dé-sélection
    [MenuItem("▼ Menu ▼/Dé-sélection  %q", false, 12)]
    private static void Deselecte()
    {
        Selection.activeGameObject = null;
    }

    // Jouer
    [MenuItem("▼ Menu ▼/Editeur Manageur/Play   _F5", false, 14)]
    private static void Play()
    {
        if (EditorApplication.isPlaying == false)
        {
            EditorApplication.isPlaying = true;
        }
        else
        {
            EditorApplication.isPlaying = false;
        }
    }
    // Pause
    [MenuItem("▼ Menu ▼/Editeur Manageur/Pause   _F6", false, 14)]
    private static void Pause()
    {
        if (EditorApplication.isPaused == true)
        {
            EditorApplication.isPaused = false;
        }
        else
        {
            EditorApplication.isPaused = true;
        }
    }
    // Pas à pas
    [MenuItem("▼ Menu ▼/Editeur Manageur/Pas à pas   _F7", false, 14)]
    private static void Step()
    {
        EditorApplication.Step();
    }

    // Effacer la console
    [MenuItem("▼ Menu ▼/Effacer console   %x", false, 13)]
    private static void ClearConsole()
    {
        var logEntries = System.Type.GetType("UnityEditor.LogEntries,UnityEditor.dll");
        var clearMethod = logEntries.GetMethod("Clear", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
        clearMethod.Invoke(null, null);
    }



    //////////////////////////////////////////////////////////////
    ///                         SCENES                         ///
    //////////////////////////////////////////////////////////////

    [MenuItem("▼ Menu ▼/⚠Load Scene⚠/scene 1 _F1")]
    private static void Scene0()
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            Debug.Log("Chargement de la scène effectué avec succès !");
            EditorSceneManager.OpenScene(SceneUtility.GetScenePathByBuildIndex(0));
        }
    }

    [MenuItem("▼ Menu ▼/⚠Load Scene⚠/scene _F2")]
    private static void Scene1()
    {

        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            Debug.Log("Chargement de la scène effectué avec succès !");
            EditorSceneManager.OpenScene(SceneUtility.GetScenePathByBuildIndex(1));
        }
    }

    [MenuItem("▼ Menu ▼/⚠Load Scene⚠/scene _F3")]
    private static void Scene2()
    {

        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            Debug.Log("Chargement de la scène effectué avec succès !");
            EditorSceneManager.OpenScene(SceneUtility.GetScenePathByBuildIndex(2));
        }
    }

    [MenuItem("▼ Menu ▼/⚠Load Scene⚠/scene _F4")]
    private static void Scene3()
    {

        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            Debug.Log("Chargement de la scène effectué avec succès !");
            EditorSceneManager.OpenScene(SceneUtility.GetScenePathByBuildIndex(3));
        }
    }

    [MenuItem("▼ Menu ▼/⚠Load Scene⚠/scene 5 #F1")]
    private static void Scene4()
    {

        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            Debug.Log("Chargement de la scène effectué avec succès !");
            EditorSceneManager.OpenScene(SceneUtility.GetScenePathByBuildIndex(4));
        }
    }

    [MenuItem("▼ Menu ▼/⚠Load Scene⚠/scene 6 #F2")]
    private static void Scene5()
    {

        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            Debug.Log("Chargement de la scène effectué avec succès !");
            EditorSceneManager.OpenScene(SceneUtility.GetScenePathByBuildIndex(5));
        }
    }

    [MenuItem("▼ Menu ▼/⚠Load Scene⚠/scene 7 #F3")]
    private static void Scene6()
    {

        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            Debug.Log("Chargement de la scène effectué avec succès !");
            EditorSceneManager.OpenScene(SceneUtility.GetScenePathByBuildIndex(6));
        }
    }

    [MenuItem("▼ Menu ▼/⚠Load Scene⚠/scene 8 #F4")]
    private static void Scene7()
    {

        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            Debug.Log("Chargement de la scène effectué avec succès !");
            EditorSceneManager.OpenScene(SceneUtility.GetScenePathByBuildIndex(7));
        }
    }

    [MenuItem("▼ Menu ▼/⚠Load Scene⚠/scene 9")]
    private static void Scene8()
    {

        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            Debug.Log("Chargement de la scène effectué avec succès !");
            EditorSceneManager.OpenScene(SceneUtility.GetScenePathByBuildIndex(8));
        }
    }

    [MenuItem("▼ Menu ▼/⚠Load Scene⚠/scene 10")]
    private static void Scene9()
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            Debug.Log("Chargement de la scène effectué avec succès !");
            EditorSceneManager.OpenScene(SceneUtility.GetScenePathByBuildIndex(9));
        }
    }
}


public class AutoSaves : EditorWindow {

    public float saveTime = 300;
    public float nextSave = 0;

    // AUTO-SAVES //

    [MenuItem("▼ Menu ▼/Auto-Save paramètres   %<")]
    static void Init()
    {
        AutoSaves window = (AutoSaves)EditorWindow.GetWindowWithRect(typeof(AutoSaves), new Rect(0, 0, 250, 55), false, "A-S paramètre");
        window.Show();
    }

    void OnGUI()
    {
        Color myColor = new Color(0.933f, 0, 0, 1);
        GUIStyle s = new GUIStyle(EditorStyles.boldLabel);
        s.normal.textColor = myColor;

        saveTime = EditorGUILayout.DelayedFloatField("Sauvegarder toutes les: ", saveTime);

        if (GUI.changed)
            nextSave = saveTime;
        float timeToSave = nextSave - (float)EditorApplication.timeSinceStartup;
        EditorGUILayout.LabelField("Prochaine sauvegarde:", Mathf.Round(timeToSave).ToString() + " sec");
        EditorGUILayout.LabelField("  /!\\Ne pas fermer cette fenêtre/!\\", s);
        Repaint();
        if (EditorApplication.timeSinceStartup > nextSave)
        {
            string[] path = EditorSceneManager.GetActiveScene().path.Split(char.Parse("/"));
            bool saveOK = EditorSceneManager.SaveScene(EditorSceneManager.GetActiveScene(), string.Join("/", path));
            Debug.Log("Etat de la sauvegarde" + (saveOK ? "Succès !" : "Erreur !"));
            nextSave = (float)EditorApplication.timeSinceStartup + saveTime;
        }
    }
}
#endif