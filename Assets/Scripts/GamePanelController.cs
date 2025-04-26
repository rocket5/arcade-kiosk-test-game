using UnityEngine;
using UnityEngine.UIElements;

public class GamePanelController : MonoBehaviour
{
    [SerializeField] private UIDocument uiDocument;
    
    private VisualElement root;
    private VisualElement gamePanel;
    private Label gameTitle;
    
    private void Awake()
    {
        if (uiDocument == null)
        {
            uiDocument = GetComponent<UIDocument>();
            if (uiDocument == null)
            {
                Debug.LogError("UIDocument component is missing on the GameObject with GamePanelController.");
                return;
            }
        }
    }
    
    private void OnEnable()
    {
        root = uiDocument.rootVisualElement;
        if (root == null)
        {
            Debug.LogError("Failed to get root VisualElement from UIDocument.");
            return;
        }
        
        gamePanel = root.Q<VisualElement>("game-panel");
        if (gamePanel == null)
        {
            Debug.LogError("Game panel not found in the UXML document.");
            return;
        }
        
        gameTitle = gamePanel.Q<Label>("game-title");
        if (gameTitle == null)
        {
            Debug.LogError("Game title label not found in the UXML document.");
        }
    }
} 