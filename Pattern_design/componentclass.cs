namespace Pattern_design

public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "what's your name";
        }
    }
