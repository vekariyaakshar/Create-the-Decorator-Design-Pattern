namespace Pattern_design

public abstract class Decorator<T> : IComponent<T>
    {
        protected IComponent<T> component;

        public Decorator(IComponent<T> component)
        {
            _component = component;
        }

        public virtual T GetText()
        {
            return _component.GetText();
        }
    }