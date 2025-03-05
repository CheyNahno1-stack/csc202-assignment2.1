using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace toDOList
{
    public partial class ToDoList : Form
    {
        private TextBox txtTask; //declare my text box name so it will work everywhere in my code 
        private List<TaskItem> tasks = new List<TaskItem>();//makes a list to put to tasks in
        private int taskdIdCounter = 1; // this will make a unique ID so the first one will Task 1 and so on. 
        
        public ToDoList()// initialize and set up pulic to do list 
        {
            InitializeComponent();//initialize the graphics c 
            InitializeControls();//initialize controls below 
            
        }
        private void InitializeControls() //these are my controls 
        { 
            txtTask = new TextBox { Location = new Point(124, 119), Width = 200 };//this creates a text box that will hold strings 
            lstTasks = new ListBox { Location = new Point(500, 107), Width = 300, Height = 200 };//this will hold the tasks 

            bttnAdd = new Button { Text = "Add Task", Location = new Point(124, 167), Width = 100 }; //creates add task button 
            bttnRemove = new Button { Text = "Remove Task", Location = new Point(329, 167), Width = 100 };//creates a remove task button
            bttnSave = new Button { Text = "Save Tasks", Location = new Point(224, 167), Width = 100 };//creates a bttnsave 

            // Attach event handlers
            bttnAdd.Click += new EventHandler(bttnAdd_Click);//creates  event handler when the button is clicked 
            bttnRemove.Click += new EventHandler(bttnRemove_Click);//event handler for remove task button
            bttnSave.Click += new EventHandler(bttnSave_Click);//event handle which is for only specific instance which is when the button is pressed 

            //add lst tasks 
            Controls.Add(txtTask);//adds the input box 
            Controls.Add(lstTasks);//adds the list box 
            Controls.Add(bttnAdd);//add task button 
            Controls.Add(bttnRemove);//remove task button 
            Controls.Add(bttnSave); //save tasks button 
        }

        private void AddTask()//creating a private Add Task method that I can use later 
        {
            MessageBox.Show($"Task Entered: {txtTask.Text}");//this will bring up a message box that first shows that a task was recieved and what the associating task is 
            if (!String.IsNullOrWhiteSpace(txtTask.Text)) //this checks txt task box that i created to see if you there is just blank spaces or no text 
            {
                var taskItem = new TaskItem { TaskId = taskdIdCounter++, TaskDescription =txtTask.Text };
                // variable of task Itewm is intialized and then a unique id with increments to count along with the description of the task
                tasks.Add(taskItem); //adds the list string to the task list 
                UpdateTaskList();// refreshes the task and should show the new item on the list 
                txtTask.Clear();//clears the input box once it is added to the task list 
            }
            else
            {
                MessageBox.Show("Warning:Please Enter a task before continuing");//this occurs ifyou try to add empty value 
            }
        }
        private void bttnAdd_Click(object sender, EventArgs e)
        {//EVENt handler for the add task button once it is clicked. 
             
            AddTask(); //runs add task method
             
        }

        private void DisplayTasks(List<TaskItem> tasks) 
            //creating display tasks method which will write the code out, using taskitem in the list section is where t
            //they will be stored 
        {
            Console.WriteLine("To-DO List:");// prints out string "to do list: "
            foreach (var task in tasks)//will go through each item
            {
                Console.WriteLine($"-{task}"); //this will create a bullet and the task that was created in the text box  
            }
        }
        private void UpdateTaskList()//this is a method i am using to update the task list after every entry
            //this will allow the computer to show what was inputed instead of just storing it 
        {
            MessageBox.Show("UPDATE TASK LIST...");//will have a pop up box showing that the update task list is being worked on 
             
            foreach (var task in tasks)//loops through list 
            {
                lstTasks.Items.Add($"{task.TaskId}: {task.TaskDescription}");//adds each task to list task box

            }
        }

        private void RemoveTask()//this method I am making to remove the task. I will call it later using my button
        {
            if (lstTasks.SelectedIndex != -1)//first make sure a task is selected. the -1 will return if its nothing
            {
                int index = lstTasks.SelectedIndex;//this first stores the number associated in the index 
                tasks.RemoveAt(index); // Remove from list
                lstTasks.Items.RemoveAt(index); // Remove from ListBox UI
            }
            else//using an if else statement if nothing is picked 
            {
                MessageBox.Show("Warning: Please select a task before continuing");
            }   //messagebox that pops up a warning letting the user know they must pick a task before continuing 
        }



        private void bttnRemove_Click(object sender, EventArgs e)
        {//this will occur during a specific circumstance which is when the button is clicked
            RemoveTask();//when button is clicked the method remove task is implemented
            //which you will have to select a task and then click the button 
        }


        private void SaveTasks() //save task method
        {
            string filePath = Path.Combine(Application.StartupPath, "tasks.txt");
            // first creats a filepath, goes to the folder runs, and make sure that this will be stored there
            File.WriteAllLines(filePath, tasks.Select(task => $"{task.TaskId}: {task.TaskDescription}"));
            //writes tasks in files formatted with numbers and then with the description 
            MessageBox.Show("Your To Do List Has Been Saved!"); 
            //message box appears that the do list is saved 
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {//this is event handler that will run when it is clicked
            SaveTasks(); //save task methodology is then ran 
        }  

      
        public class TaskItem
        { //will store description and number 
            public int TaskId { get; set; }
            //this is the unique id or Number tht will be stored ie 1,2,3 
            public string TaskDescription { get; set; }
            //descritpion of the task, ie take out trash 
        }
       

        private void 
            TxtInput1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }


}
