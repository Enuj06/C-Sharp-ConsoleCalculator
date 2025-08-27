using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Calculator"); 

	  int num1, num2;
	  
	  Console.Write("Enter a first number: ");
	  num1 = Convert.ToInt32(Console.ReadLine());
	  
	  Console.Write("Enter a second number: ");
	  num2 = Convert.ToInt32(Console.ReadLine());
	  
	  Console.WriteLine("Enter an Operation: ");
	  string operation = Convert.ToString(Console.ReadLine());
	  
	  if(operation == "+"){
			Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
	  }
	  else if(operation == "-"){
			Console.WriteLine("{0} = {1} = {2}", num1, num2, num1 - num2);
	  }
	  else if(operation == "/"){
			Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
	  }
	  else if(operation == "*"){
			Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
	  }
	  else{
		Console.WriteLine("Your operation is invalid");
	  }
	  
  }
}