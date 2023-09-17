using UnityEngine;
using UnityEngine.UI;

public class SkillsUIHandler : MonoBehaviour
{
    [SerializeField] private GameObject bottomPanel;
    [SerializeField] private Button skillsButton;

    private void OnEnable()
    {
        if (skillsButton == null)
        {
            Debug.LogError($"{gameObject.name} - Skills button is not set in the inspector");
        }

        skillsButton.onClick.AddListener(SkillsButton);
    }
    private void OnDisable()
    {
        if (skillsButton == null)
        {
            Debug.LogError($"{gameObject.name} - Skills button is not set in the inspector");
        }

        skillsButton.onClick.RemoveListener(SkillsButton);
    }

    private void SkillsButton()
    {
        if (bottomPanel == null)
        {
            Debug.LogError($"{gameObject.name} - Bottom panel is not set in the inspector");
            return;
        }
        
        bottomPanel	.SetActive(!bottomPanel.activeInHierarchy);
    }
}
