using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ClientSidePrediction
{
    public class MainMenu : MonoBehaviour
    {
        [Header("Scenes")]
        [SerializeField] string _rbScene = "Scene_Rigidbody";
        [SerializeField] string _ccScene = "Scene_CharacterController";
        [SerializeField] string _trScene = "Scene_Transform";
        [Header("References")] 
        [SerializeField] Button _rbButton = null;
        [SerializeField] Button _ccButton = null;
        [SerializeField] Button _trButton = null;

        void Awake()
        {
            _rbButton.onClick.AddListener(HandleRBScene);
            _ccButton.onClick.AddListener(HandleCCScene);
            _trButton.onClick.AddListener(HandleTRScene);
        }

        void HandleCCScene() => LoadExample(_ccScene);

        void HandleRBScene() => LoadExample(_rbScene);

        void HandleTRScene() => LoadExample(_trScene);

        void LoadExample(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}