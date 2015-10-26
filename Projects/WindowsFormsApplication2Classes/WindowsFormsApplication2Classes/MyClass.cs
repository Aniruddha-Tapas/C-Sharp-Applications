using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNamespace
{
/*    namespace MySubNameSpace{
    
    } 
    class MyClass
    {
        /* enum Colors
        {
            Red,
            Blue,
            Green,
        }

        Colors myColor = Colors.Red;

        string Name;
        public MyClass(string name){
            Name = name;
        }

        public string name()
        {
            return Name;
        }

        public static void ShowMessage(string message) {
            System.Windows.Forms.MessageBox.Show(message);

        }
        public static void ShowMessage(int message)
        {
            System.Windows.Forms.MessageBox.Show(message.ToString());

        }
        
        public MyClass(string name)
        {
            Name = name;
        }
        public string Name
        {
            get;
            /*private*/
        /*set;
}
        

string myString;
public MyClass(string name)
{
myString = name;
}
public string Name
{
get { return myString; }
set {
 if (value == "") System.Windows.Forms.MessageBox.Show("Cant do that");
}
}
        
static Exception myException = new Exception("Cant do that");
public static void CheckString(string myString) 
{
if (myString == "") throw myException;
}
        

private string Name = "Ani";
protected int Age = 19;
public virtual void ShowMessage(string Message) {
System.Windows.Forms.MessageBox.Show(Message);
}
}
    
class MySecondClass : MyClass , IMyInterface
{
public string SName = "Tapas";
public void MessageBoxSpecial()
{
System.Windows.Forms.MessageBox.Show(base.Age.ToString());
}
public override /*new*/
    /*void ShowMessage(string message) 
{
System.Windows.Forms.MessageBox.Show(message,"MyTitle");
}
public void MyVoid() 
{
base.ShowMessage("My Void");
}
}

interface IMyInterface
{
void MyVoid();
}

    //Indexers
    public string this[int index]
    {
        get { return MyArray[index]; }
        set { MyArray[index] = value; }
    }
    string[] MyArray = { "A", "B", "C" };
         

    //structs
    struct Client 
    {
        public Client(string name)
        {
            Name = name;
            age = 0;
        }

        public string Name;
        public int age;
        public void ClearClientInfo(){
            Name="";
            age=0;
        }
    }

    interface IClient
    {
        public string Name;
    }
        
    //Partials
    partial class MyClass
    {
        public string Name = "A";
        public int age = 19;
        public void Message(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }
        public void ShowMessage(string message)
        {
            Message(message);
        }
        
        //Abstracts
        abstract class MyClass
        {
            public string Name = "A";
            public int age = 19;
            public void Message(string message)
            {
                System.Windows.Forms.MessageBox.Show(message);
            }
            public abstract void ShowMessage(string message);
       
        }
        class MySecondClass : MyClass
        {
            public override void ShowMessage(string message)
            {
                System.Windows.Forms.MessageBox.Show(message);
            }
             
    //Delegates
    class MyClass
    {
        delegate void MyDelegate(string myString);
        public void ShowThoseMessages()
        {
            MyDelegate md = new MyDelegate(ShowMessage);
            md += ShowAnotherMessage;
            md("Ani");
        }
        void ShowMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }
        void ShowAnotherMessage(string a)
        {
            System.Windows.Forms.MessageBox.Show(a,"Test");
        }
        
        //Events
        class MyClass
        {
            public event EventHandler OnPropertyChanged;

            string name = "";
            public string Name
            {
                get { return name;}
                set 
                {
                    name = value;
                    OnPropertyChanged(this, new EventArgs());
                }
             }
        }    
        */

}

