using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

namespace com.ondad.alertpanels
{
    public class AlertPanel_Info : AlertPanel
    {
        [SerializeField] private Button okeyBtn;
        Action okeyAction;

        private void Awake()
        {
            okeyBtn.onClick.AddListener(OkeyBtn);
        }

        public void ShowPanel(string bodyContent, Action exitAction = null, Action okeyAction = null)
        {
            if (okeyAction != null) this.okeyAction = okeyAction;
            DisplayPanel(bodyContent, exitAction);            
        }

        void OkeyBtn()
        {
            if (okeyAction != null)
            {
                okeyAction.Invoke();
                okeyAction = null;
            }

            ExitPanel();
        }
    }
}
