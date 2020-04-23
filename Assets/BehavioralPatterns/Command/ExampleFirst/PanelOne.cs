using UnityEngine;
using UnityEngine.UI;



namespace Command.ExampleFirst
{
    public sealed class PanelOne : BaseUi
    {
        [SerializeField] private Text _text;
        
        public override void Execute()
        {
            _text.text = nameof(PanelOne);
            gameObject.SetActive(true);
        }

        public override void Cancel()
        {
            gameObject.SetActive(false);
        }
    }
}
