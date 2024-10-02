
using System.ComponentModel;

public class Task {

    public string _title;
    public CompletionStatus _status;

    public string Title(){
        return "";
    }
    public void SetTitle(string title){

    }
    public CompletionStatus Status(){
        return _status;
    }
    public void ToggleStatus(){

    }
    public Task(string title){

    }
}

public class TodoList {
    public List<Task> _task;
    public int _selectedIndex;

    public void SwapTasksAt (int i, int j){

    }
    public int WrappedIndex (int index){
        return 0;
    }
    public int PreviousIndex(){
        return 0;
    }
    public int NextIndex(){
        return 0;
    }
    public void SelectPrevious(){

    }
    public void SelectNext(){

    }
    public void SwapWithPrevious(){

    }
    public void SwapWithNext(){

    }
    public void Insert(string title){

    }
    public void UpdateSelectedTitle(string title){

    }
    public int Length(){
        return 0;
    }
    public void DeleteSelected(){

    }
    public Task CurrentTask(){
        return ;
    }
    public Task GetTask(int index){
        return ;
    }
}

class TodoListApp {
    private TodoList _tasks;
    private bool _showHelp = true;
    private bool _insertMode = true;
    private bool _quit = false;

    public TodoListApp(TodoList tasks) {
        _tasks = tasks;
    }

    public void Run() {
        while (!_quit) {
            Console.Clear();
            Display();
            // ProcessUserInput();
        }
    }

    public void Display() {
        DisplayTasks();
        if (_showHelp) {
            DisplayHelp();
        }
    }

    public void DisplayBar() {
        Console.WriteLine("----------------------------");
    }

    public string MakeRow(int i) {
        Task task = _tasks.GetTask(i);
        string arrow = "  ";
        if (task == _tasks.CurrentTask()) arrow = "->";
        string check = " ";
        // if (task.Status == CompletionStatus.Done) check = "X";
        return $"{arrow} [{check}] {task.Title}";
    }

    public void DisplayTasks() {
        DisplayBar();
        Console.WriteLine("Tasks:");
        for (int i = 0; i < _tasks.Length(); i++) {
            Console.WriteLine(MakeRow(i));
        }
        DisplayBar();
    }

    public void DisplayHelp() {
        Console.WriteLine(
@"Instructions:
   h: show/hide instructions
   ↕: select previous or next task (wrapping around at the top and bottom)
   ↔: reorder task (swap selected task with previous or next task)
   space: toggle completion of selected task
   e: edit title
   i: insert new tasks
   delete/backspace: delete task");
        DisplayBar();
    }

    private string GetTitle() {
        Console.WriteLine("Please enter task title (or [enter] for none): ");
        return Console.ReadLine()!;
    }

//     public void ProcessUserInput() {
//         if (_insertMode) {
//             string taskTitle = GetTitle();
//             if (taskTitle.Length == 0) {
//                 _insertMode = false;
//             } else {
//                 _tasks.Insert(taskTitle);
//             }
//         } else {
//             switch (Console.ReadKey(true).Key) {
//                 case ConsoleKey.Escape:
//                     _quit = true;
//                     break;
//                 case ConsoleKey.UpArrow:
//                     _tasks.SelectPrevious();
//                     break;
//                 case ConsoleKey.DownArrow:
//                     _tasks.SelectNext();
//                     break;
//                 case ConsoleKey.LeftArrow:
//                     _tasks.SwapWithPrevious();
//                     break;
//                 case ConsoleKey.RightArrow:
//                     _tasks.SwapWithNext();
//                     break;
//                 case ConsoleKey.I:
//                     _insertMode = true;
//                     break;
//                 case ConsoleKey.E:
//                     _tasks.CurrentTask.Title = GetTitle();
//                     break;
//                 case ConsoleKey.H:
//                     _showHelp = !_showHelp;
//                     break;
//                 case ConsoleKey.Enter:
//                 case ConsoleKey.Spacebar:
//                     _tasks.CurrentTask.ToggleStatus();
//                     break;
//                 case ConsoleKey.Delete:
//                 case ConsoleKey.Backspace:
//                     _tasks.DeleteSelected();
//                     break;
//                 default:
//                     break;
//             }
//         }
//     }
 }

  

  class Program {
    static void Main() {
        new TodoListApp(new TodoList()).Run();
    }
  }

  public enum CompletionStatus{
    NotDone, Done
}