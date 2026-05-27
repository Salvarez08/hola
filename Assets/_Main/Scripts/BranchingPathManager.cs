using UnityEngine;
using UnityEngine.UI;

public class BranchingPathManager: MonoBehaviour

{
    public VisualNovelNodeSO currentNode;

    [Header("UI References")]
    [SerializeField] private Button nextButton;       // Your original sequential button
    [SerializeField] private Button[] choiceButtons;  // The 3 branching buttons (assign in Inspector)

    private void Start()
    {
        UpdateUI();
    }

    // Call this for your standard sequential progression (First -> Second -> Third)
    public void AdvanceSequentially()
    {
        if (currentNode.nextChoices != null && currentNode.nextChoices.Length > 0)
        {
            // Pick the first choice by default if using the single "Next" button
            currentNode = currentNode.nextChoices[0];
            UpdateUI();
        }
    }

    // Call this from your 3 branching buttons using Unity Inspector events (Pass 0, 1, or 2)
    public void ChooseBranchRoute(int choiceIndex)
    {
        if (choiceIndex < currentNode.nextChoices.Length && currentNode.nextChoices[choiceIndex] != null)
        {
            currentNode = currentNode.nextChoices[choiceIndex];
            UpdateUI();
        }
    }

    private void UpdateUI()
    {
        

        // Scenario A: We are on a node with exactly 3 branching choices
        if (currentNode.nextChoices != null && currentNode.nextChoices.Length == 3)
        {
            nextButton.gameObject.SetActive(false); // Hide the standard button

            for (int i = 0; i < choiceButtons.Length; i++)
            {
                choiceButtons[i].gameObject.SetActive(true); // Show the 3 choice buttons
            }
        }
        // Scenario B: Standard linear progression (1 choice or fewer)
        else
        {
            nextButton.gameObject.SetActive(true);

            for (int i = 0; i < choiceButtons.Length; i++)
            {
                choiceButtons[i].gameObject.SetActive(false); // Hide branching buttons
            }
        }
    }
}

