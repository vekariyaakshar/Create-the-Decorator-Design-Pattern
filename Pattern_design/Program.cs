using Create the Decorator Design Pattern.ConcreteComponent;
using Create the Decorator Design Pattern.Pattern_design;

    var component = new ConcreteComponent();

    var plainDecorator = new PlainDecorator(component);
    var upperCaseDecorator = new UpperCaseDecorator(component);
    var colorDecorator = new ColorDecorator(component);

    Console.WriteLine("Original: "+ component.GetText());
    Console.WriteLine("Plain: " + plainDecorator.GetText());
    Console.WriteLine("Upper Case: " + upperCaseDecorator.GetText());
    Console.WriteLine("Color: " + colorDecorator.GetText());