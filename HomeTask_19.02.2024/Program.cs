//Task2

//string WordBackwards(string word)
//{
//    char[] wordArray = word.ToCharArray();
//    char[] wordBackwards = new char[0]; 
//    for(int i = 0; i < word.Length; i++)
//    {
//        Array.Resize(ref wordBackwards, wordBackwards.Length + 1);
//        wordBackwards[i] = wordArray[wordArray.Length - 1 -i];
//    }
//    string result = new string (wordBackwards);
//    return result;
//}
//Console.WriteLine(WordBackwards("Code Academy"));

// Repetition from class

//using System.Text;

//StringBuilder str = new StringBuilder("Hello");

//str.Append("Bye");
//Console.WriteLine(str);




//int age = 80;

//Console.WriteLine(age.ToString().GetType());




//string userName = "qwerty";

//Console.WriteLine(userName.Length);





//string str1 = "Hello";
//string str2 = "Bye";

//string result = string.Concat(str1, str2);
//Console.WriteLine(result);






//string result = string.Empty;
//string result2 = result + "Hello";
//Console.WriteLine(result2);





//string text = "   ";

//if (string.IsNullOrEmpty(text))
//{
//    Console.WriteLine("Empty");
//}
//else
//{
//    Console.WriteLine("Filled");
//}






//string text = "   ";

//if (string.IsNullOrWhiteSpace(text))
//{
//    Console.WriteLine("Empty");
//}
//else
//{
//    Console.WriteLine("filled");
//}







//string text = "Hello";
//Console.WriteLine(text.ToUpper());
//Console.WriteLine(text.ToLower());






//string str = " Apple";
//string str2 = "apple";

//Console.WriteLine(str.Trim().ToLower() == str2.Trim().ToLower());






//string str = "   Apple";
//string str2 = "apple";

//Console.WriteLine(str.Trim().ToLower().Equals(str2.Trim().ToLower()));

//string CheckStr(string str)
//{
//    return str.Trim().ToLower();
//}

//Console.WriteLine(CheckStr(str).Equals(CheckStr(str2)));







//string text = "Azerbaycan";

//Console.WriteLine(string.Format(text));






//string names = "Briana Reed, Easton Mueller, Imani Dennis, Emanuel Dougherty, Alisson Huerta";

//string[] namesArray = names.Split(", ");

//foreach (string name in namesArray)
//{
//    Console.WriteLine(name);
//}






//string text = "Salam Azerbaycan";

//Console.WriteLine(text.Replace("Salam","Sagol"));






//string text = "Salam Azerbaycan wqadsfffffrvhtttttttrwqqqqqqqqqqqqqqxgg";

//Console.WriteLine(text.Substring(3));

//Console.WriteLine(text.Substring(0,5));

//string result = text.Substring(0,5) + "...";
//Console.WriteLine(result);









//string text = "Salam Azerbaycan";

//Console.WriteLine(text.Contains("Az"));







//bool CheckCharInStr(string text, string letter)
//{
//    return CheckStr(text).Contains(CheckStr(letter));
//}

//string CheckStr(string text)
//{
//    return text.Trim().ToLower();
//}

//void StartSearch()
//{
//    Console.WriteLine("Add text:");
//    string text = Console.ReadLine();

//    Console.WriteLine("Add search text:");
//    string letter = Console.ReadLine();

//    if (CheckCharInStr(text, letter))
//    {
//        Console.WriteLine("Found");
//    }
//    else
//    {
//        Console.WriteLine("Not Found");
//    }
//}
//StartSearch();