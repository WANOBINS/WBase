using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace WBase.Unity
{
    public class ShouldBeDefault: MonoBehaviour
    {
        public bool DebugQuit = true;
        // Use this for initialization
        public void Start()
        {
            DontDestroyOnLoad(transform);
        }

        // Update is called once per frame
        public void Update()
        {
            if (DebugQuit && Input.GetKey(KeyCode.Escape))
            {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
                EditorApplication.OpenURL("https://google.com");
#else
                Application.Quit();
#endif
            }
        }
    }
}
