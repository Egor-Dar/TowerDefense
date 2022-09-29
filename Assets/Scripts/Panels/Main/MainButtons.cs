using System;
using CorePlugin.Cross.Events.Interface;
using CorePlugin.Extensions;
using DefaultNamespace;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Panels.Main
{
    public class MainButtons : MonoBehaviour, IEventHandler
    {
        [SerializeField] private Button play;
        [SerializeField] private Button settings;
        [SerializeField] private Image imageSettings;
        [SerializeField] private Button exit;
        private MainUI.SetSettingsPanel _setSettingsPanel;

        private void Start()
        {
            play.onClick.AddListener(OnPlay);
            settings.onClick.AddListener(OnSetting);
            exit.onClick.AddListener(OnExit);
        }
        private void OnPlay() => SceneManager.LoadSceneAsync("Game");
        private void OnSetting()
        {
            _setSettingsPanel.Invoke();
            imageSettings.DOColor(Color.red, 1f).OnComplete((() => imageSettings.DOColor(Color.white, 1f)));
            imageSettings.transform.DOLocalJump(Vector3.up, 10f, 1, 1);
        }
        private void OnExit() => Application.Quit();
        public void InvokeEvents()
        {

        }
        public void Subscribe(params Delegate[] subscribers)
        {
            EventExtensions.Subscribe(ref _setSettingsPanel, subscribers);
        }
        public void Unsubscribe(params Delegate[] unsubscribers)
        {
            EventExtensions.Unsubscribe(ref _setSettingsPanel, unsubscribers);
        }
    }
}
