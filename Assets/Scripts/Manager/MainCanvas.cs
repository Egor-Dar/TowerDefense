using System;
using CorePlugin.Core;
using UnityEngine;
using BetterExtensions.Runtime.Extension;
using CorePlugin.Cross.Events.Interface;
using DefaultNamespace;
using Unity.VisualScripting;


namespace Manager
{
    public class MainCanvas: BaseCore, IEventSubscriber
    {
        [SerializeField] private CanvasGroup mainPanelPrefab;
        [SerializeField] private CanvasGroup settingsPanelPrefab;
        [SerializeField] private Transform canvasTransform;
        private CanvasGroup _mainPanel;
        private CanvasGroup _settingsPanel;
        private PanelState _panelState;

        private void Start()
        {
            _mainPanel = Instantiate(mainPanelPrefab, canvasTransform);
           // _settingsPanel = Instantiate(settingsPanelPrefab ?? null, canvasTransform);
            _panelState = new PanelState();
            _panelState.SetPanel(_mainPanel);
        }
        private void OnMain() => _panelState.SetPanel(_mainPanel);
        private void OnSettings()
        {
            if(_settingsPanel!=null) _panelState.SetPanel(_settingsPanel);
            else Debug.LogError("Settings null");
        }
        public Delegate[] GetSubscribers()
        {
            return new Delegate[]
            {
                (MainUI.SetMainPanel)OnMain,
                (MainUI.SetSettingsPanel)OnSettings
            };
        }
    }
    public class PanelState
    {
        private CanvasGroup _currentPanel;
        public CanvasGroup GetCurrentPanel() => _currentPanel;

        public void SetPanel(CanvasGroup newPanel)
        {
           _currentPanel?.SetActive(false);
            _currentPanel = newPanel;
            _currentPanel.SetActive(true);
        }
    }
}
