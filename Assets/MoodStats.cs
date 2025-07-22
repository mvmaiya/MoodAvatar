using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoodStats : MonoBehaviour 
{
    // Hold mood values from 0 - 100.
    public int Happiness;
    public int Energy;
    public int Stress;

    // Hold references to UI stats.
    public TMP_Text happinessText;
    public TMP_Text energyText;
    public TMP_Text stressText;

    void Start() 
    {
        GenerateStats(); // Randomly assign values to mood stats.
        UpdateUI(); // Update text fiels on screen to show values.
    }

    public void GenerateStats()
    {
        // Assign values to each mood stat.
        Happiness = Random.Range(0, 101);
        Energy = Random.Range(0, 101);
        Stress = Random.Range(0, 101);
    }

    public void UpdateUI()
    {
        // Update each mood with text.
        if (happinessText != null)
            happinessText.text = "Happiness: " + Happiness;
        if (energyText != null)
            energyText.text = "Energy: " + Energy;
        if (stressText != null)
            stressText.text = "Stress: " + Stress;
    }

    public void RegenerateStats()
    {
        // Generate moods on demand.
        GenerateStats();
        UpdateUI();
    }

}

