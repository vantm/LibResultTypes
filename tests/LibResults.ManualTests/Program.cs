// See https://aka.ms/new-console-template for more information

using LibResults;

Console.Write("User ID: ");
var id = int.Parse(Console.ReadLine()!);
Console.Write("New name of the user: ");
var name = Console.ReadLine();

var (ok, notFound, validationFailure) = ApplicationService.EditUser(id, name);

if (ok != null)
{
    Console.WriteLine("The user had been updated");
}

if (notFound != null)
{
    Console.WriteLine("There is no any user had associated with the ID '{0}'", 0);
}

if (validationFailure != null)
{
    Console.WriteLine("It can't update the user '{0}' because:", id);
    foreach (var (fieldName, fieldErrors) in validationFailure.Errors)
    {
        Console.WriteLine("* The field '{0}' was:", fieldName);
        foreach (var fieldError in fieldErrors)
        {
            Console.WriteLine("  * {0}", fieldError);
        }
    }
}

public static class ApplicationService
{
    public static Produces<Completed, NotFound, ValidationFailure> EditUser(int id, ReadOnlySpan<char> name)
    {
        if (id <= 0)
        {
            // You can't return like this
            //return new Error("User Not Found");
            return NotFound.Instance;
        }

        if (name.Length == 0 || name.Trim(' ').Length == 0)
        {
            var errors = new Dictionary<string, string[]> { { nameof(name), ["This field value must not be null or an empty string."] } };

            return new ValidationFailure(errors);
        }

        return Completed.Instance;
    }
}