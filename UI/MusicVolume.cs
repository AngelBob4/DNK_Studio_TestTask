using UnityEngine;
using UnityEngine.UI;

public class MusicVolume : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;

    private void Start()
    {
        volumeSlider.value = AudioListener.volume;
        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
    }

    private void OnVolumeChanged(float value)
    {
        float volume = Mathf.Clamp(value, -80f, 20f);
        AudioListener.volume = volume;
        PlayerPrefs.SetFloat(Constants.MasterVolume, volume); 
        PlayerPrefs.Save();  
    }
}