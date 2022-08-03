Console.WriteLine("Please enter number of books:");
int numberOfBooks = int.Parse(Console.ReadLine());
for (int i = 0; i < numberOfBooks; i++)
{
    // Create a StreamWriter instance

    StreamWriter writer = new StreamWriter("bookinfo.txt", append: true);
    Console.WriteLine("Enter book name:");
    string bookName = Console.ReadLine();
    Console.WriteLine("Add book link here:");
    string bookLink = Console.ReadLine();
    Console.WriteLine("Check the txt file to see what you just saved in there!!!");


    // Ensure the writer will be closed when no longer used

    using (writer)

    {

        writer.WriteLine(bookName + " => " + bookLink);
        writer.Close();
    }
}
