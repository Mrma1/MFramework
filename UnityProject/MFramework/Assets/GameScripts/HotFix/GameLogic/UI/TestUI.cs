using UnityEngine;
using UnityEngine.UI;
using TEngine;

namespace GameLogic
{
    [Window(UILayer.UI, fullScreen : true)]
    class TestUI : UIWindow
    {
        #region 脚本工具生成的代码
        private Button m_btnTest;
        private Text m_textTest;
        private Image m_imgTest;
        protected override void ScriptGenerator()
        {
            m_btnTest = FindChildComponent<Button>("m_btnTest");
            m_textTest = FindChildComponent<Text>("m_textTest");
            m_imgTest = FindChildComponent<Image>("m_imgTest");
            m_btnTest.onClick.AddListener(OnClickTestBtn);
        }
        #endregion

        #region 事件
        private void OnClickTestBtn()
        {
        }
        #endregion

        protected override void OnCreate()
        {
            base.OnCreate();

            m_textTest.text = "马锦涛";
        }
    }
}
