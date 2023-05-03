using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Hackathon
{

    class Notes
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

    }
    class NotesDetails
    {
        List<Notes> notes = new List<Notes>();
        public int id = 1;
        public void CreateNotes()
        {

            Console.WriteLine("Enter the title");
            string title = Console.ReadLine();
            Console.WriteLine("Enter description");
            string description = Console.ReadLine();
            int Id = id + 1;
            Console.WriteLine(id);
            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            notes.Add(new Notes() { Title = title, Description = description, Id = id, Date = date });

        }
        public void ViewNotes()
        {
            Console.WriteLine("Enter id");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (Notes n in notes)
            {
                if (n.Id == id)
                {
                    Console.WriteLine("Id\tTitle\tDescription\tDate");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine($"{n.Id}\t{n.Title}\t{n.Description}\t{n.Date}");

                }
            }
        }
        public void GetAllNotes()
        {
            foreach (Notes it in notes)
            {
                Console.WriteLine("Id\tTitle\tDescription\tDate");
                Console.WriteLine($"{it.Id}\t{it.Title}\t{it.Description}\t{it.Date}");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"Total Notes{it.Id}");
            }
        }
        public void UpdateNote()
        {
            foreach (Notes n in notes)
            {
                if (n.Id == id)
                {
                    Console.WriteLine("Enter Title to update");
                    n.Title = Console.ReadLine();
                    Console.WriteLine("Enter Description to update");
                    n.Description = Console.ReadLine();
                }
            }
        }
        public bool DeleteNotes()
        {
            foreach (Notes n in notes)
            {
                if (n.Id == id)
                {
                    notes.Remove(n);
                    return true;
                }
            }
            return false;
        }
        internal class Program
        {
            static void Main(string[] args)

            {
                NotesDetails obj = new NotesDetails();
                do
                {
                    Console.WriteLine("1. CreateNotes");
                    Console.WriteLine("2. ViewNotes");
                    Console.WriteLine("3. GetallNotes");
                    Console.WriteLine("4. UpdateNotes");
                    Console.WriteLine("5. DeleteNotes");
                    try
                    {
                        Console.WriteLine("Enter the choice");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                {
                                    obj.CreateNotes();
                                    break;
                                }
                            case 2:
                                {
                                    obj.ViewNotes();
                                    break;
                                }
                            case 3:
                                {
                                    obj.GetAllNotes();
                                    break;
                                }
                            case 4:
                                {
                                    obj.UpdateNote();
                                    break;
                                }
                            case 5:
                                {
                                    if (obj.DeleteNotes())
                                    {
                                        Console.WriteLine("Notes deleted Successfully");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Id does not exist");
                                    }
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Enter a valid option");
                                    break;
                                }
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter only Numbers From 1 to 5");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                } while(true);

            }

        }
    }
}