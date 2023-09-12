using MPExtensionMethods;

PersonModel person = new PersonModel();

person.FirstName = "What is your first name: ".RequestString();

person.LastName = "What is your last name: ".RequestString();

person.Age = "What is your age: ".RequestInt(0, 130);


Console.ReadLine();
