namespace Mediator
{
    public sealed class Controller
    {
        private readonly Model _model;
        private readonly View _view;

        public Controller(Model model, View view)
        {
            _model = model;
            _view = view;
        }

        public void Show()
        {
            _view.Text = _model.Hp;
        }
    }
}
