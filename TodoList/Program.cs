using TodoList;

//int a = 4, b = 2, c = 10;
//Console.WriteLine("First is :" + a + ", second is :" + b + ", third is :" + c);
////string interpulation
//Console.WriteLine(
//    value: $"First is {a}, second is : {b}, third is {c}");
// search about value in line 5
//Loops loops = new();
//loops.Mybreake();
//Console.ReadKey();
//____________________________________________________________
// OUT PARAMITER

//int[] numbers = { 1, 3, 5, 6, 7, 8 };
//int nonPosiitiveCount;
//var onlyPositive = GetOnlyPositve(numbers, out nonPosiitiveCount);
// When we pass a variable as a parameter to a method, a copy of this variable is created
// but the out key word use the parameter by it's self
//foreach (var positeveNumber in onlyPositive)
//{
//    Console.WriteLine(positeveNumber);
//}
//Console.WriteLine("Count of non positnve : " + nonPosiitiveCount);
//Console.ReadKey();
//List<int> GetOnlyPositve(
//            int[] numbers, out int countOfNonPositive)
//{
//    countOfNonPositive = 0;
//    var result = new List<int>();
//    foreach (var number in numbers)
//    {
//        if (number > 0)
//        {
//            result.Add(number);
//        }
//        else
//        {
//            countOfNonPositive++;
//        }
//    }
//    return result;
//}
//_____________________________________________________________________
//TRYPARS
//bool isParsingSuccessful;
//do
//{
//    Console.WriteLine("Enter a number:");
//    var userInput = Console.ReadLine();
//    isParsingSuccessful = int.TryParse(
//    userInput, out int number);
//    //It doesn't give me a compile errore .
//    if (isParsingSuccessful)
//    {
//        Console.WriteLine("Parsing worked, number is " + number);
//    }
//    else
//    {
//        Console.WriteLine("Parsing was not successful");
//    }

//} while (!isParsingSuccessful);
//____________________________________________________________________
//TO DO LIST APP
bool shallExit = false;
var todos = new List<string>();
Console.WriteLine("   Hello!");
while (!shallExit)
{


    Console.WriteLine("   What do you want to do ?");
    Console.WriteLine("   [S]ee all todos");
    Console.WriteLine("   [A]dd a todo");
    Console.WriteLine("   [R]emove a todo");
    Console.WriteLine("   [E]xit");
    var userInput = Console.ReadLine();
    switch (userInput)
    {
        case "E":
        case "e":
            shallExit = true;
            break;
        case "S":
        case "s":
            SeeAllTodos();
            break;
        case "A":
        case "a":
            AddTodo();
            break;
        case "R":
        case "r":
            RemoveTodo();
            break;

        default:
            break;
    }
}


Console.ReadKey();
void AddTodo()
{
    string description;
    do
    {
        Console.WriteLine("   Enter the TODO description:");
        description = Console.ReadLine();

    } while (!IsDescriptionValid(description));
    todos.Add(description);
}
bool IsDescriptionValid(string description)
{
    if (description == "")
    {
        Console.WriteLine("   The description cannot be empty");
        return false;
    }
    else if (todos.Contains(description))
    {
        Console.WriteLine("   The description must be unique.");
        return false;
    }
    return true;

}
void SeeAllTodos()
{
    if (todos.Count == 0)
    {
        ShowNoTodosMessage();
        return;
    }
    //else
    //{
    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todos[i]}");
    }
    //}
}

void RemoveTodo()
{
    if (todos.Count == 0)
    {
        ShowNoTodosMessage();
        return;
    }
    int index;
    do
    {
        Console.WriteLine("   select the index of TODO you want to remove.");
        SeeAllTodos();
        
    } while (!TryReadIndex(out index));
    RemoveTodoAtIndex(index - 1);
    
}

void RemoveTodoAtIndex(int index)
{
    var todoToBeRemoved = todos[index];
    todos.RemoveAt(index);
    Console.WriteLine("   TODO remoed: " + todoToBeRemoved);
}

bool TryReadIndex(out int index)
{
    var userInput = Console.ReadLine();
    if (userInput == "")
    {
        index = 0;
        Console.WriteLine("   Selected index can not be empty.");
        return false;
    }
    if (int.TryParse(userInput, out index) &&
        index >= 1 &&
        index <= todos.Count)
    {
        
        return true;
    }
    //else
    //{
    Console.WriteLine("   Invalid index!");
    index = 0;
    return false;
    //}
}
void ShowNoTodosMessage()
{
    Console.WriteLine("   No TODOs have been added yet.");
}
